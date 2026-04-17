using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace proje11.Pages
{
    public class test1Model : PageModel
    {
        public List<string> Isimler { get; set; }

        public void OnGet()
        {
            Isimler = new List<string>
            {
                "Ali",
                "Ayşe",
                "Mehmet",
                "Zeynep"
            };
        }
    }
}