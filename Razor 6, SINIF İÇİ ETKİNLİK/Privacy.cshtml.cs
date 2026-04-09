using Microsoft.AspNetCore.Mvc.RazorPages;
using Razor6.Models;
using System.Collections.Generic;

namespace Razor6.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<ProductViewModel> Urunler { get; set; }

        public void OnGet()
        {
            Urunler = new List<ProductViewModel>
            {
                new ProductViewModel { Ad = "Klavye", Fiyat = 500 },
                new ProductViewModel { Ad = "Mouse", Fiyat = 300 },
                new ProductViewModel { Ad = "Monitör", Fiyat = 4500 }
            };
        }
    }
}