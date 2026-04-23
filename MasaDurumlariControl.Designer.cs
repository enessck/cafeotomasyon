namespace CafeOtomasyonu
{
    partial class MasaDurumlariControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik          = new System.Windows.Forms.Label();
            this.panelMasalar       = new System.Windows.Forms.Panel();
            this.panelAlt           = new System.Windows.Forms.Panel();
            this.panelSolButonlar   = new System.Windows.Forms.Panel();
            this.panelSagButonlar   = new System.Windows.Forms.Panel();
            this.lblIslemler        = new System.Windows.Forms.Label();
            this.btnSiparis         = new System.Windows.Forms.Button();
            this.btnMasaAc          = new System.Windows.Forms.Button();
            this.btnRezervEt        = new System.Windows.Forms.Button();
            this.btnYenileListele   = new System.Windows.Forms.Button();
            this.btnKapat           = new System.Windows.Forms.Button();

            this.panelAlt.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.SuspendLayout();

            // =====================================================================
            // lblBaslik
            // =====================================================================
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height    = 50;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Masa Durumları";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // =====================================================================
            // panelMasalar
            // =====================================================================
            this.panelMasalar.AutoScroll = true;
            this.panelMasalar.BackColor  = System.Drawing.Color.FromArgb(245, 245, 245);
            this.panelMasalar.Dock       = System.Windows.Forms.DockStyle.Fill;
            this.panelMasalar.Name       = "panelMasalar";
            this.panelMasalar.Padding    = new System.Windows.Forms.Padding(8);

            // =====================================================================
            // panelAlt — ana alt bar
            // =====================================================================
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelAlt.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Height    = 55;
            this.panelAlt.Name      = "panelAlt";
            this.panelAlt.Controls.Add(this.panelSagButonlar);   // önce sağ (dock right)
            this.panelAlt.Controls.Add(this.panelSolButonlar);   // sonra sol (dock fill)

            // =====================================================================
            // panelSolButonlar — sol taraftaki butonlar (İşlemler)
            // =====================================================================
            this.panelSolButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSolButonlar.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Name      = "panelSolButonlar";
            this.panelSolButonlar.Controls.Add(this.lblIslemler);
            this.panelSolButonlar.Controls.Add(this.btnSiparis);
            this.panelSolButonlar.Controls.Add(this.btnMasaAc);
            this.panelSolButonlar.Controls.Add(this.btnRezervEt);
            this.panelSolButonlar.Controls.Add(this.btnYenileListele);

            // =====================================================================
            // panelSagButonlar — sağ taraftaki Kapat butonu
            // =====================================================================
            this.panelSagButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSagButonlar.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Width     = 100;
            this.panelSagButonlar.Name      = "panelSagButonlar";
            this.panelSagButonlar.Controls.Add(this.btnKapat);

            // =====================================================================
            // İçindeki kontroller — sol
            // =====================================================================
            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 4);
            this.lblIslemler.Name      = "lblIslemler";
            this.lblIslemler.Text      = "İşlemler";

            this.btnSiparis.BackColor              = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSiparis.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiparis.FlatAppearance.BorderSize = 0;
            this.btnSiparis.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSiparis.ForeColor              = System.Drawing.Color.White;
            this.btnSiparis.Location               = new System.Drawing.Point(8, 20);
            this.btnSiparis.Name                   = "btnSiparis";
            this.btnSiparis.Size                   = new System.Drawing.Size(90, 28);
            this.btnSiparis.Text                   = "✚  Sipariş";
            this.btnSiparis.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnSiparis.Click += new System.EventHandler(this.btnSiparis_Click);

            this.btnMasaAc.BackColor              = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnMasaAc.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnMasaAc.FlatAppearance.BorderSize = 0;
            this.btnMasaAc.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnMasaAc.ForeColor              = System.Drawing.Color.White;
            this.btnMasaAc.Location               = new System.Drawing.Point(106, 20);
            this.btnMasaAc.Name                   = "btnMasaAc";
            this.btnMasaAc.Size                   = new System.Drawing.Size(90, 28);
            this.btnMasaAc.Text                   = "Masa Aç";
            this.btnMasaAc.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnMasaAc.Click += new System.EventHandler(this.btnMasaAc_Click);

            this.btnRezervEt.BackColor              = System.Drawing.Color.FromArgb(108, 117, 125);
            this.btnRezervEt.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervEt.FlatAppearance.BorderSize = 0;
            this.btnRezervEt.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRezervEt.ForeColor              = System.Drawing.Color.White;
            this.btnRezervEt.Location               = new System.Drawing.Point(204, 20);
            this.btnRezervEt.Name                   = "btnRezervEt";
            this.btnRezervEt.Size                   = new System.Drawing.Size(90, 28);
            this.btnRezervEt.Text                   = "Rezerv Et";
            this.btnRezervEt.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnRezervEt.Click += new System.EventHandler(this.btnRezervEt_Click);

            this.btnYenileListele.BackColor              = System.Drawing.Color.FromArgb(0, 123, 255);
            this.btnYenileListele.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenileListele.FlatAppearance.BorderSize = 0;
            this.btnYenileListele.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnYenileListele.ForeColor              = System.Drawing.Color.White;
            this.btnYenileListele.Location               = new System.Drawing.Point(302, 20);
            this.btnYenileListele.Name                   = "btnYenileListele";
            this.btnYenileListele.Size                   = new System.Drawing.Size(115, 28);
            this.btnYenileListele.Text                   = "↺  Yenile/Listele";
            this.btnYenileListele.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);

            // =====================================================================
            // btnKapat — sağ panelde, her zaman görünür
            // =====================================================================
            this.btnKapat.BackColor              = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKapat.ForeColor              = System.Drawing.Color.White;
            this.btnKapat.Location               = new System.Drawing.Point(8, 13);
            this.btnKapat.Name                   = "btnKapat";
            this.btnKapat.Size                   = new System.Drawing.Size(84, 28);
            this.btnKapat.Text                   = "✖  Kapat";
            this.btnKapat.Cursor                 = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // =====================================================================
            // MasaDurumlariControl
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.Controls.Add(this.panelMasalar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAlt);
            this.Name = "MasaDurumlariControl";
            this.Size = new System.Drawing.Size(1024, 500);

            this.panelSolButonlar.ResumeLayout(false);
            this.panelSolButonlar.PerformLayout();
            this.panelSagButonlar.ResumeLayout(false);
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label   lblBaslik;
        private System.Windows.Forms.Panel   panelMasalar;
        private System.Windows.Forms.Panel   panelAlt;
        private System.Windows.Forms.Panel   panelSolButonlar;
        private System.Windows.Forms.Panel   panelSagButonlar;
        private System.Windows.Forms.Label   lblIslemler;
        private System.Windows.Forms.Button  btnSiparis;
        private System.Windows.Forms.Button  btnMasaAc;
        private System.Windows.Forms.Button  btnRezervEt;
        private System.Windows.Forms.Button  btnYenileListele;
        private System.Windows.Forms.Button  btnKapat;
    }
}
