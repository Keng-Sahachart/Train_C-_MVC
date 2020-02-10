using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _4_4_UsingMultipleModels.Models
{  
    // ใช้เฉพาะ กับ ใน การแสดงผล แบบ ViewModel
    public class ViewDataModel // ตัวกลาง ในการแสดงผล แบบ ViewModel
    {
        //IEnumerable เหมือน จะประกาศ ให้เป็นตัวแปร คล้าย array เพื่อให้รันใน foreac ได้
        public IEnumerable<Customers> GetCustomers { set; get; }
        public IEnumerable<Products> GetProducts { set; get; }

    }
}
