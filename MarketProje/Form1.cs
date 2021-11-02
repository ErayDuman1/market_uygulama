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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void BtnGiris_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran(); 
            KampanyaUrun kampanyaekrani = new KampanyaUrun();

            if (txtKullanici.Text == "Admin" && txtSifre.Text == "1234")
            {
                ana.Show();
            }

            else if (txtKullanici.Text == "Eray Duman" && txtSifre.Text == "1234")
            {
                kampanyaekrani.Show();
            }

            else if (txtKullanici.Text == "Kemal Şahin" && txtSifre.Text == "1234")
            {
                kampanyaekrani.Show();
            }

            else
            {
                MessageBox.Show("Girdiğiniz bilgiler yanlıştır!");
            }
              
            foreach (TextBox text in this.Controls.OfType<TextBox>())
            {
                text.Text = "";
            }
        }
    }
}
