using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using System.ComponentModel.DataAnnotations; // สำหรับ แก้ display ชื่อ Property ตอนแสดงผล

namespace _4_3_BasicDataAnnotation.Models
{
    public class Product
    {
        [Display(Name ="รหัสสินค้า")]   // ต้องใช้ word name เท่านั้น และ ประกาศก่อนบรรทัด ประกาศตัวแปร
        public string ProductID { get; set; }

        [Display(Name ="ชื่อสินค้า")]
        public string ProductName { get; set; }

        [Display(Name = "ราคาสินค้า")]
        public int ProductPrice { get; set; }
    }
}
