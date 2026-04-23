namespace CafeOtomasyonu
{
    partial class DashboardControl
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
            this.btnKapat = new System.Windows.Forms.Button();
            
            this.flowLayoutPanelCards = new System.Windows.Forms.FlowLayoutPanel();

            // Row 1 Panels
            this.panelGununCirosu = new System.Windows.Forms.Panel();
            this.lblGununCirosuTitle = new System.Windows.Forms.Label();
            this.lblGununCirosu = new System.Windows.Forms.Label();

            this.panelHaftalikCiro = new System.Windows.Forms.Panel();
            this.lblHaftalikCiroTitle = new System.Windows.Forms.Label();
            this.lblHaftalikCiro = new System.Windows.Forms.Label();

            this.panelAylikCiro = new System.Windows.Forms.Panel();
            this.lblAylikCiroTitle = new System.Windows.Forms.Label();
            this.lblAylikCiro = new System.Windows.Forms.Label();

            this.panelToplamKasa = new System.Windows.Forms.Panel();
            this.lblToplamKasaTitle = new System.Windows.Forms.Label();
            this.lblToplamKasa = new System.Windows.Forms.Label();

            // Row 2 Panels
            this.panelAktifMasalar = new System.Windows.Forms.Panel();
            this.lblAktifMasalarTitle = new System.Windows.Forms.Label();
            this.lblAktifMasalar = new System.Windows.Forms.Label();

            this.panelPaketSiparisler = new System.Windows.Forms.Panel();
            this.lblPaketSiparislerTitle = new System.Windows.Forms.Label();
            this.lblPaketSiparisler = new System.Windows.Forms.Label();

            this.panelToplamMusteri = new System.Windows.Forms.Panel();
            this.lblToplamMusteriTitle = new System.Windows.Forms.Label();
            this.lblToplamMusteri = new System.Windows.Forms.Label();

            this.panelSatilanUrun = new System.Windows.Forms.Panel();
            this.lblSatilanUrunTitle = new System.Windows.Forms.Label();
            this.lblSatilanUrun = new System.Windows.Forms.Label();

            this.flowLayoutPanelCards.SuspendLayout();
            this.panelGununCirosu.SuspendLayout();
            this.panelHaftalikCiro.SuspendLayout();
            this.panelAylikCiro.SuspendLayout();
            this.panelToplamKasa.SuspendLayout();            
            this.panelAktifMasalar.SuspendLayout();
            this.panelPaketSiparisler.SuspendLayout();
            this.panelToplamMusteri.SuspendLayout();
            this.panelSatilanUrun.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblBaslik
            // 
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height = 55;
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Text = "Kapsamlı Yönetim Paneli (Dashboard)";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.Location = new System.Drawing.Point(920, 10);
            this.btnKapat.Size = new System.Drawing.Size(100, 35);
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            //
            // flowLayoutPanelCards
            //
            this.flowLayoutPanelCards.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelCards.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanelCards.AutoScroll = true;
            this.flowLayoutPanelCards.Controls.Add(this.panelGununCirosu);
            this.flowLayoutPanelCards.Controls.Add(this.panelHaftalikCiro);
            this.flowLayoutPanelCards.Controls.Add(this.panelAylikCiro);
            this.flowLayoutPanelCards.Controls.Add(this.panelToplamKasa);
            
            this.flowLayoutPanelCards.Controls.Add(this.panelAktifMasalar);
            this.flowLayoutPanelCards.Controls.Add(this.panelPaketSiparisler);
            this.flowLayoutPanelCards.Controls.Add(this.panelToplamMusteri);
            this.flowLayoutPanelCards.Controls.Add(this.panelSatilanUrun);

            System.Windows.Forms.Padding cardMargin = new System.Windows.Forms.Padding(15);
            System.Drawing.Size cardSize = new System.Drawing.Size(280, 140);
            System.Drawing.Font titleFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font valueFont = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold);

            // ============================================
            // ROW 1 - FINANCIALS (Mali Veriler)
            // ============================================

            // panelGununCirosu (Light Blue)
            this.panelGununCirosu.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            this.panelGununCirosu.Size = cardSize;
            this.panelGununCirosu.Margin = cardMargin;
            this.panelGununCirosu.Controls.Add(this.lblGununCirosu);
            this.panelGununCirosu.Controls.Add(this.lblGununCirosuTitle);

            this.lblGununCirosuTitle.AutoSize = true;
            this.lblGununCirosuTitle.Font = titleFont;
            this.lblGununCirosuTitle.ForeColor = System.Drawing.Color.White;
            this.lblGununCirosuTitle.Location = new System.Drawing.Point(15, 20);
            this.lblGununCirosuTitle.Text = "📅 Günün Cirosu";

            this.lblGununCirosu.AutoSize = true;
            this.lblGununCirosu.Font = valueFont;
            this.lblGununCirosu.ForeColor = System.Drawing.Color.White;
            this.lblGununCirosu.Location = new System.Drawing.Point(15, 65);
            this.lblGununCirosu.Text = "₺ 18,250.00";

            // panelHaftalikCiro (Teal/Cyan)
            this.panelHaftalikCiro.BackColor = System.Drawing.Color.FromArgb(23, 162, 184);
            this.panelHaftalikCiro.Size = cardSize;
            this.panelHaftalikCiro.Margin = cardMargin;
            this.panelHaftalikCiro.Controls.Add(this.lblHaftalikCiro);
            this.panelHaftalikCiro.Controls.Add(this.lblHaftalikCiroTitle);

            this.lblHaftalikCiroTitle.AutoSize = true;
            this.lblHaftalikCiroTitle.Font = titleFont;
            this.lblHaftalikCiroTitle.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikCiroTitle.Location = new System.Drawing.Point(15, 20);
            this.lblHaftalikCiroTitle.Text = "🗓️ Bu Haftanın Cirosu";

            this.lblHaftalikCiro.AutoSize = true;
            this.lblHaftalikCiro.Font = valueFont;
            this.lblHaftalikCiro.ForeColor = System.Drawing.Color.White;
            this.lblHaftalikCiro.Location = new System.Drawing.Point(15, 65);
            this.lblHaftalikCiro.Text = "₺ 105,420.00";

            // panelAylikCiro (Purple)
            this.panelAylikCiro.BackColor = System.Drawing.Color.FromArgb(111, 66, 193);
            this.panelAylikCiro.Size = cardSize;
            this.panelAylikCiro.Margin = cardMargin;
            this.panelAylikCiro.Controls.Add(this.lblAylikCiro);
            this.panelAylikCiro.Controls.Add(this.lblAylikCiroTitle);

            this.lblAylikCiroTitle.AutoSize = true;
            this.lblAylikCiroTitle.Font = titleFont;
            this.lblAylikCiroTitle.ForeColor = System.Drawing.Color.White;
            this.lblAylikCiroTitle.Location = new System.Drawing.Point(15, 20);
            this.lblAylikCiroTitle.Text = "📆 Aylık Ciro (Bu Ay)";

            this.lblAylikCiro.AutoSize = true;
            this.lblAylikCiro.Font = valueFont;
            this.lblAylikCiro.ForeColor = System.Drawing.Color.White;
            this.lblAylikCiro.Location = new System.Drawing.Point(15, 65);
            this.lblAylikCiro.Text = "₺ 428,900.50";

            // panelToplamKasa (Green)
            this.panelToplamKasa.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.panelToplamKasa.Size = cardSize;
            this.panelToplamKasa.Margin = cardMargin;
            this.panelToplamKasa.Controls.Add(this.lblToplamKasa);
            this.panelToplamKasa.Controls.Add(this.lblToplamKasaTitle);

            this.lblToplamKasaTitle.AutoSize = true;
            this.lblToplamKasaTitle.Font = titleFont;
            this.lblToplamKasaTitle.ForeColor = System.Drawing.Color.White;
            this.lblToplamKasaTitle.Location = new System.Drawing.Point(15, 20);
            this.lblToplamKasaTitle.Text = "💰 Toplam Kasa";

            this.lblToplamKasa.AutoSize = true;
            this.lblToplamKasa.Font = valueFont;
            this.lblToplamKasa.ForeColor = System.Drawing.Color.White;
            this.lblToplamKasa.Location = new System.Drawing.Point(15, 65);
            this.lblToplamKasa.Text = "₺ 98,540.00";

            // ============================================
            // ROW 2 - OPERATIONS (Operasyonel Veriler)
            // ============================================

            // panelAktifMasalar (Orange/Warning)
            this.panelAktifMasalar.BackColor = System.Drawing.Color.FromArgb(253, 126, 20);
            this.panelAktifMasalar.Size = cardSize;
            this.panelAktifMasalar.Margin = cardMargin;
            this.panelAktifMasalar.Controls.Add(this.lblAktifMasalar);
            this.panelAktifMasalar.Controls.Add(this.lblAktifMasalarTitle);

            this.lblAktifMasalarTitle.AutoSize = true;
            this.lblAktifMasalarTitle.Font = titleFont;
            this.lblAktifMasalarTitle.ForeColor = System.Drawing.Color.White;
            this.lblAktifMasalarTitle.Location = new System.Drawing.Point(15, 20);
            this.lblAktifMasalarTitle.Text = "🍴 Aktif / Dolu Masalar";

            this.lblAktifMasalar.AutoSize = true;
            this.lblAktifMasalar.Font = valueFont;
            this.lblAktifMasalar.ForeColor = System.Drawing.Color.White;
            this.lblAktifMasalar.Location = new System.Drawing.Point(15, 65);
            this.lblAktifMasalar.Text = "12 / 30";

            // panelPaketSiparisler (Red/Danger)
            this.panelPaketSiparisler.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.panelPaketSiparisler.Size = cardSize;
            this.panelPaketSiparisler.Margin = cardMargin;
            this.panelPaketSiparisler.Controls.Add(this.lblPaketSiparisler);
            this.panelPaketSiparisler.Controls.Add(this.lblPaketSiparislerTitle);

            this.lblPaketSiparislerTitle.AutoSize = true;
            this.lblPaketSiparislerTitle.Font = titleFont;
            this.lblPaketSiparislerTitle.ForeColor = System.Drawing.Color.White;
            this.lblPaketSiparislerTitle.Location = new System.Drawing.Point(15, 20);
            this.lblPaketSiparislerTitle.Text = "🛵 Bekleyen Paketler";

            this.lblPaketSiparisler.AutoSize = true;
            this.lblPaketSiparisler.Font = valueFont;
            this.lblPaketSiparisler.ForeColor = System.Drawing.Color.White;
            this.lblPaketSiparisler.Location = new System.Drawing.Point(15, 65);
            this.lblPaketSiparisler.Text = "8";

            // panelToplamMusteri (Navy/Indigo)
            this.panelToplamMusteri.BackColor = System.Drawing.Color.FromArgb(102, 16, 242);
            this.panelToplamMusteri.Size = cardSize;
            this.panelToplamMusteri.Margin = cardMargin;
            this.panelToplamMusteri.Controls.Add(this.lblToplamMusteri);
            this.panelToplamMusteri.Controls.Add(this.lblToplamMusteriTitle);

            this.lblToplamMusteriTitle.AutoSize = true;
            this.lblToplamMusteriTitle.Font = titleFont;
            this.lblToplamMusteriTitle.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteriTitle.Location = new System.Drawing.Point(15, 20);
            this.lblToplamMusteriTitle.Text = "👥 Kayıtlı Müşteriler";

            this.lblToplamMusteri.AutoSize = true;
            this.lblToplamMusteri.Font = valueFont;
            this.lblToplamMusteri.ForeColor = System.Drawing.Color.White;
            this.lblToplamMusteri.Location = new System.Drawing.Point(15, 65);
            this.lblToplamMusteri.Text = "1,452";

            // panelSatilanUrun (Pink/Rose)
            this.panelSatilanUrun.BackColor = System.Drawing.Color.FromArgb(232, 62, 140);
            this.panelSatilanUrun.Size = cardSize;
            this.panelSatilanUrun.Margin = cardMargin;
            this.panelSatilanUrun.Controls.Add(this.lblSatilanUrun);
            this.panelSatilanUrun.Controls.Add(this.lblSatilanUrunTitle);

            this.lblSatilanUrunTitle.AutoSize = true;
            this.lblSatilanUrunTitle.Font = titleFont;
            this.lblSatilanUrunTitle.ForeColor = System.Drawing.Color.White;
            this.lblSatilanUrunTitle.Location = new System.Drawing.Point(15, 20);
            this.lblSatilanUrunTitle.Text = "☕ Bugün Satılan Ürün";

            this.lblSatilanUrun.AutoSize = true;
            this.lblSatilanUrun.Font = valueFont;
            this.lblSatilanUrun.ForeColor = System.Drawing.Color.White;
            this.lblSatilanUrun.Location = new System.Drawing.Point(15, 65);
            this.lblSatilanUrun.Text = "485 Adet";

            // DashboardControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnKapat);
            this.Controls.Add(this.flowLayoutPanelCards);
            this.Controls.Add(this.lblBaslik);
            this.Name = "DashboardControl";
            this.Size = new System.Drawing.Size(1024, 600);
            this.Load += new System.EventHandler(this.DashboardControl_Load);

            this.flowLayoutPanelCards.ResumeLayout(false);
            this.panelGununCirosu.ResumeLayout(false);
            this.panelGununCirosu.PerformLayout();
            this.panelHaftalikCiro.ResumeLayout(false);
            this.panelHaftalikCiro.PerformLayout();
            this.panelAylikCiro.ResumeLayout(false);
            this.panelAylikCiro.PerformLayout();
            this.panelToplamKasa.ResumeLayout(false);
            this.panelToplamKasa.PerformLayout();
            
            this.panelAktifMasalar.ResumeLayout(false);
            this.panelAktifMasalar.PerformLayout();
            this.panelPaketSiparisler.ResumeLayout(false);
            this.panelPaketSiparisler.PerformLayout();
            this.panelToplamMusteri.ResumeLayout(false);
            this.panelToplamMusteri.PerformLayout();
            this.panelSatilanUrun.ResumeLayout(false);
            this.panelSatilanUrun.PerformLayout();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Button btnKapat;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelCards;
        
        // Row 1
        private System.Windows.Forms.Panel panelGununCirosu;
        private System.Windows.Forms.Label lblGununCirosuTitle;
        private System.Windows.Forms.Label lblGununCirosu;

        private System.Windows.Forms.Panel panelHaftalikCiro;
        private System.Windows.Forms.Label lblHaftalikCiroTitle;
        private System.Windows.Forms.Label lblHaftalikCiro;

        private System.Windows.Forms.Panel panelAylikCiro;
        private System.Windows.Forms.Label lblAylikCiroTitle;
        private System.Windows.Forms.Label lblAylikCiro;

        private System.Windows.Forms.Panel panelToplamKasa;
        private System.Windows.Forms.Label lblToplamKasaTitle;
        private System.Windows.Forms.Label lblToplamKasa;

        // Row 2
        private System.Windows.Forms.Panel panelAktifMasalar;
        private System.Windows.Forms.Label lblAktifMasalarTitle;
        private System.Windows.Forms.Label lblAktifMasalar;

        private System.Windows.Forms.Panel panelPaketSiparisler;
        private System.Windows.Forms.Label lblPaketSiparislerTitle;
        private System.Windows.Forms.Label lblPaketSiparisler;

        private System.Windows.Forms.Panel panelToplamMusteri;
        private System.Windows.Forms.Label lblToplamMusteriTitle;
        private System.Windows.Forms.Label lblToplamMusteri;

        private System.Windows.Forms.Panel panelSatilanUrun;
        private System.Windows.Forms.Label lblSatilanUrunTitle;
        private System.Windows.Forms.Label lblSatilanUrun;
    }
}
