using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR7.Models;

namespace RAZOR7.Pages
{
    public class test1Model : PageModel
    {
        [BindProperty]
        public Student Ogrenci { get; set; }

        public string Sonuc { get; set; }

        public void OnGet()
        {
            Ogrenci = new Student();
        }

        public void OnPost()
        {
            if (!ModelState.IsValid)
            {
                return;
            }

            Sonuc = "Kayıt tamam";
        }
    }
}