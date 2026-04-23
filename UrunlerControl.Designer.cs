namespace CafeOtomasyonu
{
    partial class UrunlerControl
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null) components.Dispose();
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.lblBaslik          = new System.Windows.Forms.Label();
            this.panelGroupBar      = new System.Windows.Forms.Panel();
            this.lblGroupBy         = new System.Windows.Forms.Label();
            this.dataGridView       = new System.Windows.Forms.DataGridView();
            this.panelAlt           = new System.Windows.Forms.Panel();
            this.panelSolButonlar   = new System.Windows.Forms.Panel();
            this.panelSagButonlar   = new System.Windows.Forms.Panel();
            this.btnYeni            = new System.Windows.Forms.Button();
            this.btnDuzenle         = new System.Windows.Forms.Button();
            this.btnYenileListele   = new System.Windows.Forms.Button();
            this.btnMasaHareketleri = new System.Windows.Forms.Button();
            this.btnKaydet          = new System.Windows.Forms.Button();
            this.btnSil             = new System.Windows.Forms.Button();
            this.btnKapat           = new System.Windows.Forms.Button();
            this.lblIslemler        = new System.Windows.Forms.Label();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelGroupBar.SuspendLayout();
            this.panelAlt.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height    = 46;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Ürünler";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.BackColor = System.Drawing.Color.White;

            // panelGroupBar — "Drag a column header..."
            this.panelGroupBar.BackColor = System.Drawing.Color.FromArgb(230, 230, 230);
            this.panelGroupBar.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelGroupBar.Height    = 22;
            this.panelGroupBar.Name      = "panelGroupBar";
            this.panelGroupBar.Controls.Add(this.lblGroupBy);

            this.lblGroupBy.AutoSize  = true;
            this.lblGroupBy.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupBy.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupBy.Location  = new System.Drawing.Point(6, 4);
            this.lblGroupBy.Name      = "lblGroupBy";
            this.lblGroupBy.Text      = "Drag a column header here to group by that column";

            // dataGridView
            this.dataGridView.BackgroundColor        = System.Drawing.Color.White;
            this.dataGridView.BorderStyle            = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView.Dock                   = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.GridColor              = System.Drawing.Color.LightGray;
            this.dataGridView.Name                   = "dataGridView";
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.DefaultCellStyle.Font  = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);

            // panelAlt
            this.panelAlt.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelAlt.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelAlt.Height    = 50;
            this.panelAlt.Name      = "panelAlt";
            this.panelAlt.Controls.Add(this.panelSagButonlar);
            this.panelAlt.Controls.Add(this.panelSolButonlar);

            // panelSolButonlar
            this.panelSolButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSolButonlar.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.Name      = "panelSolButonlar";
            this.panelSolButonlar.Controls.Add(this.lblIslemler);
            this.panelSolButonlar.Controls.Add(this.btnYeni);
            this.panelSolButonlar.Controls.Add(this.btnDuzenle);
            this.panelSolButonlar.Controls.Add(this.btnYenileListele);
            this.panelSolButonlar.Controls.Add(this.btnMasaHareketleri);
            this.panelSolButonlar.Controls.Add(this.btnKaydet);

            // panelSagButonlar
            this.panelSagButonlar.BackColor = System.Drawing.Color.Transparent;
            this.panelSagButonlar.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Width     = 175;
            this.panelSagButonlar.Name      = "panelSagButonlar";
            this.panelSagButonlar.Controls.Add(this.btnKapat);
            this.panelSagButonlar.Controls.Add(this.btnSil);

            // lblIslemler
            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(60, 60, 60);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 2);
            this.lblIslemler.Name      = "lblIslemler";
            this.lblIslemler.Text      = "İşlemler";

            // Sol butonlar
            Btn(this.btnYeni,            "btnYeni",            "✚  Yeni",            System.Drawing.Color.FromArgb(40, 167, 69),  8,   15, 90);
            Btn(this.btnDuzenle,         "btnDuzenle",         "✎  Düzenle",         System.Drawing.Color.FromArgb(0, 123, 255),  106, 15, 90);
            Btn(this.btnYenileListele,   "btnYenileListele",   "↺  Yenile-Listele",  System.Drawing.Color.FromArgb(0, 123, 255),  204, 15, 115);
            Btn(this.btnMasaHareketleri, "btnMasaHareketleri", "⊕  Masa Hareketleri",System.Drawing.Color.FromArgb(40, 167, 69),  327, 15, 130);
            Btn(this.btnKaydet,          "btnKaydet",          "💾  Kaydet",         System.Drawing.Color.FromArgb(108,117,125),  465, 15, 90);

            this.btnYeni.Click            += new System.EventHandler(this.btnYeni_Click);
            this.btnDuzenle.Click         += new System.EventHandler(this.btnDuzenle_Click);
            this.btnYenileListele.Click   += new System.EventHandler(this.btnYenileListele_Click);
            this.btnMasaHareketleri.Click += new System.EventHandler(this.btnMasaHareketleri_Click);
            this.btnKaydet.Click          += new System.EventHandler(this.btnKaydet_Click);

            // Sağ butonlar
            Btn(this.btnSil,   "btnSil",   "✏  Sil",   System.Drawing.Color.FromArgb(220, 130, 20), 5,  11, 80);
            Btn(this.btnKapat, "btnKapat", "✖  Kapat", System.Drawing.Color.FromArgb(220, 53, 69),  93, 11, 75);

            this.btnSil.Click   += new System.EventHandler(this.btnSil_Click);
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // UrunlerControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGroupBar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAlt);
            this.Name = "UrunlerControl";
            this.Size = new System.Drawing.Size(1024, 500);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelGroupBar.ResumeLayout(false);
            this.panelGroupBar.PerformLayout();
            this.panelSolButonlar.ResumeLayout(false);
            this.panelSolButonlar.PerformLayout();
            this.panelSagButonlar.ResumeLayout(false);
            this.panelAlt.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private static void Btn(System.Windows.Forms.Button btn, string name, string text,
                                 System.Drawing.Color renk, int x, int y, int w)
        {
            btn.BackColor              = renk;
            btn.FlatStyle              = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font                   = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor              = System.Drawing.Color.White;
            btn.Location               = new System.Drawing.Point(x, y);
            btn.Name                   = name;
            btn.Size                   = new System.Drawing.Size(w, 28);
            btn.Text                   = text;
            btn.Cursor                 = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Panel          panelGroupBar;
        private System.Windows.Forms.Label          lblGroupBy;
        private System.Windows.Forms.DataGridView   dataGridView;
        private System.Windows.Forms.Panel          panelAlt;
        private System.Windows.Forms.Panel          panelSolButonlar;
        private System.Windows.Forms.Panel          panelSagButonlar;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnYeni;
        private System.Windows.Forms.Button         btnDuzenle;
        private System.Windows.Forms.Button         btnYenileListele;
        private System.Windows.Forms.Button         btnMasaHareketleri;
        private System.Windows.Forms.Button         btnKaydet;
        private System.Windows.Forms.Button         btnSil;
        private System.Windows.Forms.Button         btnKapat;
    }
}
