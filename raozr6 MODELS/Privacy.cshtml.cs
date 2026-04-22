using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR6VIEVM.Models;

namespace RAZOR6VIEVM.Pages
{
    public class PrivacyModel : PageModel
    {
        public Student Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student
            {
                Ad = "İsmail",
                Yas = 18,
                Ortalama = 85,
            };
        }
    }
}