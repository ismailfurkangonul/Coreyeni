using Coreyeni.Data.Contexts;
using Coreyeni.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Coreyeni.Controllers
{
    public class HomeController : Controller
    {
        
        
        public IActionResult Index()
        {
            //create
            EFCoreContext context = new();
            context.Products.Add(new Product { Name="Furkan",Price=30741});
            context.SaveChanges();

            //read
            List<Product> productList = context.Products.Where(x=>x.Price>301).ToList();

            //update
            Product updatedProduct = context.Products.Where(y => y.Id == 3).FirstOrDefault();
            updatedProduct.Price = 301;
            updatedProduct.Name = "testurunu";
            context.Products.Update(updatedProduct);
            context.SaveChanges();

            //delete
            List<Product> removedProduct = context.Products.Where(x => x.Name.Contains("u")).ToList();
            context.Products.RemoveRange(removedProduct);
            context.SaveChanges();

            return View(productList);
        }
    }
}
