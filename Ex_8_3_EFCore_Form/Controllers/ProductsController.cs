using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

using Ex_8_0_UsingEFCoreDataBaseFirst.models.db;

namespace Ex_8_0_UsingEFCoreDataBaseFirst.Controllers
{
    public class ProductsController : Controller
    {
        northwindContext edm = new northwindContext();

        public IActionResult Index()
        {
            ViewData["CategoryId"] = new SelectList(edm.Categories, "CategoryId", "CategoryName");
            ViewData["SupplierId"] = new SelectList(edm.Suppliers, "SupplierId", "CompanyName");

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(Products products)
        {
            if (ModelState.IsValid)
            {
                edm.Add(products);
                await edm.SaveChangesAsync();
                //return RedirectToAction(nameof(Index));
                return RedirectToAction("Index", "ProductsJoinCategory");// ทดสอบ redirect ไปหน้าอื่น ข้าม Controler
                // ใส่แต่ชื่อไม่ใส่ Controler
            }

            ViewData["CategoryId"] = new SelectList(edm.Categories, "CategoryId", "CategoryName", products.CategoryId);
            ViewData["SupplierId"] = new SelectList(edm.Suppliers, "SupplierId", "CompanyName", products.SupplierId);
            return View(products);

        }


        public IActionResult SearchProducts(string q) // q รับค่ามา
        {
            if (string.IsNullOrEmpty(q)) // เช็คว่า ว่างไหม
            {   //ถ้าว่าง ให้ กลับไปที่ products - index ส่งออก
                return View("Index", edm.Products.ToList());
            }
            else
            {   //ถ้ามีค่า ให้ กลับไปที่ products - index ส่งออก
                return View("Index", edm.Products.Where(p => p.ProductName.Contains(q)).ToList());
            }

        }
    }
}