using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

using Microsoft.EntityFrameworkCore;
using Ex_8_0_UsingEFCoreDataBaseFirst.models.db;

namespace Ex_8_0_UsingEFCoreDataBaseFirst.Controllers
{
    public class ProductsJoinCategoryController : Controller
    {
        northwindContext edm = new northwindContext();

        public IActionResult Index()
        {
            var ps = edm.Products.Include(c => c.Category);   // Include --> using Microsoft.EntityFrameworkCore;

            return View(ps);
        }
    }
}