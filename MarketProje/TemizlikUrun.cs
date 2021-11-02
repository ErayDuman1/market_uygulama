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
    public partial class TemizlikUrun : Form
    {
        public TemizlikUrun()
        {
            InitializeComponent();
        }
        Tedarikci tedarikci = new Tedarikci();
        Urun urun = new Urun();
        Urun urun1 = new Urun();
        Urun urun2 = new Urun();
        Urun urun3 = new Urun();
        private void TemizlikUrun_Load(object sender, EventArgs e)
        {   
            tedarikci.TedarikIsim = "Temizlik Urunleri Ltd. Şti.";
            tedarikci.Sehir = "İstanbul";
            tedarikci.Ilce = "Bayrampaşa";
            tedarikci.Mahalle = "Cevatpaşa";
            tedarikci.AcikAdres = "Okul Sk.";
            
            urun.UrunId = "7E965";
            urun.UrunIsim = "XYZ Bulaşık Deterjanı 250ml";
            urun.UrunFiyat = 19.99;
            urun.Kampanya = 0;
            urun.Stok = 153;
            Market.UrunEkle(urun);
           
            urun1.UrunId = "7E966";
            urun1.UrunIsim = "Cifff Yağ Sökücü 100ml";
            urun1.UrunFiyat = 19.99;
            urun1.Kampanya = 0;
            urun1.Stok = 154;
            Market.UrunEkle(urun1);
            
            urun2.UrunId = "7E967";
            urun2.UrunIsim = "Turkish-Brite Bulaşık Süngeri 3'lü";
            urun2.UrunFiyat = 2.99;
            urun2.Kampanya = 0;
            urun2.Stok = 46;
            Market.UrunEkle(urun2);
            
            urun3.UrunId = "7E968"; 
            urun3.UrunIsim = "Bongi Toz Çamaşır Deterjanı 6KG";
            urun3.UrunFiyat = 39.99;
            urun3.Kampanya = 0;
            urun3.Stok = 24;
            Market.UrunEkle(urun3);
            dgvTemizlikUrun.DataSource = null;
            dgvTemizlikUrun.DataSource = Market.temizlikurun;

            for (int i = 0; i < dgvTemizlikUrun.Columns.Count - 1; i++)
            {
                dgvTemizlikUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvTemizlikUrun.Columns[dgvTemizlikUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvTemizlikUrun.Columns.Count; i++)
            {
                int sutun = dgvTemizlikUrun.Columns[i].Width;
                dgvTemizlikUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvTemizlikUrun.Columns[i].Width = sutun;
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
                dgvTemizlikUrun.DataSource = null;
                dgvTemizlikUrun.DataSource = Market.temizlikurun;

                for (int i = 0; i < dgvTemizlikUrun.Columns.Count - 1; i++)
                {
                    dgvTemizlikUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvTemizlikUrun.Columns[dgvTemizlikUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvTemizlikUrun.Columns.Count; i++)
                {
                    int sutun = dgvTemizlikUrun.Columns[i].Width;
                    dgvTemizlikUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvTemizlikUrun.Columns[i].Width = sutun;
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
            MessageBox.Show(tedarikci.TedarikListele());
        }
    }
}
