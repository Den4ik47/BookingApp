using BookingApp.Binders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Models
{
    //[ModelBinder(typeof(BookModelBinder))]
    public class Book
    {
        [Key]
        public int id { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
        public string test = "Test";
    }
}