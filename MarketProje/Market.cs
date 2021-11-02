using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketProje
{
    
    public static class Market
    {
        public static List<Sube> subeler = new List<Sube>();
        public static List<Calisan> calisanlar = new List<Calisan>();
        public static List<Calisan> calisanlar1 = new List<Calisan>();
        public static List<Urun> temizlikurun = new List<Urun>();
        public static List<Urun> gıdaurun = new List<Urun>();
        public static List<Urun> kampanyaurun = new List<Urun>();

        public static void SubeEkle(Sube subeobje)
        {
            subeler.Add(subeobje);      
        }
        
        public static void Calisanekle(Calisan calisan)
        {
            calisanlar.Add(calisan);
        }

        public static void CalisanEkle1(Calisan calisan1)
        {
            calisanlar1.Add(calisan1);
        }

        public static void UrunEkle(Urun urun)
        {
            temizlikurun.Add(urun);
        }

        public static void GıdaUrunEkle(Urun gıda)
        {
            gıdaurun.Add(gıda);
        }

        public static void KampanyaUrunEkle(Urun kampanya)
        {
            kampanyaurun.Add(kampanya);
        }
    }
}
    
