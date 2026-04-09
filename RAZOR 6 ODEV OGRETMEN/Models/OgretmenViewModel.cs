namespace RAZOR6OGRETMEN.Models
{
    public class OgretmenViewModel
    {
        public string Ad { get; set; }
        public string Brans { get; set; }
        public double Maas { get; set; }
        public double ZamliMaas => Maas * 1.10;
    }
}