using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR6VIEVM.Models;

namespace RAZOR6VIEVM.Pages
{
    public class test1Model : PageModel
    {
        public StudentViewModel Ogrenci { get; set; }

        public void OnGet()
        {
            Ogrenci = new StudentViewModel
            {
                Ad = "İsmail",
                Soyad = "Yalçın"
            };
        }
    }
}