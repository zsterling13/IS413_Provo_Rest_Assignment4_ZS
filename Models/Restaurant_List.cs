using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Provo_Rest_Assignment4_ZS.Models
{
    public class Restaurant_List
    {
        //Create an object that is a list of objects that are modeled off of the User_Restaurants class
        private static List<User_Restaurants> restaurant_List = new List<User_Restaurants>();

        //Create an iterable object from the restaurant list
        public static IEnumerable<User_Restaurants> Iterate_Restaurants => restaurant_List;

        //Method that adds the passed-in object to the restaurant list
        public static void AddRestaurant(User_Restaurants restaurant_add)
        {
            restaurant_List.Add(restaurant_add);
        }
    }
}
