using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MarketProje
{
    public partial class Market1 : Form
    {
        public Market1()
        {
            InitializeComponent();
        }
        Calisan c = new Calisan();
        Calisan c1 = new Calisan();
        Calisan c2 = new Calisan();
        Calisan c3 = new Calisan();
        Calisan c4 = new Calisan();
        Calisan c5 = new Calisan();
        private void Market1_Load(object sender, EventArgs e)
        {
            c.Rutbe = "Müdür";
            c.AdSoyad = "Eray Duman";
            c.Adres = "Paşa Mah. Ata.sk MuratPaşa/Antalya";
            c.HaftalikIzinGün = "Pazartesi";
            c.YillikIzin = 8;
            c.Maas = 5000;
            c.CalismaSuresi="5 yıl";
            Market.Calisanekle(c);
            
            c1.Rutbe = "Müdür Yardımcısı";
            c1.AdSoyad = "Mehmet Akançay";
            c1.Adres = "Paşa Mah. Han.sk  Muratpaşa/Antalya";
            c1.HaftalikIzinGün = "Çarşamba";
            c1.YillikIzin = 13;
            c1.Maas = 3000;
            c1.CalismaSuresi = "2yıl";
            Market.Calisanekle(c1);
            
            c2.Rutbe = "Kasiyer";
            c2.AdSoyad = "Berkcan Bilcer";
            c2.Adres = "Paşa Mah. Davut.sk MuratPaşa/Antalya";
            c2.HaftalikIzinGün = "Cuma";
            c2.YillikIzin = 5;
            c2.Maas = 2000;
            c2.CalismaSuresi = "4 ay";
            Market.Calisanekle(c2);
            dgvSube1.DataSource = null;
            dgvSube1.DataSource = Market.calisanlar;
            dgvSube1.AutoResizeColumns();

            c3.Rutbe = "Müdür";
            c3.AdSoyad = "Kemal Şahin";
            c3.Adres = "Oduncular Mah. Site sk. Turgutlu/Manisa";
            c3.HaftalikIzinGün = "Cuma";
            c3.YillikIzin = 6;
            c3.Maas = 4500;
            c3.CalismaSuresi = "3 yıl";
            Market.CalisanEkle1(c3);
            
            c4.Rutbe = "Müdür Yardımcısı";
            c4.AdSoyad = "Musa Öztürk";
            c4.Adres = "Oduncular Mah. Paşa Sk. Turgutlu/Manisa";
            c4.HaftalikIzinGün = "Pazartesi";
            c4.YillikIzin = 2;
            c4.Maas = 2800;
            c4.CalismaSuresi = "1yıl";
            Market.CalisanEkle1(c4);
            
            c5.Rutbe = "Kasiyer";
            c5.AdSoyad = "Serkan";
            c5.Adres = "Oduncular Mah. Ata Sk. Turgutlu/Manisa";
            c5.HaftalikIzinGün = "Cuma";
            c5.YillikIzin = 13;
            c5.Maas = 2200;
            c5.CalismaSuresi = "1 Yıl";
            Market.CalisanEkle1(c5);
            dgvSube2.DataSource = null;
            dgvSube2.DataSource = Market.calisanlar1;
            dgvSube2.AutoResizeColumns();
        }

        public int MaasYukselt(int maas,string ad)
        {
            int x = maas;
            if (txtMaasAd.Text == ad)
            {
                maas = Convert.ToInt32(txtYeniMaas.Text);
                if (maas > x)
                {
                    x = maas;
                    dgvSube1.DataSource = Market.calisanlar;
                }
                else
                {
                    MessageBox.Show(x + "den büyük bir değer giriniz");
                }
            }
            return x;
        }

        private void BtnMaas_Click(object sender, EventArgs e)
        {
           c.Maas=MaasYukselt(c.Maas, c.AdSoyad);
           c1.Maas=MaasYukselt(c1.Maas, c1.AdSoyad);
           c2.Maas=MaasYukselt(c2.Maas, c2.AdSoyad);
        }

        public string RutbeYukselt(string ad,string rutbe)
        {
            if (txtAdRütbe.Text == ad)
            {
                rutbe = txtYeniRutbe.Text;
                dgvSube1.DataSource = Market.calisanlar;
            }
            return rutbe;    
        }

        private void BtnRütbe_Click(object sender, EventArgs e)
        {
            c.Rutbe=RutbeYukselt(c.AdSoyad, c.Rutbe);
            c1.Rutbe=RutbeYukselt(c1.AdSoyad, c1.Rutbe);
            c2.Rutbe=RutbeYukselt(c2.AdSoyad, c2.Rutbe);
        }

        public void CalisanAta(Calisan calisan )
        {           
            if (txtAdAta.Text== calisan.AdSoyad)
            {
                    dgvSube1.ClearSelection();
                    Market.calisanlar.Remove(calisan);
                    Market.calisanlar1.Add(calisan);
                    dgvSube1.DataSource = null;
                    dgvSube1.DataSource = Market.calisanlar;
                    dgvSube2.DataSource = null;
                    dgvSube2.DataSource = Market.calisanlar1;              
            }    
        } 
            
        private void BtnCalisanDegistir_Click(object sender, EventArgs e)
        { 
            CalisanAta(c);
            CalisanAta(c1);
            CalisanAta(c2);
        }
        public int MaasYukselt1(int maas, string ad, int a)
        {
            if (txtMaasAd1.Text == ad)
            {
                int x = maas;

                maas = Convert.ToInt32(txtYeniMaas1.Text);
                if (maas > x)
                {
                    dgvSube2.DataSource = Market.calisanlar1;
                    dgvSube2.Refresh();
                }
                else
                {
                    MessageBox.Show(x + "den büyük bir değer giriniz");
                }

            }
            return maas;
        }

        private void BtnMaasArttir_Click(object sender, EventArgs e)
        {
            c3.Maas = MaasYukselt1(c3.Maas, c3.AdSoyad, 0);
            c4.Maas = MaasYukselt1(c4.Maas, c4.AdSoyad, 1);
            c5.Maas = MaasYukselt1(c5.Maas, c5.AdSoyad, 2);
        }

        public string RutbeYukselt1(string ad, string rutbe)
        {
            if (txtAdRutbe1.Text == ad)
            {
                rutbe = txtYeniRutbe1.Text;
                dgvSube2.DataSource = Market.calisanlar1;

            }
            return rutbe;
        }

        private void BtnRutbeDegistir1_Click(object sender, EventArgs e)
        {

            RutbeYukselt1(c3.AdSoyad, c3.Rutbe);
            RutbeYukselt1(c4.AdSoyad, c4.Rutbe);
            RutbeYukselt1(c5.AdSoyad, c5.Rutbe);
        }
        public void CalisanAta1(Calisan calisan1)
        {
            if (txtAdAta.Text == calisan1.AdSoyad)
            {
                dgvSube2.ClearSelection();
                Market.calisanlar1.Remove(calisan1);
                Market.calisanlar.Add(calisan1);
                dgvSube2.DataSource = null;
                dgvSube2.DataSource = Market.calisanlar1;
                dgvSube1.DataSource = null;
                dgvSube1.DataSource = Market.calisanlar;
            }
        }
        private void BtnCalisanAta2_Click(object sender, EventArgs e)
        {
            CalisanAta1(c3);
            CalisanAta1(c4);
            CalisanAta1(c5);
        }        
    }
}
