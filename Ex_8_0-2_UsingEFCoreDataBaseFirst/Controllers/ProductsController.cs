using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Ex_8_0_UsingEFCoreDataBaseFirst.models.db;

namespace Ex_8_0_UsingEFCoreDataBaseFirst.Controllers
{
    public class ProductsController : Controller
    {
        northwindContext edm = new northwindContext();

        public IActionResult Index()
        {
            // qry ออกมาแล้วส่งออกไปทาง view
            var ps = from p in edm.Products select p;
            return View(ps);
        }
    }
}