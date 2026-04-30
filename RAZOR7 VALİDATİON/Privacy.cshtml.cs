using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR7.Models; // Kırmızı çizgiyi bitiren sihirli satır!

namespace RAZOR7.Pages
{
    public class test1Model : PageModel
    {
        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student
            {
                Ad = "Ali",
                Yas = 18,
                Ortalama = 90.0,
                Email = "ali@rastgele.com"
            };
        }
    }
}