namespace CafeOtomasyonu
{
    partial class YeniPaketSiparisiForm
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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.panelAltDusuk = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            
            this.lblMusteriAdi = new System.Windows.Forms.Label();
            this.txtMusteriAdi = new System.Windows.Forms.TextBox();
            
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            
            this.lblSiparisNotu = new System.Windows.Forms.Label();
            this.txtSiparisNotu = new System.Windows.Forms.RichTextBox();
            
            this.lblTutar = new System.Windows.Forms.Label();
            this.txtTutar = new System.Windows.Forms.TextBox();

            this.panelAltDusuk.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(23, 114, 190);
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(450, 60);
            this.lblBaslik.Text = "Yeni Paket Siparişi";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelAltDusuk.Controls.Add(this.btnKapat);
            this.panelAltDusuk.Controls.Add(this.btnKaydet);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 520);
            this.panelAltDusuk.Name = "panelAltDusuk";
            this.panelAltDusuk.Size = new System.Drawing.Size(450, 60);

            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.Location = new System.Drawing.Point(340, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 32);
            this.btnKapat.Text = "❌ İptal";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 130, 50);
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(190, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(140, 32);
            this.btnKaydet.Text = "🛒 Siparişi Onayla";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font txtFont = new System.Drawing.Font("Segoe UI", 10F);

            // lblMusteriAdi
            this.lblMusteriAdi.AutoSize = true;
            this.lblMusteriAdi.Font = lblFont;
            this.lblMusteriAdi.Location = new System.Drawing.Point(20, 80);
            this.lblMusteriAdi.Text = "👤 Müşteri Adı :";

            // txtMusteriAdi
            this.txtMusteriAdi.Font = txtFont;
            this.txtMusteriAdi.Location = new System.Drawing.Point(160, 77);
            this.txtMusteriAdi.Size = new System.Drawing.Size(260, 25);

            // lblTelefon
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = lblFont;
            this.lblTelefon.Location = new System.Drawing.Point(20, 130);
            this.lblTelefon.Text = "📞 Telefon :";

            // txtTelefon
            this.txtTelefon.Font = txtFont;
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Location = new System.Drawing.Point(160, 127);
            this.txtTelefon.Size = new System.Drawing.Size(260, 25);

            // lblAdres
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = lblFont;
            this.lblAdres.Location = new System.Drawing.Point(20, 180);
            this.lblAdres.Text = "🏠 Teslimat :";

            // txtAdres
            this.txtAdres.Font = txtFont;
            this.txtAdres.Location = new System.Drawing.Point(160, 177);
            this.txtAdres.Size = new System.Drawing.Size(260, 70);

            // lblSiparisNotu
            this.lblSiparisNotu.AutoSize = true;
            this.lblSiparisNotu.Font = lblFont;
            this.lblSiparisNotu.Location = new System.Drawing.Point(20, 275);
            this.lblSiparisNotu.Text = "🛒 Ürünler/Not :";

            // txtSiparisNotu
            this.txtSiparisNotu.Font = txtFont;
            this.txtSiparisNotu.Location = new System.Drawing.Point(160, 272);
            this.txtSiparisNotu.Size = new System.Drawing.Size(260, 130);

            // lblTutar
            this.lblTutar.AutoSize = true;
            this.lblTutar.Font = lblFont;
            this.lblTutar.Location = new System.Drawing.Point(20, 430);
            this.lblTutar.Text = "💰 Toplam Tutar :";

            // txtTutar
            this.txtTutar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTutar.Location = new System.Drawing.Point(160, 427);
            this.txtTutar.Size = new System.Drawing.Size(150, 29);
            this.txtTutar.ForeColor = System.Drawing.Color.DarkGreen;

            // YeniPaketSiparisiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 580);
            
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.lblTutar);
            this.Controls.Add(this.txtSiparisNotu);
            this.Controls.Add(this.lblSiparisNotu);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtMusteriAdi);
            this.Controls.Add(this.lblMusteriAdi);

            this.Controls.Add(this.panelAltDusuk);
            this.Controls.Add(this.lblBaslik);
            
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "YeniPaketSiparisiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Paket Siparişi";
            this.Load += new System.EventHandler(this.YeniPaketSiparisiForm_Load);
            
            this.panelAltDusuk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.Label lblMusteriAdi;
        private System.Windows.Forms.TextBox txtMusteriAdi;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.RichTextBox txtAdres;
        private System.Windows.Forms.Label lblSiparisNotu;
        private System.Windows.Forms.RichTextBox txtSiparisNotu;
        private System.Windows.Forms.Label lblTutar;
        private System.Windows.Forms.TextBox txtTutar;
    }
}
