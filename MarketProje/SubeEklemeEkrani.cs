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
    public partial class SubeEklemeEkrani : Form
    {

        public SubeEklemeEkrani()
        {
            InitializeComponent();
        }

        private void BtnSubeEkle_Click(object sender, EventArgs e)
        {
            Sube s= new Sube();
            
            if(txtSubeSehir.Text==""||txtSubeIlce.Text==""||txtSubeMahalle.Text==""||txtSubeAdres.Text=="")
            {
                MessageBox.Show("Lütfen adres bilgierinizi eksiksiz giriniz");
            }
            else
            {
                s.SubeAdi = Convert.ToString(txtSubeAdi.Text);
                s.Sehir = Convert.ToString(txtSubeSehir.Text);
                s.Ilce = Convert.ToString(txtSubeIlce.Text);
                s.Mahalle = Convert.ToString(txtSubeMahalle.Text);
                s.AcikAdres = Convert.ToString(txtSubeAdres.Text);
                Market.SubeEkle(s);
                dgvSubeEkle.DataSource = null;
                dgvSubeEkle.DataSource = Market.subeler;
                dgvSubeEkle.AutoResizeColumns();

                for (int i = 0; i < dgvSubeEkle.Columns.Count - 1; i++)
                {
                    dgvSubeEkle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
                dgvSubeEkle.Columns[dgvSubeEkle.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                for (int i = 0; i < dgvSubeEkle.Columns.Count; i++)
                {
                    int sutun = dgvSubeEkle.Columns[i].Width;
                    dgvSubeEkle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgvSubeEkle.Columns[i].Width = sutun;
                }
            }
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Text = "";
            }
        }

        private void SubeEklemeEkrani_Load(object sender, EventArgs e)
        {
            Sube sube = new Sube();
            sube.SubeAdi = "Akançay Market";
            sube.Sehir = "Antalya";
            sube.Ilce = "Muratpaşa";
            sube.Mahalle = "Paşa";
            sube.AcikAdres = "Paşa Mahallesi Ata Sokak Numara:8 MuratPaşa/Antalya";
            Market.SubeEkle(sube);

            Sube sube1 = new Sube();
            sube1.SubeAdi = "Akançay Market";
            sube1.Sehir = "Manisa";
            sube1.Ilce = "Turgutlu";
            sube1.Mahalle = "Oduncular";
            sube1.AcikAdres = "Paşa Mahallesi Okul Sokak Numara:10 Turgutlu/Manisa";
            Market.SubeEkle(sube1);
            dgvSubeEkle.DataSource = null;
            dgvSubeEkle.DataSource = Market.subeler;
            dgvSubeEkle.AutoResizeColumns();

            for (int i = 0; i < dgvSubeEkle.Columns.Count - 1; i++)
            {
               dgvSubeEkle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvSubeEkle.Columns[dgvSubeEkle.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvSubeEkle.Columns.Count; i++)
            {
                int sutun = dgvSubeEkle.Columns[i].Width;
                dgvSubeEkle.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvSubeEkle.Columns[i].Width = sutun;
            }
        }
    }
}
