using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RAZOR7.Models; // Student modelini görmesi için şart!

namespace RAZOR7.Pages
{
    public class test1Model : PageModel
    {
        [BindProperty]
        public Student Ogrenci { get; set; }

        public string Mesaj { get; set; }

        public void OnGet()
        {
            // İlk açılışta nesne boş kalmasın diye oluşturuyoruz
            Ogrenci = new Student();
        }

        public void OnPost()
        {
            // Kritik Kontrol: Kurallara uyulmuş mu?
            if (!ModelState.IsValid)
            {
                return; // Hata varsa metodu burada kes, sayfayı hatalarla geri yükle
            }

            // Her şey doğruysa bu satıra geçer
            Mesaj = "Kayıt başarılı: " + Ogrenci.Ad;
        }
    }
}