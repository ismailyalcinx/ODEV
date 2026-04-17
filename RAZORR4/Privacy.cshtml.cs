using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class test1Model : PageModel
    {
        [BindProperty]
        public bool GirisYaptiMi { get; set; }

        public void OnGet()
        {
        }

        public void OnPost(bool durum)
        {
            GirisYaptiMi = durum;
        }
    }
}