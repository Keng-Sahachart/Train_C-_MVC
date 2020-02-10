using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _3UsingModel.Models;
namespace _3UsingModel.Controllers // ต้อง using Model เข้ามาก่อน ไม่งั้น จะประกาศ ตัวแปรไม่ได้
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            Product p = new Product();
            p.ProductID = "111";
            p.ProductName = "ASP.Net Core MVC เบื่องต้น";
            p.ProductPrice = 299;

            return View(p);
        }
    }
}