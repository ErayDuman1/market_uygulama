using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProje
{
    public class Urun
    {
        public string UrunId { get; set; }
        public string UrunIsim { get; set; }
        public double UrunFiyat { get; set; }
        public int Kampanya { get; set; }
        public DateTime Kampanyatarih { get; set; }
        public int Stok { get; set; }
    }
}
