namespace MarketProje
{
    partial class AnaEkran
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.tsbAnaSayfa = new System.Windows.Forms.ToolStrip();
            this.tsbSube = new System.Windows.Forms.ToolStripButton();
            this.tsbCalisan = new System.Windows.Forms.ToolStripButton();
            this.tsddTedarikci = new System.Windows.Forms.ToolStripDropDownButton();
            this.tsmiTemizlik = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiGida = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsmiKampanya = new System.Windows.Forms.ToolStripMenuItem();
            this.tsbAnaSayfa.SuspendLayout();
            this.SuspendLayout();
            // 
            // tsbAnaSayfa
            // 
            this.tsbAnaSayfa.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.tsbAnaSayfa.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tsbAnaSayfa.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSube,
            this.tsbCalisan,
            this.tsddTedarikci});
            this.tsbAnaSayfa.Location = new System.Drawing.Point(0, 0);
            this.tsbAnaSayfa.Name = "tsbAnaSayfa";
            this.tsbAnaSayfa.Size = new System.Drawing.Size(1332, 27);
            this.tsbAnaSayfa.TabIndex = 0;
            this.tsbAnaSayfa.Text = "ANASAYFA";
            // 
            // tsbSube
            // 
            this.tsbSube.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSube.Image = ((System.Drawing.Image)(resources.GetObject("tsbSube.Image")));
            this.tsbSube.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSube.Name = "tsbSube";
            this.tsbSube.Size = new System.Drawing.Size(72, 24);
            this.tsbSube.Text = "ŞUBELER";
            this.tsbSube.Click += new System.EventHandler(this.TsbSube_Click);
            // 
            // tsbCalisan
            // 
            this.tsbCalisan.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbCalisan.Image = ((System.Drawing.Image)(resources.GetObject("tsbCalisan.Image")));
            this.tsbCalisan.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbCalisan.Name = "tsbCalisan";
            this.tsbCalisan.Size = new System.Drawing.Size(98, 24);
            this.tsbCalisan.Text = "ÇALIŞANLAR";
            this.tsbCalisan.Click += new System.EventHandler(this.TsbCalisan_Click);
            // 
            // tsddTedarikci
            // 
            this.tsddTedarikci.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsddTedarikci.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiTemizlik,
            this.toolStripSeparator3,
            this.tsmiGida,
            this.toolStripSeparator4,
            this.tsmiKampanya});
            this.tsddTedarikci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsddTedarikci.Image = ((System.Drawing.Image)(resources.GetObject("tsddTedarikci.Image")));
            this.tsddTedarikci.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsddTedarikci.Name = "tsddTedarikci";
            this.tsddTedarikci.Size = new System.Drawing.Size(118, 24);
            this.tsddTedarikci.Text = "TEDARİKÇİLER";
            // 
            // tsmiTemizlik
            // 
            this.tsmiTemizlik.Name = "tsmiTemizlik";
            this.tsmiTemizlik.Size = new System.Drawing.Size(317, 26);
            this.tsmiTemizlik.Text = "TEMİZLİK ÜRÜNLERİ";
            this.tsmiTemizlik.Click += new System.EventHandler(this.TsmiTemizlik_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(314, 6);
            // 
            // tsmiGida
            // 
            this.tsmiGida.Name = "tsmiGida";
            this.tsmiGida.Size = new System.Drawing.Size(317, 26);
            this.tsmiGida.Text = "GIDA ÜRÜNLERİ";
            this.tsmiGida.Click += new System.EventHandler(this.TsmiGida_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(314, 6);
            // 
            // tsmiKampanya
            // 
            this.tsmiKampanya.Name = "tsmiKampanya";
            this.tsmiKampanya.Size = new System.Drawing.Size(317, 26);
            this.tsmiKampanya.Text = "HAFTALIK KAMPANYALI ÜRÜNLER";
            this.tsmiKampanya.Click += new System.EventHandler(this.TsmiKampanya_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1332, 503);
            this.Controls.Add(this.tsbAnaSayfa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.Name = "AnaEkran";
            this.Text = "AnaEkran";
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.tsbAnaSayfa.ResumeLayout(false);
            this.tsbAnaSayfa.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.ToolStrip tsbAnaSayfa;
        private System.Windows.Forms.ToolStripDropDownButton tsddTedarikci;
        private System.Windows.Forms.ToolStripMenuItem tsmiTemizlik;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem tsmiGida;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem tsmiKampanya;
        private System.Windows.Forms.ToolStripButton tsbSube;
        private System.Windows.Forms.ToolStripButton tsbCalisan;
    }
}