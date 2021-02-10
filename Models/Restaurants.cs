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
            public string? Phone { get; set; } = "";
       
            public string? Website_Link { get; set; } = "Coming Soon";
        #nullable disable


        //Method that fills a list with objects that contain preset restaurant information
        public static Restaurants[] GetRestaurants()
        {
            Restaurants r1 = new Restaurants(1)
            {
                Name = "Taco Bell",
                Address = "1244 N Freedom Blvd, Provo, UT 84604",
                Dish = "Taco Supreme",
                Phone = "801-377-7080",
                Website_Link = null
            };

            Restaurants r2 = new Restaurants(2)
            {
                Name = "J Dawgs",
                Address = "858 700 E, Provo, UT 84606",
                Dish = null,
                Phone = "801-373-3294",
                Website_Link = "https://jdawgs.com"
            };

            Restaurants r3 = new Restaurants(3)
            {
                Name = "Olive Garden",
                Address = "504 W 2230 N, Provo, UT 84604",
                Dish = "Spaghetti and Meat Sauce",
                Phone = "801-337-0062",
                Website_Link = "https://www.olivegarden.com"
            };

            Restaurants r4 = new Restaurants(4)
            {
                Name = "Noodles and Co.",
                Address = "62 West Bulldog Blvd, Provo, UT 84604",
                Dish = "Winsconsin Mac N' Cheese",
                Phone = "435-373-9670",
                Website_Link = "https://www.noodles.com"
            };

            Restaurants r5 = new Restaurants(5)
            {
                Name = "Panda Express",
                Address = "1240 N University Ave, Provo, UT 84604",
                Dish = "Orange Chicken Bowl",
                Phone = "801-818-0111",
                Website_Link = "https://www.pandaexpress.com"
            };

            return new Restaurants[] { r1, r2, r3, r4, r5 };
        }
    }
}
