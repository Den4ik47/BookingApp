using BookingApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace BookingApp.Binders
{
    public class BookModelBinder : IModelBinder
    {
        public object BindModel(ControllerContext controllerContext, ModelBindingContext bindingContext)
        {
            var valueProvider = bindingContext.ValueProvider;     
            ValueProviderResult vprId = valueProvider.GetValue("id");
            string name = (string)valueProvider.GetValue("Name").ConvertTo(typeof(string));
            string author = (string)valueProvider.GetValue("Author").ConvertTo(typeof(string));
            int price = (int)valueProvider.GetValue("Price").ConvertTo(typeof(int));
            Book book = new Book() { Name = name+"(new)", Author = author, Price = price };

            // if Id alredy exist  (Edit)
            if (vprId != null)
            {
                book.Name = name; // without new
                book.id = (int)vprId.ConvertTo(typeof(int));
            }
            return book;
        }
    }
}
    