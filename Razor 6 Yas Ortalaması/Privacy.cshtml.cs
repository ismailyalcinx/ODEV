using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR6YASORTALAMASI.Models;

namespace RAZOR6YASORTALAMASI.Pages
{
    public class test1Model : PageModel
    {
        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student
            {
                Ad = "ismail",
                Yas = 18,
                Ortalama = 85.5
            };
        }
    }
}