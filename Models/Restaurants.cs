using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Provo_Rest_Assignment4_ZS.Models
{
    public class Restaurants
    {

        //Constructor that sets the rank of each entered restaurant so that it is not edible after creation
        public Restaurants(int rank)
        {
            Rank = rank;
        }

        [Required]
        public int Rank { get; }
        [Required]
        public string Name { get; set; }

        #nullable enable
        public string? Dish { get; set; } = "It's all tasty";
        #nullable disable

        [Required]
        public string Address { get; set; }

        #nullable enable
        [RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]")]
        public string? Phone { get; set; }
       
        public string? Website_Link { get; set; } = "Coming Soon!!!";
        #nullable disable


        //Method that fills a list with objects that contain preset restaurant information
        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(1)
            {
                Name = "Taco Bell",
                Address = "Provo, Utah",
                Dish = "Taco",
                Phone = "801-422-8722",
                Website_Link = null
            };

            Restaurants r2 = new Restaurants(2)
            {
                Name = "J Dawgs",
                Address = "Provo, Utah",
                Dish = null,
                Phone = "801-422-5563",
                Website_Link = "www.jdawgs.com"
            };

            Restaurants r3 = new Restaurants(3)
            {
                Name = "Olive Garden",
                Address = "Provo, Utah",
                Dish = "Pasta",
                Phone = "801-886-3427",
                Website_Link = "www.olivegarden.com"
            };

            Restaurants r4 = new Restaurants(4)
            {
                Name = "Noodles and Co.",
                Address = "Provo, Utah",
                Dish = "Mac N' Cheese",
                Phone = "435-224-3021",
                Website_Link = "www.noodlesandco.com"
            };

            Restaurants r5 = new Restaurants(5)
            {
                Name = "Panda Express",
                Address = "Provo, Utah",
                Dish = "Orange Chicken",
                Phone = "801-198-0032",
                Website_Link = "www.pandaexpress.com"
            };

            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
