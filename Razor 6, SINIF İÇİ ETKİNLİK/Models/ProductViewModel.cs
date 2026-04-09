namespace Razor6.Models
{
    public class ProductViewModel
    {
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public double KdvliFiyat => Fiyat * 1.20;
    }
}