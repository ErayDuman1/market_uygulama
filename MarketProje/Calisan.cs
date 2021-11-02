using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProje
{
    public class Calisan
    {
        public string AdSoyad { get; set; }
        public string Rutbe { get; set; }
        public string Adres { get; set; }
        public int Maas { get; set; }
        public int YillikIzin { get; set; }
        public string HaftalikIzinGün { get; set; }
        public string CalismaSuresi { get; set; }

        public override string ToString()
        {
            return Rutbe + AdSoyad + Adres + Maas + YillikIzin + HaftalikIzinGün + CalismaSuresi;
        }




    }
}
