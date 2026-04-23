namespace CafeOtomasyonu
{
    partial class OdemeForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.lblOdemeBaslik   = new System.Windows.Forms.Label();
            this.panelTutar        = new System.Windows.Forms.Panel();
            this.lblTutarEtiket    = new System.Windows.Forms.Label();
            this.txtTutar          = new System.Windows.Forms.TextBox();
            this.lblKalan          = new System.Windows.Forms.Label();
            this.panelAciklama     = new System.Windows.Forms.Panel();
            this.lblAciklama       = new System.Windows.Forms.Label();
            this.txtAciklama       = new System.Windows.Forms.TextBox();
            this.panelTarih        = new System.Windows.Forms.Panel();
            this.lblTarihEtiket    = new System.Windows.Forms.Label();
            this.dtpTarih          = new System.Windows.Forms.DateTimePicker();
            this.panelIslemler     = new System.Windows.Forms.Panel();
            this.lblIslemler       = new System.Windows.Forms.Label();
            this.panelIslemlerSag  = new System.Windows.Forms.Panel();
            this.btnOnay           = new System.Windows.Forms.Button();
            this.btnKapat          = new System.Windows.Forms.Button();

            this.panelTutar.SuspendLayout();
            this.panelAciklama.SuspendLayout();
            this.panelTarih.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
            this.SuspendLayout();

            // =====================================================================
            // lblOdemeBaslik
            // =====================================================================
            this.lblOdemeBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblOdemeBaslik.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblOdemeBaslik.Height    = 52;
            this.lblOdemeBaslik.Name      = "lblOdemeBaslik";
            this.lblOdemeBaslik.Text      = "Nakit Ödeme";
            this.lblOdemeBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblOdemeBaslik.BackColor = System.Drawing.Color.White;

            // =====================================================================
            // panelTutar — Ödenecek Tutar satırı + canlı kalan göstergesi
            // =====================================================================
            this.panelTutar.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTutar.Height    = 60;
            this.panelTutar.Name      = "panelTutar";
            this.panelTutar.BackColor = System.Drawing.Color.White;
            this.panelTutar.Padding   = new System.Windows.Forms.Padding(6, 4, 6, 4);

            this.lblTutarEtiket.AutoSize  = true;
            this.lblTutarEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTutarEtiket.Location  = new System.Drawing.Point(10, 10);
            this.lblTutarEtiket.Name      = "lblTutarEtiket";
            this.lblTutarEtiket.Text      = "Ödenecek Tutar :";

            this.txtTutar.BackColor   = System.Drawing.Color.FromArgb(40, 167, 69);
            this.txtTutar.ForeColor   = System.Drawing.Color.White;
            this.txtTutar.Font        = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.txtTutar.Location    = new System.Drawing.Point(125, 6);
            this.txtTutar.Name        = "txtTutar";
            this.txtTutar.Size        = new System.Drawing.Size(200, 26);
            this.txtTutar.Text        = "0,00";
            this.txtTutar.TextAlign   = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // lblKalan — gerçek zamanlı kalan göstergesi
            this.lblKalan.AutoSize  = false;
            this.lblKalan.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKalan.Location  = new System.Drawing.Point(10, 37);
            this.lblKalan.Size      = new System.Drawing.Size(370, 18);
            this.lblKalan.Name      = "lblKalan";
            this.lblKalan.Text      = "Kalan: ₺0,00";
            this.lblKalan.ForeColor = System.Drawing.Color.Green;
            this.lblKalan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            this.panelTutar.Controls.Add(this.txtTutar);
            this.panelTutar.Controls.Add(this.lblTutarEtiket);
            this.panelTutar.Controls.Add(this.lblKalan);

            // =====================================================================
            // panelAciklama — Açıklama alanı
            // =====================================================================
            this.panelAciklama.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelAciklama.Height    = 80;
            this.panelAciklama.Name      = "panelAciklama";
            this.panelAciklama.BackColor = System.Drawing.Color.White;
            this.panelAciklama.Padding   = new System.Windows.Forms.Padding(6, 4, 6, 4);

            this.lblAciklama.AutoSize  = true;
            this.lblAciklama.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAciklama.Location  = new System.Drawing.Point(10, 10);
            this.lblAciklama.Name      = "lblAciklama";
            this.lblAciklama.Text      = "Açıklama :";

            this.txtAciklama.Anchor     = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtAciklama.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location   = new System.Drawing.Point(80, 6);
            this.txtAciklama.Multiline  = true;
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Name       = "txtAciklama";
            this.txtAciklama.Size       = new System.Drawing.Size(270, 68);

            this.panelAciklama.Controls.Add(this.txtAciklama);
            this.panelAciklama.Controls.Add(this.lblAciklama);

            // =====================================================================
            // panelTarih — Tarih seçimi
            // =====================================================================
            this.panelTarih.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelTarih.Height    = 34;
            this.panelTarih.Name      = "panelTarih";
            this.panelTarih.BackColor = System.Drawing.Color.White;
            this.panelTarih.Padding   = new System.Windows.Forms.Padding(6, 4, 6, 4);

            this.lblTarihEtiket.AutoSize  = true;
            this.lblTarihEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarihEtiket.Location  = new System.Drawing.Point(10, 9);
            this.lblTarihEtiket.Name      = "lblTarihEtiket";
            this.lblTarihEtiket.Text      = "Tarih :";

            this.dtpTarih.Location = new System.Drawing.Point(80, 6);
            this.dtpTarih.Name     = "dtpTarih";
            this.dtpTarih.Size     = new System.Drawing.Size(200, 21);
            this.dtpTarih.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.panelTarih.Controls.Add(this.dtpTarih);
            this.panelTarih.Controls.Add(this.lblTarihEtiket);

            // =====================================================================
            // panelIslemler — alt bar
            // =====================================================================
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelIslemler.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Height    = 50;
            this.panelIslemler.Name      = "panelIslemler";

            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 16);
            this.lblIslemler.Name      = "lblIslemler";
            this.lblIslemler.Text      = "İşlemler";

            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Width     = 210;
            this.panelIslemlerSag.Name      = "panelIslemlerSag";

            // btnOnay (yeşil tik + "Onay")
            this.btnOnay.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnOnay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOnay.FlatAppearance.BorderSize = 0;
            this.btnOnay.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnOnay.ForeColor = System.Drawing.Color.White;
            this.btnOnay.Location  = new System.Drawing.Point(5, 11);
            this.btnOnay.Name      = "btnOnay";
            this.btnOnay.Size      = new System.Drawing.Size(90, 28);
            this.btnOnay.Text      = "✔  Onay";
            this.btnOnay.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnOnay.Click    += new System.EventHandler(this.btnOnay_Click);

            // btnKapat (kırmızı X + "Kapat")
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.Location  = new System.Drawing.Point(103, 11);
            this.btnKapat.Name      = "btnKapat";
            this.btnKapat.Size      = new System.Drawing.Size(90, 28);
            this.btnKapat.Text      = "✖  Kapat";
            this.btnKapat.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click    += new System.EventHandler(this.btnKapat_Click);

            this.panelIslemlerSag.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnOnay, this.btnKapat
            });

            this.panelIslemler.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblIslemler, this.panelIslemlerSag
            });

            // =====================================================================
            // Form
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(400, 280);
            this.FormBorderStyle     = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox         = false;
            this.MinimizeBox         = false;
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name                = "OdemeForm";
            this.Text                = "Ödeme";

            // Fill alanı boş bırakıyoruz (panellar Top/Bottom kullanıyor)
            this.Controls.Add(this.panelIslemler);   // Bottom
            this.Controls.Add(this.panelTarih);       // Top (son eklenen = alt sıraya gider)
            this.Controls.Add(this.panelAciklama);    // Top
            this.Controls.Add(this.panelTutar);       // Top
            this.Controls.Add(this.lblOdemeBaslik);   // Top (ilk = en üst)

            this.panelTutar.ResumeLayout(false);
            this.panelTutar.PerformLayout();
            this.panelAciklama.ResumeLayout(false);
            this.panelAciklama.PerformLayout();
            this.panelTarih.ResumeLayout(false);
            this.panelTarih.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label     lblOdemeBaslik;
        private System.Windows.Forms.Panel     panelTutar;
        private System.Windows.Forms.Label     lblTutarEtiket;
        private System.Windows.Forms.TextBox   txtTutar;
        private System.Windows.Forms.Label     lblKalan;
        private System.Windows.Forms.Panel     panelAciklama;
        private System.Windows.Forms.Label     lblAciklama;
        private System.Windows.Forms.TextBox   txtAciklama;
        private System.Windows.Forms.Panel     panelTarih;
        private System.Windows.Forms.Label     lblTarihEtiket;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel     panelIslemler;
        private System.Windows.Forms.Label     lblIslemler;
        private System.Windows.Forms.Panel     panelIslemlerSag;
        private System.Windows.Forms.Button    btnOnay;
        private System.Windows.Forms.Button    btnKapat;
    }
}
