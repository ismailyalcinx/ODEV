using System.ComponentModel.DataAnnotations;

namespace RAZOR7.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Ad zorunludur")]
        public string Ad { get; set; }

        [Range(1, 100, ErrorMessage = "Yaş 1-100 arasında olmalı")]
        public int Yas { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli email gir")]
        public string Email { get; set; }
    }
}