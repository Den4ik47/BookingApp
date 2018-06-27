using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookingApp.Models
{
    public class Purchase
    {
        [Key]
        public int Per_id { get; set; }
        public string Person { get; set; }
        public string Adress { get; set; }
        public int Book_id { get; set; }
        public string dateTime { get; set; }
    }
}