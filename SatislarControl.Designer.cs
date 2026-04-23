namespace CafeOtomasyonu
{
    partial class SatislarControl
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
            this.lblBaslik           = new System.Windows.Forms.Label();
            this.panelGroup          = new System.Windows.Forms.Panel();
            this.lblGroupText        = new System.Windows.Forms.Label();
            this.lblSearch           = new System.Windows.Forms.Label();
            this.dataGridView        = new System.Windows.Forms.DataGridView();
            this.panelOzet           = new System.Windows.Forms.Panel();
            this.lblKayit            = new System.Windows.Forms.Label();
            this.lblOzetTutar        = new System.Windows.Forms.Label();
            this.lblOzetIndirim      = new System.Windows.Forms.Label();
            this.lblOzetOdenen       = new System.Windows.Forms.Label();
            this.lblOzetKalan        = new System.Windows.Forms.Label();
            this.panelIslemler       = new System.Windows.Forms.Panel();
            this.lblIslemler         = new System.Windows.Forms.Label();
            this.btnSiparisDetaylari = new System.Windows.Forms.Button();
            this.btnOdemeHareketleri = new System.Windows.Forms.Button();
            this.btnYenileListele    = new System.Windows.Forms.Button();
            this.panelIslemlerSag    = new System.Windows.Forms.Panel();
            this.btnKapat            = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelGroup.SuspendLayout();
            this.panelOzet.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
            this.SuspendLayout();

            // =====================================================================
            // lblBaslik
            // =====================================================================
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height    = 54;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Satışlar";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.BackColor = System.Drawing.Color.White;

            // =====================================================================
            // panelGroup — "Drag a column header..." çubuğu
            // =====================================================================
            this.panelGroup.Dock        = System.Windows.Forms.DockStyle.Top;
            this.panelGroup.Height      = 26;
            this.panelGroup.Name        = "panelGroup";
            this.panelGroup.BackColor   = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblGroupText.AutoSize  = true;
            this.lblGroupText.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupText.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupText.Location  = new System.Drawing.Point(6, 5);
            this.lblGroupText.Name      = "lblGroupText";
            this.lblGroupText.Text      = "Drag a column header here to group by that column";

            this.lblSearch.AutoSize  = false;
            this.lblSearch.Dock      = System.Windows.Forms.DockStyle.Right;
            this.lblSearch.Width     = 26;
            this.lblSearch.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearch.ForeColor = System.Drawing.Color.Gray;
            this.lblSearch.Name      = "lblSearch";
            this.lblSearch.Text      = "🔍";
            this.lblSearch.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelGroup.Controls.Add(this.lblSearch);
            this.panelGroup.Controls.Add(this.lblGroupText);

            // =====================================================================
            // dataGridView
            // =====================================================================
            this.dataGridView.Dock                      = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.BackgroundColor           = System.Drawing.Color.White;
            this.dataGridView.BorderStyle               = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Name                      = "dataGridView";
            this.dataGridView.GridColor                 = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.dataGridView.DefaultCellStyle.Font              = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.dataGridView.AllowUserToAddRows        = false;
            this.dataGridView.ReadOnly                  = true;
            this.dataGridView.RowHeadersVisible         = true;
            this.dataGridView.RowHeadersWidth           = 18;
            this.dataGridView.SelectionMode             = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.AutoSizeColumnsMode       = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridView.EnableHeadersVisualStyles = true;

            // =====================================================================
            // panelOzet — alt özet bar (Kayıt, Tutar, İndirim, Ödenen, Kalan)
            // =====================================================================
            this.panelOzet.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelOzet.Height    = 30;
            this.panelOzet.Name      = "panelOzet";
            this.panelOzet.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.panelOzet.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            // Kayıt sayısı
            KurOzetLabel(this.lblKayit,       "lblKayit",       "Kayıt: 0",   10,   0, 110);
            KurOzetLabel(this.lblOzetTutar,   "lblOzetTutar",   "Tutar=₺0,00",130,  0, 130);
            KurOzetLabel(this.lblOzetIndirim, "lblOzetIndirim", "₺0,00",      270,  0, 100);
            KurOzetLabel(this.lblOzetOdenen,  "lblOzetOdenen",  "₺0,00",      380,  0, 100);
            KurOzetLabel(this.lblOzetKalan,   "lblOzetKalan",   "₺0,00",      490,  0, 100);

            this.panelOzet.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblKayit, this.lblOzetTutar, this.lblOzetIndirim,
                this.lblOzetOdenen, this.lblOzetKalan
            });

            // =====================================================================
            // panelIslemler — en alt işlem barı
            // =====================================================================
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelIslemler.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Height    = 52;
            this.panelIslemler.Name      = "panelIslemler";

            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 4);
            this.lblIslemler.Name      = "lblIslemler";
            this.lblIslemler.Text      = "İşlemler";

            // Sipariş Detayları (gri, sol)
            KurIslemButon(this.btnSiparisDetaylari, "btnSiparisDetaylari",
                          "🧾  Sipariş Detayları",
                          System.Drawing.Color.FromArgb(108, 117, 125), 8, 16, 140);

            // Ödeme Hareketleri (koyu mavi)
            KurIslemButon(this.btnOdemeHareketleri, "btnOdemeHareketleri",
                          "▶  Ödeme Hareketleri",
                          System.Drawing.Color.FromArgb(23, 114, 190), 156, 16, 140);

            // Yenile-Listele (mavi)
            KurIslemButon(this.btnYenileListele, "btnYenileListele",
                          "↺  Yenile-Listele",
                          System.Drawing.Color.FromArgb(0, 123, 255), 304, 16, 130);

            this.btnSiparisDetaylari.Click += new System.EventHandler(this.btnSiparisDetaylari_Click);
            this.btnOdemeHareketleri.Click += new System.EventHandler(this.btnOdemeHareketleri_Click);
            this.btnYenileListele.Click    += new System.EventHandler(this.btnYenileListele_Click);

            // Sağ: Kapat
            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Width     = 110;
            this.panelIslemlerSag.Name      = "panelIslemlerSag";

            KurIslemButon(this.btnKapat, "btnKapat",
                          "✖  Kapat",
                          System.Drawing.Color.FromArgb(220, 53, 69), 10, 12, 90);
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            this.panelIslemlerSag.Controls.Add(this.btnKapat);

            this.panelIslemler.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblIslemler,
                this.btnSiparisDetaylari,
                this.btnOdemeHareketleri,
                this.btnYenileListele,
                this.panelIslemlerSag
            });

            // =====================================================================
            // SatislarControl
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.Name                = "SatislarControl";
            this.Size                = new System.Drawing.Size(1024, 600);

            // Add order: Fill → (bottom-up) Ozet → Islemler → (top) Group → Baslik
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelOzet);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.lblBaslik);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panelOzet.ResumeLayout(false);
            this.panelOzet.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private static void KurIslemButon(System.Windows.Forms.Button btn, string name,
            string text, System.Drawing.Color renk, int x, int y, int w)
        {
            btn.BackColor = renk;
            btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font      = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor = System.Drawing.Color.White;
            btn.Location  = new System.Drawing.Point(x, y);
            btn.Name      = name;
            btn.Size      = new System.Drawing.Size(w, 28);
            btn.Text      = text;
            btn.Cursor    = System.Windows.Forms.Cursors.Hand;
        }

        private static void KurOzetLabel(System.Windows.Forms.Label lbl, string name,
            string text, int x, int y, int w)
        {
            lbl.AutoSize  = false;
            lbl.Font      = new System.Drawing.Font("Segoe UI", 9F);
            lbl.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            lbl.Location  = new System.Drawing.Point(x, y);
            lbl.Name      = name;
            lbl.Size      = new System.Drawing.Size(w, 30);
            lbl.Text      = text;
            lbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
        }

        #endregion

        private System.Windows.Forms.Label          lblBaslik;
        private System.Windows.Forms.Panel          panelGroup;
        private System.Windows.Forms.Label          lblGroupText;
        private System.Windows.Forms.Label          lblSearch;
        private System.Windows.Forms.DataGridView   dataGridView;
        private System.Windows.Forms.Panel          panelOzet;
        private System.Windows.Forms.Label          lblKayit;
        private System.Windows.Forms.Label          lblOzetTutar;
        private System.Windows.Forms.Label          lblOzetIndirim;
        private System.Windows.Forms.Label          lblOzetOdenen;
        private System.Windows.Forms.Label          lblOzetKalan;
        private System.Windows.Forms.Panel          panelIslemler;
        private System.Windows.Forms.Label          lblIslemler;
        private System.Windows.Forms.Button         btnSiparisDetaylari;
        private System.Windows.Forms.Button         btnOdemeHareketleri;
        private System.Windows.Forms.Button         btnYenileListele;
        private System.Windows.Forms.Panel          panelIslemlerSag;
        private System.Windows.Forms.Button         btnKapat;
    }
}
