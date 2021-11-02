using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProje
{
    public class Sube:Adres
    {
        public string SubeAdi { get; set; }

        public override string ToString()
        {
            return SubeAdi + Sehir + Ilce + Mahalle + AcikAdres;
        }


    }
}
