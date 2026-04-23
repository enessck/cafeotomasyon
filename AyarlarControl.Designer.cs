namespace CafeOtomasyonu
{
    partial class AyarlarControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelOrta = new System.Windows.Forms.Panel();
            this.groupBoxAyarlar = new System.Windows.Forms.GroupBox();
            this.lblKafeninAdi = new System.Windows.Forms.Label();
            this.txtKafeninAdi = new System.Windows.Forms.TextBox();
            this.lblYazici = new System.Windows.Forms.Label();
            this.cmbYazici = new System.Windows.Forms.ComboBox();
            this.lblTarihSaatBaslik = new System.Windows.Forms.Label();
            this.lblTarihSaat = new System.Windows.Forms.Label();
            this.panelAlt = new System.Windows.Forms.Panel();
            this.btnKapat = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.timerTarihSaat = new System.Windows.Forms.Timer(this.components);
            this.panelOrta.SuspendLayout();
            this.groupBoxAyarlar.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Padding = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.lblBaslik.Size = new System.Drawing.Size(900, 50);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "⚙️ Ayarlar";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panelOrta
            // 
            this.panelOrta.AutoScroll = true;
            this.panelOrta.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelOrta.Controls.Add(this.groupBoxAyarlar);
            this.panelOrta.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelOrta.Location = new System.Drawing.Point(0, 50);
            this.panelOrta.Name = "panelOrta";
            this.panelOrta.Size = new System.Drawing.Size(900, 500);
            this.panelOrta.TabIndex = 1;
            // 
            // groupBoxAyarlar
            // 
            this.groupBoxAyarlar.Controls.Add(this.lblKafeninAdi);
            this.groupBoxAyarlar.Controls.Add(this.txtKafeninAdi);
            this.groupBoxAyarlar.Controls.Add(this.lblYazici);
            this.groupBoxAyarlar.Controls.Add(this.cmbYazici);
            this.groupBoxAyarlar.Controls.Add(this.lblTarihSaatBaslik);
            this.groupBoxAyarlar.Controls.Add(this.lblTarihSaat);
            this.groupBoxAyarlar.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Bold);
            this.groupBoxAyarlar.Location = new System.Drawing.Point(30, 30);
            this.groupBoxAyarlar.Name = "groupBoxAyarlar";
            this.groupBoxAyarlar.Size = new System.Drawing.Size(400, 200);
            this.groupBoxAyarlar.TabIndex = 0;
            this.groupBoxAyarlar.TabStop = false;
            this.groupBoxAyarlar.Text = "Genel Ayarlar";
            // 
            // lblKafeninAdi
            // 
            this.lblKafeninAdi.AutoSize = true;
            this.lblKafeninAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblKafeninAdi.Location = new System.Drawing.Point(20, 45);
            this.lblKafeninAdi.Name = "lblKafeninAdi";
            this.lblKafeninAdi.Size = new System.Drawing.Size(78, 19);
            this.lblKafeninAdi.TabIndex = 0;
            this.lblKafeninAdi.Text = "İşletme Adı:";
            // 
            // txtKafeninAdi
            // 
            this.txtKafeninAdi.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtKafeninAdi.Location = new System.Drawing.Point(120, 42);
            this.txtKafeninAdi.Name = "txtKafeninAdi";
            this.txtKafeninAdi.Size = new System.Drawing.Size(250, 25);
            this.txtKafeninAdi.TabIndex = 1;
            this.txtKafeninAdi.Text = "Örnek Kafe İşletmesi";
            // 
            // lblYazici
            // 
            this.lblYazici.AutoSize = true;
            this.lblYazici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblYazici.Location = new System.Drawing.Point(20, 95);
            this.lblYazici.Name = "lblYazici";
            this.lblYazici.Size = new System.Drawing.Size(95, 19);
            this.lblYazici.TabIndex = 2;
            this.lblYazici.Text = "Adres Yazıcısı:";
            // 
            // cmbYazici
            // 
            this.cmbYazici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYazici.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbYazici.FormattingEnabled = true;
            this.cmbYazici.Items.AddRange(new object[] {
            "Varsayılan Yazıcı",
            "Mutfak Fiş Yazıcısı",
            "Kasa Yazıcısı"});
            this.cmbYazici.Location = new System.Drawing.Point(120, 92);
            this.cmbYazici.Name = "cmbYazici";
            this.cmbYazici.Size = new System.Drawing.Size(250, 25);
            this.cmbYazici.TabIndex = 3;
            // 
            // lblTarihSaatBaslik
            // 
            this.lblTarihSaatBaslik.AutoSize = true;
            this.lblTarihSaatBaslik.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblTarihSaatBaslik.Location = new System.Drawing.Point(20, 145);
            this.lblTarihSaatBaslik.Name = "lblTarihSaatBaslik";
            this.lblTarihSaatBaslik.Size = new System.Drawing.Size(73, 19);
            this.lblTarihSaatBaslik.TabIndex = 4;
            this.lblTarihSaatBaslik.Text = "Saat/Tarih:";
            // 
            // lblTarihSaat
            // 
            this.lblTarihSaat.AutoSize = true;
            this.lblTarihSaat.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.lblTarihSaat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.lblTarihSaat.Location = new System.Drawing.Point(120, 145);
            this.lblTarihSaat.Name = "lblTarihSaat";
            this.lblTarihSaat.Size = new System.Drawing.Size(141, 19);
            this.lblTarihSaat.TabIndex = 5;
            this.lblTarihSaat.Text = "01.01.2000 00:00:00";
            // 
            // panelAlt
            // 
            this.panelAlt.BackColor = System.Drawing.Color.White;
            this.panelAlt.Controls.Add(this.btnKapat);
            this.panelAlt.Controls.Add(this.btnKaydet);
            this.panelAlt.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Location = new System.Drawing.Point(0, 550);
            this.panelAlt.Name = "panelAlt";
            this.panelAlt.Size = new System.Drawing.Size(900, 60);
            this.panelAlt.TabIndex = 2;
            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.Black;
            this.btnKapat.Location = new System.Drawing.Point(780, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 32);
            this.btnKapat.TabIndex = 0;
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(130)))), ((int)(((byte)(50)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(630, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 32);
            this.btnKaydet.TabIndex = 1;
            this.btnKaydet.Text = "💾 Ayarları Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // AyarlarControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelOrta);
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.lblBaslik);
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Name = "AyarlarControl";
            this.Size = new System.Drawing.Size(900, 610);
            this.Load += new System.EventHandler(this.AyarlarControl_Load);
            this.panelOrta.ResumeLayout(false);
            this.groupBoxAyarlar.ResumeLayout(false);
            this.groupBoxAyarlar.PerformLayout();
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelOrta;
        private System.Windows.Forms.Panel panelAlt;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.GroupBox groupBoxAyarlar;
        private System.Windows.Forms.Label lblKafeninAdi;
        private System.Windows.Forms.TextBox txtKafeninAdi;
        private System.Windows.Forms.Label lblYazici;
        private System.Windows.Forms.ComboBox cmbYazici;
        private System.Windows.Forms.Label lblTarihSaatBaslik;
        private System.Windows.Forms.Label lblTarihSaat;
        private System.Windows.Forms.Timer timerTarihSaat;
    }
}
