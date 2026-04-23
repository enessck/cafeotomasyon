namespace CafeOtomasyonu
{
    partial class SatisDetayiForm
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
            this.btnKapat = new System.Windows.Forms.Button();
            
            // Bilgi Alanları
            this.lblSatisKoduB = new System.Windows.Forms.Label();
            this.lblSatisKodu = new System.Windows.Forms.Label();
            
            this.lblOdemeTuruB = new System.Windows.Forms.Label();
            this.lblOdemeTuru = new System.Windows.Forms.Label();
            
            this.lblMiktarB = new System.Windows.Forms.Label();
            this.lblMiktar = new System.Windows.Forms.Label();
            
            this.lblTarihB = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            
            this.lblKullaniciB = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            
            this.lblAciklamaB = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.RichTextBox();

            // Tablo
            this.lblUrunler = new System.Windows.Forms.Label();
            this.dataGridViewUrunler = new System.Windows.Forms.DataGridView();

            this.panelAltDusuk.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).BeginInit();
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
            this.lblBaslik.Size = new System.Drawing.Size(650, 60);
            this.lblBaslik.Text = "Satış Detayları";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelAltDusuk.Controls.Add(this.btnKapat);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 600);
            this.panelAltDusuk.Name = "panelAltDusuk";
            this.panelAltDusuk.Size = new System.Drawing.Size(650, 60);

            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.Location = new System.Drawing.Point(530, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(100, 32);
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            System.Drawing.Font lblBFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font lblNFont = new System.Drawing.Font("Segoe UI", 10F);

            // Bilgiler
            this.lblSatisKoduB.AutoSize = true; this.lblSatisKoduB.Font = lblBFont; this.lblSatisKoduB.Location = new System.Drawing.Point(20, 80); this.lblSatisKoduB.Text = "Satış Kodu:";
            this.lblSatisKodu.AutoSize = true; this.lblSatisKodu.Font = lblNFont; this.lblSatisKodu.Location = new System.Drawing.Point(120, 80); this.lblSatisKodu.Text = "-";

            this.lblTarihB.AutoSize = true; this.lblTarihB.Font = lblBFont; this.lblTarihB.Location = new System.Drawing.Point(20, 110); this.lblTarihB.Text = "Tarih:";
            this.lblTarih.AutoSize = true; this.lblTarih.Font = lblNFont; this.lblTarih.Location = new System.Drawing.Point(120, 110); this.lblTarih.Text = "-";

            this.lblOdemeTuruB.AutoSize = true; this.lblOdemeTuruB.Font = lblBFont; this.lblOdemeTuruB.Location = new System.Drawing.Point(360, 80); this.lblOdemeTuruB.Text = "Ödeme Türü:";
            this.lblOdemeTuru.AutoSize = true; this.lblOdemeTuru.Font = lblNFont; this.lblOdemeTuru.Location = new System.Drawing.Point(470, 80); this.lblOdemeTuru.Text = "-";

            this.lblMiktarB.AutoSize = true; this.lblMiktarB.Font = lblBFont; this.lblMiktarB.Location = new System.Drawing.Point(360, 110); this.lblMiktarB.Text = "Ödenen Miktar:";
            this.lblMiktar.AutoSize = true; this.lblMiktar.Font = lblBFont; this.lblMiktar.ForeColor = System.Drawing.Color.DarkGreen; this.lblMiktar.Location = new System.Drawing.Point(485, 110); this.lblMiktar.Text = "0,00 ₺";

            this.lblKullaniciB.AutoSize = true; this.lblKullaniciB.Font = lblBFont; this.lblKullaniciB.Location = new System.Drawing.Point(20, 140); this.lblKullaniciB.Text = "Personel:";
            this.lblKullanici.AutoSize = true; this.lblKullanici.Font = lblNFont; this.lblKullanici.Location = new System.Drawing.Point(120, 140); this.lblKullanici.Text = "-";

            this.lblAciklamaB.AutoSize = true; this.lblAciklamaB.Font = lblBFont; this.lblAciklamaB.Location = new System.Drawing.Point(20, 175); this.lblAciklamaB.Text = "Açıklama:";
            
            this.txtAciklama.Font = lblNFont;
            this.txtAciklama.Location = new System.Drawing.Point(120, 172);
            this.txtAciklama.Size = new System.Drawing.Size(510, 50);
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.BackColor = System.Drawing.Color.WhiteSmoke;

            // Tablo Başlığı
            this.lblUrunler.AutoSize = true; 
            this.lblUrunler.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold); 
            this.lblUrunler.Location = new System.Drawing.Point(20, 240); 
            this.lblUrunler.Text = "🛒 Satın Alınan Ürünler";
            this.lblUrunler.ForeColor = System.Drawing.Color.FromArgb(23, 114, 190);

            // dataGridViewUrunler
            this.dataGridViewUrunler.AllowUserToAddRows = false;
            this.dataGridViewUrunler.AllowUserToDeleteRows = false;
            this.dataGridViewUrunler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUrunler.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewUrunler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUrunler.Location = new System.Drawing.Point(20, 270);
            this.dataGridViewUrunler.Name = "dataGridViewUrunler";
            this.dataGridViewUrunler.ReadOnly = true;
            this.dataGridViewUrunler.RowHeadersVisible = false;
            this.dataGridViewUrunler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUrunler.Size = new System.Drawing.Size(610, 310);
            
            // SatisDetayiForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(650, 660);
            
            this.Controls.Add(this.dataGridViewUrunler);
            this.Controls.Add(this.lblUrunler);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklamaB);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblKullaniciB);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblTarihB);
            this.Controls.Add(this.lblMiktar);
            this.Controls.Add(this.lblMiktarB);
            this.Controls.Add(this.lblOdemeTuru);
            this.Controls.Add(this.lblOdemeTuruB);
            this.Controls.Add(this.lblSatisKodu);
            this.Controls.Add(this.lblSatisKoduB);
            
            this.Controls.Add(this.panelAltDusuk);
            this.Controls.Add(this.lblBaslik);
            
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SatisDetayiForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Satış Detayları";
            this.Load += new System.EventHandler(this.SatisDetayiForm_Load);
            
            this.panelAltDusuk.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUrunler)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.Label lblSatisKoduB;
        private System.Windows.Forms.Label lblSatisKodu;
        private System.Windows.Forms.Label lblOdemeTuruB;
        private System.Windows.Forms.Label lblOdemeTuru;
        private System.Windows.Forms.Label lblMiktarB;
        private System.Windows.Forms.Label lblMiktar;
        private System.Windows.Forms.Label lblTarihB;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblKullaniciB;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.Label lblAciklamaB;
        private System.Windows.Forms.RichTextBox txtAciklama;
        
        private System.Windows.Forms.Label lblUrunler;
        private System.Windows.Forms.DataGridView dataGridViewUrunler;
    }
}
