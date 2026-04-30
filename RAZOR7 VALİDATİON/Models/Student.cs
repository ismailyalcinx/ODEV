using System.ComponentModel.DataAnnotations;

namespace RAZOR7.Models
{
    public class Student
    {
        public string Ad { get; set; }
        public int Yas { get; set; }
        public double Ortalama { get; set; }

        [EmailAddress(ErrorMessage = "Geçerli email gir")]
        public string Email { get; set; }
    }
}