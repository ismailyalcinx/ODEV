using System.ComponentModel.DataAnnotations;

namespace RAZOR7.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Ad boş bırakılamaz")]
        public string Ad { get; set; }

        [Range(1, 100, ErrorMessage = "Yaş 1 ile 100 arasında olmalı")]
        public int Yas { get; set; }
    }
}