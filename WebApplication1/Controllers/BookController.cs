using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class BookController : Controller
    {
        public ActionResult Display()
        {
            var book = new BookModel
            {
                Name = "Sample Book",
                Author = "Jane Doe",
                PageNumber = 300,
                DueDate = DateTime.Now.AddDays(10)
            };

            ViewBag.book = book;
            return View();
        }

    }
}

