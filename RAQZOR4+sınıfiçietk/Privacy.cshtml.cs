using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;

namespace proje11.Pages
{
    public class test1Model : PageModel
    {
        public List<int> Sayilar { get; set; }

        public void OnGet()
        {
            Sayilar = new List<int> { 10, 15, 22, 33, 40 };
        }
    }
}