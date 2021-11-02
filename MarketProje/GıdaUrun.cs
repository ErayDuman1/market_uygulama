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
    public partial class GıdaUrun : Form
    {
        public GıdaUrun()
        {
            InitializeComponent();
        }
        Tedarikci tedarikci1 = new Tedarikci();
        Urun urun = new Urun();
        Urun urun1 = new Urun();
        Urun urun2 = new Urun();
        Urun urun3 = new Urun();
        private void GıdaUrun_Load(object sender, EventArgs e)
        {
            tedarikci1.TedarikIsim = "Gıda Urunleri Ltd. Şti.";
            tedarikci1.Sehir = "İstanbul";
            tedarikci1.Ilce = "Kadıköy";
            tedarikci1.Mahalle = "FerhatPaşa";
            tedarikci1.AcikAdres = "Hanber Sk. No:8";

            urun.UrunId = "8F764";
            urun.UrunIsim = "Ekmek";
            urun.UrunFiyat = 1.25;
            urun.Stok = 205;
            Market.GıdaUrunEkle(urun);
            
            urun1.UrunId = "8F765";
            urun1.UrunIsim = "Bimbat Karışık Kuruyemiş";
            urun1.UrunFiyat = 12.49;
            urun1.Stok = 104;
            Market.GıdaUrunEkle(urun1);
            
            urun2.UrunId = "8F766";
            urun2.UrunIsim = "Koritos Peynirli Cips";
            urun2.UrunFiyat = 4.64;
            urun2.Stok = 67;
            Market.GıdaUrunEkle(urun2);
            
            urun3.UrunId = "8F767";
            urun3.UrunIsim = "Ondomie Körili Noodle";
            urun3.UrunFiyat = 2.45;
            urun3.Stok = 162;
            Market.GıdaUrunEkle(urun3);
            dgvGidaUrun.DataSource = null;
            dgvGidaUrun.DataSource = Market.gıdaurun;

            for (int i = 0; i < dgvGidaUrun.Columns.Count - 1; i++)
                {
                dgvGidaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            dgvGidaUrun.Columns[dgvGidaUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvGidaUrun.Columns.Count; i++)
                {
                    int sutun = dgvGidaUrun.Columns[i].Width;
                    dgvGidaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvGidaUrun.Columns[i].Width = sutun;
                }

        }
        public void Kampanya(string id, int kampanya,double fiyat,Urun urun)
        {
            if (id == txtUrunId.Text)
            {
                kampanya = Convert.ToInt16(txtUrunKampanya.Text);
                fiyat -= (kampanya * fiyat / 100);
                urun.Kampanya = kampanya;
                urun.UrunFiyat = fiyat;
                urun.Kampanyatarih = DateTime.Now;
                dgvGidaUrun.DataSource = null;
                dgvGidaUrun.DataSource = Market.gıdaurun;

                for (int i = 0; i < dgvGidaUrun.Columns.Count - 1; i++)
                {
                    dgvGidaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvGidaUrun.Columns[dgvGidaUrun.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvGidaUrun.Columns.Count; i++)
                {
                    int sutun = dgvGidaUrun.Columns[i].Width;
                    dgvGidaUrun.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvGidaUrun.Columns[i].Width = sutun;
                }
            }
        }

        private void BtnKampanyaUygula_Click(object sender, EventArgs e)
        {
            Kampanya(urun.UrunId, urun.Kampanya, urun.UrunFiyat,urun);
            Kampanya(urun1.UrunId, urun1.Kampanya, urun1.UrunFiyat,urun1);
            Kampanya(urun2.UrunId, urun2.Kampanya, urun2.UrunFiyat,urun2);
            Kampanya(urun3.UrunId, urun3.Kampanya, urun3.UrunFiyat,urun3);
        }

        private void BtnTedarikAdres_Click(object sender, EventArgs e)
        {
            MessageBox.Show(tedarikci1.TedarikListele());
        }
    }
}
