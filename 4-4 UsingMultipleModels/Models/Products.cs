using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_4_UsingMultipleModels.Models
{
    public class Products
    {
        //[Display(Name = "รหัสสินค้า")]   // ต้องใช้ word name เท่านั้น และ ประกาศก่อนบรรทัด ประกาศตัวแปร
        public int ProductID { get; set; }

        //[Display(Name = "ชื่อสินค้า")]
        public string ProductName { get; set; }

        //[Display(Name = "ราคาสินค้า")]
        public int ProductPrice { get; set; }
    }
}
