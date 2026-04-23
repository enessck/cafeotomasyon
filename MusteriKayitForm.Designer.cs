namespace CafeOtomasyonu
{
    partial class MusteriKayitForm
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
            
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            
            this.lblTelefon = new System.Windows.Forms.Label();
            this.txtTelefon = new System.Windows.Forms.MaskedTextBox();
            
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            
            this.lblAdres = new System.Windows.Forms.Label();
            this.txtAdres = new System.Windows.Forms.RichTextBox();
            
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();

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
            this.lblBaslik.Text = "Müşteri Bilgileri";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelAltDusuk.Controls.Add(this.btnKapat);
            this.panelAltDusuk.Controls.Add(this.btnKaydet);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 500);
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
            this.btnKaydet.Location = new System.Drawing.Point(210, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 32);
            this.btnKaydet.Text = "💾 Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            System.Drawing.Font lblFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font txtFont = new System.Drawing.Font("Segoe UI", 10F);

            // lblAdSoyad
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Font = lblFont;
            this.lblAdSoyad.Location = new System.Drawing.Point(20, 80);
            this.lblAdSoyad.Text = "👤 Adı Soyadı :";

            // txtAdSoyad
            this.txtAdSoyad.Font = txtFont;
            this.txtAdSoyad.Location = new System.Drawing.Point(140, 77);
            this.txtAdSoyad.Size = new System.Drawing.Size(280, 25);

            // lblTelefon
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Font = lblFont;
            this.lblTelefon.Location = new System.Drawing.Point(20, 130);
            this.lblTelefon.Text = "📞 Telefon :";

            // txtTelefon
            this.txtTelefon.Font = txtFont;
            this.txtTelefon.Mask = "(999) 000-0000";
            this.txtTelefon.Location = new System.Drawing.Point(140, 127);
            this.txtTelefon.Size = new System.Drawing.Size(280, 25);

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = lblFont;
            this.lblEmail.Location = new System.Drawing.Point(20, 180);
            this.lblEmail.Text = "✉️ E-Posta :";

            // txtEmail
            this.txtEmail.Font = txtFont;
            this.txtEmail.Location = new System.Drawing.Point(140, 177);
            this.txtEmail.Size = new System.Drawing.Size(280, 25);

            // lblAdres
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = lblFont;
            this.lblAdres.Location = new System.Drawing.Point(20, 230);
            this.lblAdres.Text = "🏠 Adres :";

            // txtAdres
            this.txtAdres.Font = txtFont;
            this.txtAdres.Location = new System.Drawing.Point(140, 227);
            this.txtAdres.Size = new System.Drawing.Size(280, 80);

            // lblAciklama
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = lblFont;
            this.lblAciklama.Location = new System.Drawing.Point(20, 330);
            this.lblAciklama.Text = "📝 Açıklama :";

            // txtAciklama
            this.txtAciklama.Font = txtFont;
            this.txtAciklama.Location = new System.Drawing.Point(140, 327);
            this.txtAciklama.Size = new System.Drawing.Size(280, 80);

            // MusteriKayitForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(450, 560);
            
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.lblAdSoyad);

            this.Controls.Add(this.panelAltDusuk);
            this.Controls.Add(this.lblBaslik);
            
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MusteriKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Müşteri Bilgileri";
            this.Load += new System.EventHandler(this.MusteriKayitForm_Load);
            
            this.panelAltDusuk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.TextBox txtAdSoyad;
        
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.MaskedTextBox txtTelefon;
        
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtEmail;
        
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.RichTextBox txtAdres;
        
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.RichTextBox txtAciklama;
    }
}
