using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace proje11.Pages
{
    public class test1Model : PageModel
    {
        public List<string> Ogrenciler { get; set; }

        public void OnGet()
        {
            Ogrenciler = new List<string>
            {
                "Ali",
                "Ayşe",
                "Fatma",
                "Mehmet",
                "Veli"
            };
        }
    }
}
