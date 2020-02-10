using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Ex_8_4_EFCore_SearchProduct.Model.db;

namespace Ex_8_4_EFCore_SearchProduct.Controllers
{
    public class ProductsController : Controller
    {
        NorthwindContext db = new NorthwindContext();

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult SearchProducts(string q) // q รับค่ามา
        {
            if (string.IsNullOrEmpty(q)) // เช็คว่า ว่างไหม
            {   //ถ้าว่าง ให้ กลับไปที่ products - index ส่งออก โดย select ทุกค่าเลย
                return View("Index", db.Products.ToList());
            }
            else
            {   //ถ้ามีค่า ให้ กลับไปที่ products - index ส่งออก เฉพาะ ProductName ที่ Contains คำที่ต้องการ
                return View("Index", db.Products.Where(p => p.ProductName.Contains(q)).ToList());
            }
        }
    }
}