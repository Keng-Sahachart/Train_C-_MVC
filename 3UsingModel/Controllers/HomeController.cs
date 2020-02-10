using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _3UsingModel.Models;

namespace _3UsingModel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var ProductList = new List<Product>();
            ProductList.Add(new Product { ProductID = "001", ProductName = "Using VB", ProductPrice = 299 });
            ProductList.Add(new Product { ProductID = "002", ProductName = "Using C#", ProductPrice = 350 });
            ProductList.Add(new Product { ProductID = "003", ProductName = "Using ASP.NET Core MVC", ProductPrice = 275 });



            return View(ProductList);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
