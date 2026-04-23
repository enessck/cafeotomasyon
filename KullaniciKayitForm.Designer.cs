namespace CafeOtomasyonu
{
    partial class KullaniciKayitForm
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik = new System.Windows.Forms.Label();
            this.tableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            
            // Labels
            this.lblDurumu = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblGorevi = new System.Windows.Forms.Label();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblParola = new System.Windows.Forms.Label();
            this.lblParolaTekrar = new System.Windows.Forms.Label();
            this.lblSoru = new System.Windows.Forms.Label();
            this.lblCevap = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();

            // Inputs
            this.toggleDurum = new DevExpress.XtraEditors.ToggleSwitch();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtGorevi = new System.Windows.Forms.TextBox();
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtParola = new System.Windows.Forms.TextBox();
            this.txtParolaTekrar = new System.Windows.Forms.TextBox();
            this.txtSoru = new System.Windows.Forms.TextBox();
            this.txtCevap = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();

            // Bottom Panel
            this.panelIslemler = new System.Windows.Forms.Panel();
            this.lblIslemler = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();

            this.tableLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDurum.Properties)).BeginInit();
            this.panelIslemler.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(114)))), ((int)(((byte)(190)))));
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(434, 45);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "👨‍💼 Yeni Kullanıcı / Admin Kayıt";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // tableLayoutPanel
            // 
            this.tableLayoutPanel.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel.ColumnCount = 2;
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            
            // Add Controls to Table
            this.tableLayoutPanel.Controls.Add(this.lblDurumu, 0, 0);
            this.tableLayoutPanel.Controls.Add(this.toggleDurum, 1, 0);
            
            this.tableLayoutPanel.Controls.Add(this.lblAdSoyad, 0, 1);
            this.tableLayoutPanel.Controls.Add(this.txtAdSoyad, 1, 1);
            
            this.tableLayoutPanel.Controls.Add(this.lblTelefon, 0, 2);
            this.tableLayoutPanel.Controls.Add(this.txtTelefon, 1, 2);
            
            this.tableLayoutPanel.Controls.Add(this.lblAdres, 0, 3);
            this.tableLayoutPanel.Controls.Add(this.txtAdres, 1, 3);
            
            this.tableLayoutPanel.Controls.Add(this.lblEmail, 0, 4);
            this.tableLayoutPanel.Controls.Add(this.txtEmail, 1, 4);
            
            this.tableLayoutPanel.Controls.Add(this.lblGorevi, 0, 5);
            this.tableLayoutPanel.Controls.Add(this.txtGorevi, 1, 5);
            
            this.tableLayoutPanel.Controls.Add(this.lblKullaniciAdi, 0, 6);
            this.tableLayoutPanel.Controls.Add(this.txtKullaniciAdi, 1, 6);
            
            this.tableLayoutPanel.Controls.Add(this.lblParola, 0, 7);
            this.tableLayoutPanel.Controls.Add(this.txtParola, 1, 7);
            
            this.tableLayoutPanel.Controls.Add(this.lblParolaTekrar, 0, 8);
            this.tableLayoutPanel.Controls.Add(this.txtParolaTekrar, 1, 8);
            
            this.tableLayoutPanel.Controls.Add(this.lblSoru, 0, 9);
            this.tableLayoutPanel.Controls.Add(this.txtSoru, 1, 9);
            
            this.tableLayoutPanel.Controls.Add(this.lblCevap, 0, 10);
            this.tableLayoutPanel.Controls.Add(this.txtCevap, 1, 10);
            
            this.tableLayoutPanel.Controls.Add(this.lblAciklama, 0, 11);
            this.tableLayoutPanel.Controls.Add(this.txtAciklama, 1, 11);

            this.tableLayoutPanel.Location = new System.Drawing.Point(12, 48);
            this.tableLayoutPanel.Name = "tableLayoutPanel";
            this.tableLayoutPanel.RowCount = 12;
            
            // Row Heights
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F)); // Adres
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F)); // Aciklama
            
            this.tableLayoutPanel.Size = new System.Drawing.Size(410, 442);
            this.tableLayoutPanel.TabIndex = 1;

            // Labels Init
            KurLabel(this.lblDurumu, "Durumu :");
            KurLabel(this.lblAdSoyad, "Ad Soyad :");
            KurLabel(this.lblTelefon, "Telefon :");
            KurLabel(this.lblAdres, "Adres :");
            KurLabel(this.lblEmail, "Email :");
            KurLabel(this.lblGorevi, "Görevi :");
            KurLabel(this.lblKullaniciAdi, "Kullanıcı Adı :");
            KurLabel(this.lblParola, "Parola :");
            KurLabel(this.lblParolaTekrar, "Parola Tekrar :");
            KurLabel(this.lblSoru, "Soru :");
            KurLabel(this.lblCevap, "Cevap :");
            KurLabel(this.lblAciklama, "Açıklama :");

            // TextBoxes Init
            KurTextBox(this.txtAdSoyad);
            KurTextBox(this.txtTelefon);
            KurTextBox(this.txtEmail);
            KurTextBox(this.txtGorevi);
            KurTextBox(this.txtKullaniciAdi);
            KurTextBox(this.txtParola);
            KurTextBox(this.txtParolaTekrar);
            KurTextBox(this.txtSoru);
            KurTextBox(this.txtCevap);
            
            // Password Chars
            this.txtParola.PasswordChar = '●';
            this.txtParolaTekrar.PasswordChar = '●';

            // Multiline TextBoxes
            KurTextBox(this.txtAdres);
            this.txtAdres.Multiline = true;
            this.txtAdres.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            KurTextBox(this.txtAciklama);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;

            // Toggle Switch
            this.toggleDurum.Location = new System.Drawing.Point(125, 4);
            this.toggleDurum.Name = "toggleDurum";
            this.toggleDurum.Properties.OffText = "Aktif Değil";
            this.toggleDurum.Properties.OnText = "Aktif";
            this.toggleDurum.Size = new System.Drawing.Size(120, 24);
            this.toggleDurum.TabIndex = 0;

            // =====================================================================
            // panelIslemler
            // =====================================================================
            this.panelIslemler.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panelIslemler.Controls.Add(this.btnKapat);
            this.panelIslemler.Controls.Add(this.btnKaydet);
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Location = new System.Drawing.Point(0, 501);
            this.panelIslemler.Name = "panelIslemler";
            this.panelIslemler.Size = new System.Drawing.Size(434, 52);
            this.panelIslemler.TabIndex = 2;

            // Kaydet
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(167)))), ((int)(((byte)(69)))));
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.FlatAppearance.BorderSize = 0;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(220, 10);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(90, 30);
            this.btnKaydet.Text = "💾 Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // Kapat
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(53)))), ((int)(((byte)(69)))));
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location = new System.Drawing.Point(320, 10);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 30);
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // 
            // KullaniciKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(434, 553);
            this.Controls.Add(this.tableLayoutPanel);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "KullaniciKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Kullanıcı Kayıt Sayfası";

            this.tableLayoutPanel.ResumeLayout(false);
            this.tableLayoutPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleDurum.Properties)).EndInit();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.ResumeLayout(false);

        }

        private void KurLabel(System.Windows.Forms.Label lbl, string text)
        {
            lbl.Text = text;
            lbl.Dock = System.Windows.Forms.DockStyle.Fill;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            lbl.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            lbl.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        }

        private void KurTextBox(System.Windows.Forms.TextBox txt)
        {
            txt.Dock = System.Windows.Forms.DockStyle.Fill;
            txt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            txt.Font = new System.Drawing.Font("Segoe UI", 9F);
            txt.Margin = new System.Windows.Forms.Padding(1, 4, 1, 4);
        }

        #endregion

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel;
        
        private System.Windows.Forms.Label lblDurumu;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblGorevi;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblParola;
        private System.Windows.Forms.Label lblParolaTekrar;
        private System.Windows.Forms.Label lblSoru;
        private System.Windows.Forms.Label lblCevap;
        private System.Windows.Forms.Label lblAciklama;

        private DevExpress.XtraEditors.ToggleSwitch toggleDurum;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtGorevi;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtParola;
        private System.Windows.Forms.TextBox txtParolaTekrar;
        private System.Windows.Forms.TextBox txtSoru;
        private System.Windows.Forms.TextBox txtCevap;
        private System.Windows.Forms.TextBox txtAciklama;

        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
    }
}
