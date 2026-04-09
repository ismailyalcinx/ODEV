namespace RAZOR6VIEVM.Models
{
    public class StudentViewModel
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        public string FullName => Ad + " " + Soyad;
    }
}