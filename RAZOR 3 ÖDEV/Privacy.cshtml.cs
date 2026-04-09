using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class PrivacyModel : PageModel
    {
        [BindProperty]
        public int Yas { get; set; }

        public string Mesaj { get; set; }

        public void OnGet()
        {
        }

        public void OnPost()
        {
            if (Yas < 0)
            {
                Mesaj = "Hata: Yaş 0'dan küçük olamaz!";
            }
            else if (Yas >= 18)
            {
                Mesaj = "Reşitsiniz";
            }
            else
            {
                Mesaj = "Reşit değilsiniz";
            }
        }
    }
}