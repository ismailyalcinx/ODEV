using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR6OGRETMEN.Models;

namespace RAZOR6OGRETMEN.Pages
{
    public class PrivacyModel : PageModel
    {
        public List<OgretmenViewModel> Ogretmenler { get; set; }

        public void OnGet()
        {
            Ogretmenler = new List<OgretmenViewModel>
            {
                new OgretmenViewModel { Ad = "Ahmet Yılmaz", Brans = "Bilişim", Maas = 30000 },
                new OgretmenViewModel { Ad = "Ayşe Demir", Brans = "Matematik", Maas = 28000 },
                new OgretmenViewModel { Ad = "Mehmet Kaya", Brans = "Fizik", Maas = 29000 }
            };
        }
    }
}