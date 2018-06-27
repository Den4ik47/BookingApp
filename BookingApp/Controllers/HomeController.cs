using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BookingApp.Models;
using System.Threading.Tasks;
using System.Data.Entity;
namespace BookingApp.Controllers
{
    public class HomeController : Controller
    {
        BookContext db = new BookContext();
        public FilePathResult GetFile()
        {
            string file_path = Server.MapPath("~/Files/Command and Conquer Generals Zero Hour Data.rar");
            string file_type = "application/octet_stream";
            string file_name = "Command and Conquer Generals Zero Hour Data.rar";
            return File(file_path, file_type, file_name);
        }
        //BookContext context = new BookContext();
        public HomeController()
        {
            //Purchases =context.Read_Purchase();
            //Books=context.Read_Books();
        }
        public string Index1()
        {

            string browser = HttpContext.Request.Browser.Browser;
            string user_agent = HttpContext.Request.UserAgent;
            string url = HttpContext.Request.RawUrl;
            string ip = HttpContext.Request.UserHostAddress;
            string referrer = HttpContext.Request.UrlReferrer == null ? "" : HttpContext.Request.UrlReferrer.AbsoluteUri;
            return "<p>Browser: " + browser + "</p><p>User-Agent: " + user_agent + "</p><p>Url : " + url +
                "</p><p>Refer: " + referrer + "</p><p>IP: " + ip + "</p>";
        }
        public ActionResult Buy2(int id)
        {
            if (id > 3)
            {
                return Redirect("/Home/Index");
            }
            ViewBag.BookId = id;
            return View();
        }
        public ActionResult Testing()
        {
            return View();
        }
        [HttpPost]
        public string GetForm(string color)
        {
            return color;
        }
        public string GetName()
        {
            var val = Session["name"];
            return val.ToString();
        }
        public ActionResult GetList()
        {

            return PartialView();
        }
        public ActionResult Create() {
            return View();
        }
        [HttpPost]
        public string Create(Book book)
        {
            return book.Name+""+book.Author+""+book.Price;
        }
        [HttpPost]
        public ActionResult BookSearch(string name)
        {
            var allbooks = db.Books.Where(a => a.Author.Contains(name)).ToList();
            if (allbooks.Count <= 0)
            {
                return HttpNotFound();
            }
            return PartialView(allbooks);
        }
        public ActionResult Index()
        {
            ViewBag.Message = "This is partial ActionResult";
            Session["name"] = "Tom";
            HttpContext.Response.Cookies["id"].Value = "ca-4353w";
            IEnumerable<Book> book = db.Books.ToList();

            //ViewBag.Books = book;
            return View(book);
        }
        public async Task<ActionResult> BookList()
        {
            //    IEnumerable<Book> books = await context.Books.ToListAsync();
            return View("Index");
        }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.Bookid = id;
            Purchase purchase = new Purchase { Book_id = id, Person = "Guest" };
            return View(purchase);
        }

        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.dateTime = DateTime.Now.ToString();
            //context.SaveChanges_Purchase(purchase);
            return "Dzieki," + " " + purchase.Adress + " " + purchase.dateTime + " " + purchase.Person + ", za zakupy";
        }
        public string Save_book(Book book)
        {
            db.Books.Add(book);
            db.SaveChanges();
            return "Dzieki," + " " + book.Name + " " + book.Author + " " + book.Price + ", zostala stworzona";
        }
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}