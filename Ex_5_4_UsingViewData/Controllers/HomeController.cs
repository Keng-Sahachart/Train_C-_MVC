using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Ex_5_4_UsingViewData.Models;

namespace Ex_5_4_UsingViewData.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var cs = new List<Customer>
            {
                new Customer {CustomerID=111, FullName="ศุภชัย สมพานิช", Address="กรุงเทพ"}
                ,new Customer {CustomerID=222, FullName ="สมชาย รักเจริญ", Address="เชียงใหม่"}
                ,new Customer {CustomerID=333 , FullName="สมใจ บุญรัก", Address ="เลย"}
            };

            ViewData["CustomerList"]=cs;

            return View();
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
