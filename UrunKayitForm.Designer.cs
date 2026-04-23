namespace CafeOtomasyonu
{
    partial class UrunKayitForm
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
            this.lblBaslik         = new System.Windows.Forms.Label();
            this.lblMenu           = new System.Windows.Forms.Label();
            this.cmbMenu           = new System.Windows.Forms.ComboBox();
            this.lblUrunKodu       = new System.Windows.Forms.Label();
            this.txtUrunKodu       = new System.Windows.Forms.TextBox();
            this.lblUrunAdi        = new System.Windows.Forms.Label();
            this.txtUrunAdi        = new System.Windows.Forms.TextBox();
            this.lblFiyat1         = new System.Windows.Forms.Label();
            this.numFiyat1         = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat2         = new System.Windows.Forms.Label();
            this.numFiyat2         = new System.Windows.Forms.NumericUpDown();
            this.lblFiyat3         = new System.Windows.Forms.Label();
            this.numFiyat3         = new System.Windows.Forms.NumericUpDown();
            this.lblAciklama       = new System.Windows.Forms.Label();
            this.txtAciklama       = new System.Windows.Forms.TextBox();
            this.lblTarih          = new System.Windows.Forms.Label();
            this.dtTarih           = new System.Windows.Forms.DateTimePicker();
            
            this.pictureBoxResim   = new System.Windows.Forms.PictureBox();
            this.lblResimSecilmedi = new System.Windows.Forms.Label();

            this.panelAlt          = new System.Windows.Forms.Panel();
            this.panelSagButonlar  = new System.Windows.Forms.Panel();
            this.btnKapat          = new System.Windows.Forms.Button();
            this.panelSolButonlar  = new System.Windows.Forms.Panel();
            this.lblIslemler       = new System.Windows.Forms.Label();
            this.btnKaydet         = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.numFiyat1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.pictureBoxResim.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height    = 50;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Ürün Kayıt";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // Labels & Inputs Setups
            int lblX = 10,  inpX = 135, rX = 400; // Left column base X
            int currY = 55, yStep = 28;

            CreateLabel(lblMenu, "Menü :", lblX, currY);
            this.cmbMenu.Location = new System.Drawing.Point(inpX, currY);
            this.cmbMenu.Size = new System.Drawing.Size(250, 23);
            this.cmbMenu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMenu.Items.AddRange(new object[] { "Sıcak İçecekler", "Soğuk İçecekler", "Tatlılar", "Dondurma", "Yiyecekler" });
            this.Controls.Add(this.cmbMenu);
            currY += yStep;

            CreateLabel(lblUrunKodu, "Ürün Kodu :", lblX, currY);
            this.txtUrunKodu.Location = new System.Drawing.Point(inpX, currY);
            this.txtUrunKodu.Size = new System.Drawing.Size(250, 23);
            this.txtUrunKodu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.txtUrunKodu);
            currY += yStep;

            CreateLabel(lblUrunAdi, "Ürün Adı :", lblX, currY);
            this.txtUrunAdi.Location = new System.Drawing.Point(inpX, currY);
            this.txtUrunAdi.Size = new System.Drawing.Size(250, 23);
            this.txtUrunAdi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Controls.Add(this.txtUrunAdi);
            currY += yStep;

            CreateLabel(lblFiyat1, "Birim Fiyatı 1 :", lblX, currY);
            CreateNumDown(numFiyat1, inpX, currY);
            currY += yStep;

            CreateLabel(lblFiyat2, "Birim Fiyatı 2 :", lblX, currY);
            CreateNumDown(numFiyat2, inpX, currY);
            currY += yStep;

            CreateLabel(lblFiyat3, "Birim Fiyatı 3 :", lblX, currY);
            CreateNumDown(numFiyat3, inpX, currY);
            currY += yStep;

            CreateLabel(lblAciklama, "Açıklama :", lblX, currY);
            this.lblAciklama.Location = new System.Drawing.Point(lblX, currY); 
            this.lblAciklama.Size = new System.Drawing.Size(120, 100); // 100px yüksekliğindeki açıklamaya denk gelsin diye
            this.txtAciklama.Location = new System.Drawing.Point(inpX, currY);
            this.txtAciklama.Size = new System.Drawing.Size(250, 100);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Controls.Add(this.txtAciklama);
            currY += 105;

            CreateLabel(lblTarih, "Tarih :", lblX, currY);
            this.dtTarih.Location = new System.Drawing.Point(inpX, currY);
            this.dtTarih.Size = new System.Drawing.Size(250, 23);
            this.dtTarih.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Controls.Add(this.dtTarih);

            // PictureBox
            this.pictureBoxResim.Location = new System.Drawing.Point(rX, 55);
            this.pictureBoxResim.Size = new System.Drawing.Size(160, 160);
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxResim.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxResim.Click += new System.EventHandler(this.pictureBox_Click);

            this.lblResimSecilmedi.Text = "Resim Seçilmedi";
            this.lblResimSecilmedi.AutoSize = false;
            this.lblResimSecilmedi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblResimSecilmedi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblResimSecilmedi.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular);
            this.lblResimSecilmedi.ForeColor = System.Drawing.Color.Gray;
            this.lblResimSecilmedi.Click += new System.EventHandler(this.pictureBox_Click);
            this.pictureBoxResim.Controls.Add(this.lblResimSecilmedi);

            this.Controls.Add(this.pictureBoxResim);

            // panelAlt
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelAlt.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Height    = 50;
            this.panelAlt.Controls.Add(this.panelSagButonlar);
            this.panelAlt.Controls.Add(this.panelSolButonlar);

            // panelSolButonlar
            this.panelSolButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSolButonlar.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Controls.Add(this.lblIslemler);
            this.panelSolButonlar.Controls.Add(this.btnKaydet);

            // lblIslemler
            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 2);
            this.lblIslemler.Text      = "İşlemler";

            // btnKaydet
            this.btnKaydet.BackColor = System.Drawing.Color.White; // Screenshotta açık renk görünüyor gibi
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnKaydet.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKaydet.ForeColor = System.Drawing.Color.Black;
            this.btnKaydet.Location  = new System.Drawing.Point(8, 18);
            this.btnKaydet.Size      = new System.Drawing.Size(90, 26);
            this.btnKaydet.Text      = "💾  Kaydet";
            this.btnKaydet.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Click    += new System.EventHandler(this.btnKaydet_Click);

            // panelSagButonlar
            this.panelSagButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSagButonlar.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Width     = 95;
            this.panelSagButonlar.Controls.Add(this.btnKapat);

            // btnKapat
            this.btnKapat.BackColor  = System.Drawing.Color.FromArgb(220, 53, 69); // Kırmızı renk
            this.btnKapat.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.ForeColor  = System.Drawing.Color.White;
            this.btnKapat.Location   = new System.Drawing.Point(0, 13); // docked sağda
            this.btnKapat.Size       = new System.Drawing.Size(85, 30);
            this.btnKapat.Text       = "❌ Kapat";
            this.btnKapat.Cursor     = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click     += new System.EventHandler(this.btnKapat_Click);

            // Form Ayarları
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(580, 400); // adjusted according to image
            this.Controls.Add(this.panelAlt);
            this.Controls.Add(this.lblBaslik);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.ShowInTaskbar       = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text                = "Ürün Kaydetme";
            this.Name                = "UrunKayitForm";

            ((System.ComponentModel.ISupportInitialize)(this.numFiyat1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFiyat3)).EndInit();
            this.pictureBoxResim.ResumeLayout(false);
            this.panelAlt.ResumeLayout(false);
            this.panelSagButonlar.ResumeLayout(false);
            this.panelSolButonlar.ResumeLayout(false);
            this.panelSolButonlar.PerformLayout();
            this.ResumeLayout(false);
        }

        private void CreateLabel(System.Windows.Forms.Label lbl, string text, int x, int y)
        {
            lbl.AutoSize  = false;
            lbl.Location  = new System.Drawing.Point(x, y);
            lbl.Size      = new System.Drawing.Size(120, 23);
            lbl.Text      = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            
            // Başlıkları kutucuk içine al (Ekran görüntüsündeki gibi gri zemin + kenarlık)
            lbl.BackColor = System.Drawing.Color.FromArgb(245, 245, 245);
            lbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            
            this.Controls.Add(lbl);
        }

        private void CreateNumDown(System.Windows.Forms.NumericUpDown num, int x, int y)
        {
            num.Location = new System.Drawing.Point(x, y);
            num.Size = new System.Drawing.Size(250, 23);
            num.Font = new System.Drawing.Font("Segoe UI", 9F);
            num.DecimalPlaces = 2;
            num.Maximum = 100000;
            this.Controls.Add(num);
        }

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Label          lblMenu;
        private System.Windows.Forms.ComboBox       cmbMenu;
        private System.Windows.Forms.Label          lblUrunKodu;
        private System.Windows.Forms.TextBox        txtUrunKodu;
        private System.Windows.Forms.Label          lblUrunAdi;
        private System.Windows.Forms.TextBox        txtUrunAdi;
        private System.Windows.Forms.Label          lblFiyat1;
        private System.Windows.Forms.NumericUpDown  numFiyat1;
        private System.Windows.Forms.Label          lblFiyat2;
        private System.Windows.Forms.NumericUpDown  numFiyat2;
        private System.Windows.Forms.Label          lblFiyat3;
        private System.Windows.Forms.NumericUpDown  numFiyat3;
        private System.Windows.Forms.Label          lblAciklama;
        private System.Windows.Forms.TextBox        txtAciklama;
        private System.Windows.Forms.Label          lblTarih;
        private System.Windows.Forms.DateTimePicker dtTarih;
        
        private System.Windows.Forms.PictureBox     pictureBoxResim;
        private System.Windows.Forms.Label          lblResimSecilmedi;

        private System.Windows.Forms.Panel          panelAlt;
        private System.Windows.Forms.Panel          panelSolButonlar;
        private System.Windows.Forms.Panel          panelSagButonlar;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnKaydet;
        private System.Windows.Forms.Button         btnKapat;
    }
}
