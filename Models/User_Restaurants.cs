using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace IS413_Provo_Rest_Assignment4_ZS.Models
{
    public class User_Restaurants
    {
        [Required]
        public string User_Name { get; set; }

        [Required]
        public string Restaurant_Name { get; set; }

        [Required]
        public string Dish { get; set; } = "It's all tasty!";

        [Required, RegularExpression("[0-9][0-9][0-9]-[0-9][0-9][0-9]-[0-9][0-9][0-9][0-9]", 
            ErrorMessage = "Not a valid phone number (ex: 555-555-5555)")]
        public string Phone { get; set; }

    }
}
