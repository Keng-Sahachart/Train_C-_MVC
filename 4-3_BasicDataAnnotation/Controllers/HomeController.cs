using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _4_3_BasicDataAnnotation.Models;

namespace _4_3_BasicDataAnnotation.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var p = new Product();
            p.ProductID = "111";
            p.ProductName = "พื้นฐานการใช้งาน ASP.net Core MVC";
            p.ProductPrice = 299;

            return View(p);
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
