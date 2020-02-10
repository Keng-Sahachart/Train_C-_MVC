using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;  // ต้อง Using ก่อน ถึงจะใช้ได้

namespace Ex_5_2_ValidationWithDataAnnotation.Models
{
    public class User
    {

        [Key]
        public int UserID { get; set; }

        [Required(ErrorMessage  = "กรุณาป้อนชื่อ-สกุลด้วย")]
        public string FullName { get; set; }

        [Required(ErrorMessage ="กรุณาป้อน UserName ด้วย")]
        public string UserName { get; set; }

        [Required(ErrorMessage ="กรุณาป้อน รหัสผ่าน ด้วย 1")]
        public string Passwordx { get; set; }

        [Required(ErrorMessage ="กรุณาป้อน รหัสผ่าน ด้วย 2")]
        [Compare("Passwordx",ErrorMessage ="กรุณาป้อนรหัสผ่านให้เหมือนกัน")]
        public string PasswordAgain { get; set; }

    }
}
