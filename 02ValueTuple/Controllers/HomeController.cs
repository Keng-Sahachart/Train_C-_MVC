using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ValueTuple.Models;

namespace ValueTuple.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var FullName = (FirstName:"ศุพชัย",LastName: "สมพานิช");
            ViewData["myname"] = FullName.FirstName + " " + FullName.LastName;

            var result = 0;
            int x = 200;
            int y = 300;

            AddData(x, y);
            
            void AddData(int num1,int num2)
            {
                result = num1 + num2;
            }

            ViewData["result"] = result;


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
