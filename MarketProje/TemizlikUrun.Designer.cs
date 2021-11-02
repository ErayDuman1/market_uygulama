
namespace MarketProje
{
    partial class TemizlikUrun
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
            this.btnKampanyaUygula = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtUrunKampanya = new System.Windows.Forms.TextBox();
            this.txtUrunId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnTedarikAdres = new System.Windows.Forms.Button();
            this.dgvTemizlikUrun = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemizlikUrun)).BeginInit();
            this.SuspendLayout();
            // 
            // btnKampanyaUygula
            // 
            this.btnKampanyaUygula.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKampanyaUygula.Location = new System.Drawing.Point(973, 251);
            this.btnKampanyaUygula.Name = "btnKampanyaUygula";
            this.btnKampanyaUygula.Size = new System.Drawing.Size(137, 53);
            this.btnKampanyaUygula.TabIndex = 0;
            this.btnKampanyaUygula.Text = "UYGULA";
            this.btnKampanyaUygula.UseVisualStyleBackColor = true;
            this.btnKampanyaUygula.Click += new System.EventHandler(this.BtnKampanyaUygula_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(150, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tedarikçi Adresi";
            // 
            // txtUrunKampanya
            // 
            this.txtUrunKampanya.BackColor = System.Drawing.SystemColors.Info;
            this.txtUrunKampanya.Location = new System.Drawing.Point(760, 280);
            this.txtUrunKampanya.Name = "txtUrunKampanya";
            this.txtUrunKampanya.Size = new System.Drawing.Size(143, 22);
            this.txtUrunKampanya.TabIndex = 3;
            // 
            // txtUrunId
            // 
            this.txtUrunId.BackColor = System.Drawing.SystemColors.Info;
            this.txtUrunId.Location = new System.Drawing.Point(760, 249);
            this.txtUrunId.Name = "txtUrunId";
            this.txtUrunId.Size = new System.Drawing.Size(143, 22);
            this.txtUrunId.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(755, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Kampanya Uygula";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(666, 254);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Urun ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(586, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(140, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kampanya Oranı(%):";
            // 
            // btnTedarikAdres
            // 
            this.btnTedarikAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTedarikAdres.Location = new System.Drawing.Point(139, 275);
            this.btnTedarikAdres.Name = "btnTedarikAdres";
            this.btnTedarikAdres.Size = new System.Drawing.Size(203, 37);
            this.btnTedarikAdres.TabIndex = 8;
            this.btnTedarikAdres.Text = "Tedarikçi Adresi Göster";
            this.btnTedarikAdres.UseVisualStyleBackColor = true;
            this.btnTedarikAdres.Click += new System.EventHandler(this.BtnTedarikAdres_Click);
            // 
            // dgvTemizlikUrun
            // 
            this.dgvTemizlikUrun.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTemizlikUrun.Location = new System.Drawing.Point(85, 12);
            this.dgvTemizlikUrun.Name = "dgvTemizlikUrun";
            this.dgvTemizlikUrun.RowHeadersWidth = 51;
            this.dgvTemizlikUrun.RowTemplate.Height = 24;
            this.dgvTemizlikUrun.Size = new System.Drawing.Size(1150, 146);
            this.dgvTemizlikUrun.TabIndex = 9;
            // 
            // TemizlikUrun
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1332, 403);
            this.Controls.Add(this.dgvTemizlikUrun);
            this.Controls.Add(this.btnTedarikAdres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtUrunId);
            this.Controls.Add(this.txtUrunKampanya);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnKampanyaUygula);
            this.Name = "TemizlikUrun";
            this.Text = "TemizlikUrun";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TemizlikUrun_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTemizlikUrun)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnKampanyaUygula;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtUrunKampanya;
        private System.Windows.Forms.TextBox txtUrunId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnTedarikAdres;
        private System.Windows.Forms.DataGridView dgvTemizlikUrun;
    }
}