using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _4_4_UsingMultipleModels.Models;

namespace _4_4_UsingMultipleModels.Controllers
{
    public class HomeController : Controller
    {
        //วิธีเรียก 3 ตัวอย่าง

        public IActionResult Index()
        {
            //AllCustomers กับ AllProducts เป็น Property ที่ไม่ได้ประกาศเลย สร้างขึ้นเพียวๆ ตรงนี้เลย
            // รับค่ามาเป็น List จาก Method ข้างล่างเลย
            // มันจะรู้เอง ว่าเป็น List แล้วไปวนลูป ใน Foreach ใน view เอา
            ViewBag.AllCustomers  = GetAllCustomers();
            ViewBag.AllProducts = GetAllProduct();

            return View();
            // ไปพิมพ์ Code ต่อที่ View Index 
            // ต้องพิมพ์เอง generate ไม่ได้
        }

        public ActionResult ByViewModel()
        {
            // ใช้ร่วมกับ class ViewDataModel เพื่อประกาศตัวแปร เก็บค่า
            // แล้วเก็บค่า จาก GetAll... 
            // IEnumerable รับค่า จาก List
            // ต้องส่งออกผ่าน  View(data)

            ViewDataModel data = new ViewDataModel();
            data.GetCustomers = GetAllCustomers();
            data.GetProducts = GetAllProduct();

            return View(data);  // ---> 
        }

        public ActionResult ByViewData()
        {
            //ไม่ต้องประกาศ ViewData และ ชื่อข้อมูล AllCustomers /  AllProducts  คือกำหนดลงไปได้เลย แล้วรับค่าได้เลย
            // ไม่ต้องส่งออก return View()
            ViewData["AllCustomers"] = GetAllCustomers();
            ViewData["AllProducts"] = GetAllProduct(); // ตอนทดสอบ ใส่ผิดเป็น GetAllCustomers แต่ ไม่ Error ตอน run แต่ไป error ตอนแสดงผล

            return View();
        }
        //---------------------------------------------------------------------------------------------------
        public List<Customers> GetAllCustomers()
        {
            List<Customers> lstCustomer = new List<Customers>();
            lstCustomer.Add(new Customers
            {
                CustomerID = "A001",
                FullName = "ศุพชัย สมพานิช",
                Address = "กรุงเทพ"
            });

            lstCustomer.Add(new Customers
            {
                CustomerID = "A002",
                FullName = "สมใจ คิดเจริญ",
                Address = "อยุธยา"
            });

            lstCustomer.Add(new Customers
            {
                CustomerID = "A003",
                FullName = "สมชาย พรเจริญมิตร",
                Address = "เชียงราย"
            });

            return lstCustomer;
        }

        public List<Products> GetAllProduct()
        {
            List<Products> lstProducts = new List<Products>();

            lstProducts.Add(new Products
            {
                ProductID = 111,
                ProductName = "Using C# สำหรับผุ้เริ่มต้น",
                ProductPrice = 300
            });

            lstProducts.Add(new Products
            {
                ProductID = 222,
                ProductName = "Using C# DataBase",
                ProductPrice = 275
            });

            return lstProducts;

        }

        //---------------------------------------------------------------------------------------------------

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
