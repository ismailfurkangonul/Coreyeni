using Coreyeni.Data.Contexts;
using Coreyeni.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Coreyeni.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {
            EFCoreContext context = new();
            Product p = new Product();
            p.Name = "Furkan";
            p.Price = 12122;
            context.Products.Add(p);
            context.SaveChanges();
            return View();
        }
    }
}
