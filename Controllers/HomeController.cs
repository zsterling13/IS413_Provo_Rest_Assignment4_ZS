using IS413_Provo_Rest_Assignment4_ZS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Provo_Rest_Assignment4_ZS.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        //Action for accessing Index Page
        //Passes in a list object with string type values for the pre-entered top 5 restaurants to be displayed on the index page
        public IActionResult Index()
        {
            List<string> restaurantList = new List<string>();

            foreach(Restaurants r in Restaurants.GetRestaurants())
            {
                restaurantList.Add($"#{r.Rank}: {r.Name}  --- Favorite Dish: {r.Dish ?? "It's all tasty!"}  ---  Address: {r.Address}  ---  Phone: {r.Phone}  ---  Website: {r.Website_Link ?? "Coming Soon"}");
            }

            return View(restaurantList);
        }

        //Action that shows a table of all user-submitted restaurants
        public IActionResult User_Submitted_Restaurants()
        {
            return View(Restaurant_List.Iterate_Restaurants);
        }

        //Action that shows an empty form for a user to submit a Restaurant's information
        [HttpGet]
        public IActionResult User_Submit()
        {
            return View();
        }

        //Action that submits a User's entered restaurant information
        //Only submits if the information the user entered into the form matches specifications
        //If the information is valid then the user will be redirected to a confirmation view
        //If the information is not valid then the user will stay on the current form page and see validation errors until they are corrected
        [HttpPost]
        public IActionResult User_Submit(User_Restaurants submission)
        {
            if (ModelState.IsValid == true)
            {
                Restaurant_List.AddRestaurant(submission);
                return View("Confirmation", submission);
            }
            else
                return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
