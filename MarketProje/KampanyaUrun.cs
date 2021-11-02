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
    public partial class KampanyaUrun : Form
    {
        public KampanyaUrun()
        {
            InitializeComponent();
        }
        Tedarikci tedarikci2 = new Tedarikci();
        Urun urun = new Urun();
        Urun urun1 = new Urun();
        Urun urun2 = new Urun();
        Urun urun3 = new Urun();

        private void KampanyaUrun_Load(object sender, EventArgs e)
        {
            tedarikci2.TedarikIsim = "Kampanya Urunleri Ltd. Şti.";
            tedarikci2.Sehir = "İstanbul";
            tedarikci2.Ilce = "Florya";
            tedarikci2.Mahalle = "Kurşunlu Mah.";
            tedarikci2.AcikAdres = "Mutlu Sk. No:7";

            urun.UrunId = "8G921";
            urun.UrunIsim = "Kefal Çaydanlık ";
            urun.UrunFiyat = 69.99;
            urun.Kampanya = 0;
            urun.Stok = 24;
            Market.KampanyaUrunEkle(urun);
           
            urun1.UrunId = "8G922";
            urun1.UrunIsim = "Babidas Spor Ayakkabı";
            urun1.UrunFiyat = 229.99;
            urun1.Kampanya = 0;
            urun1.Stok = 35;
            Market.KampanyaUrunEkle(urun1);
            
            urun2.UrunId = "8G923";
            urun2.UrunIsim = "Lazer Oyuncu Mause";
            urun2.UrunFiyat = 145.45;
            urun2.Kampanya = 0;
            urun2.Stok = 16;
            Market.KampanyaUrunEkle(urun2);
            
            urun3.UrunId = "8G924";
            urun3.UrunIsim = "Naber-Castell 12li Pastel Boya";
            urun3.UrunFiyat = 19.99;
            urun3.Kampanya = 0;
            urun3.Stok = 18;
            Market.KampanyaUrunEkle(urun3);
            dgvKampanyaUrun.DataSource = null;
            dgvKampanyaUrun.DataSource = Market.kampanyaurun;

            for (int i = 0; i < dgvKampanyaUrun.Columns.Count - 1; i++)
            {
                dgvKampanyaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvKampanyaUrun.Columns[dgvKampanyaUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvKampanyaUrun.Columns.Count; i++)
            {
                int sutun = dgvKampanyaUrun.Columns[i].Width;
                dgvKampanyaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvKampanyaUrun.Columns[i].Width = sutun;
            }
        }
        public void Kampanya(string id, int kampanya, double fiyat, Urun urun)
        {
            if (id == txtUrunId.Text)
            {
                kampanya = Convert.ToInt16(txtUrunKampanya.Text);
                fiyat -= (kampanya * fiyat / 100);
                urun.Kampanya = kampanya;
                urun.UrunFiyat = fiyat;
                urun.Kampanyatarih = DateTime.Now;
                dgvKampanyaUrun.DataSource = null;
                dgvKampanyaUrun.DataSource = Market.kampanyaurun;

                for (int i = 0; i < dgvKampanyaUrun.Columns.Count - 1; i++)
                {
                    dgvKampanyaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvKampanyaUrun.Columns[dgvKampanyaUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvKampanyaUrun.Columns.Count; i++)
                {
                    int sutun = dgvKampanyaUrun.Columns[i].Width;
                    dgvKampanyaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvKampanyaUrun.Columns[i].Width = sutun;
                }
            }
        }

        private void BtnKampanyaUygula_Click(object sender, EventArgs e)
        {
            Kampanya(urun.UrunId, urun.Kampanya, urun.UrunFiyat, urun);
            Kampanya(urun1.UrunId, urun1.Kampanya, urun1.UrunFiyat, urun1);
            Kampanya(urun2.UrunId, urun2.Kampanya, urun2.UrunFiyat, urun2);
            Kampanya(urun3.UrunId, urun3.Kampanya, urun3.UrunFiyat, urun3);
        }

        private void BtnTedarikAdres_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tedarikci2.TedarikListele());

        }
    }
}
