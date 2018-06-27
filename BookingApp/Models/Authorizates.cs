using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Authorizates
    {
   [Key]
        public string Name { get; set; }
       
        public string Surname { get; set; }
        [DataType(DataType.Password)]

        public string Password { get; set; }
    }
}