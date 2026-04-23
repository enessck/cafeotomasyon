namespace CafeOtomasyonu
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.ribbonControl = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.xtraTabControl = new DevExpress.XtraTab.XtraTabControl();

            this.ribbonPage_CafeIslemleri = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPage_Ayarlar = new DevExpress.XtraBars.Ribbon.RibbonPage();

            // Gruplar
            this.ribbonPageGroup_Masalar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Menuler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Urunler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Kullanicilar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Musteriler = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Satislar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_PaketSiparisi = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_Raporlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup_GenelAyarlar = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();

            // Butonlar
            this.barBtnMasalar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMasaHareketleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMasaSiparisleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMenuler = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMenuHareketleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnUrunler = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnUrunHareketleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnKullanicilar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnKullaniciHareketleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnBilgilerim = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMusteriler = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnSatislar = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnOdemeHareketleri = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnPaketSiparisi = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnMasaHareketleriRaporu = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnOzelRaporOlustur = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnDashboard = new DevExpress.XtraBars.BarLargeButtonItem();
            this.barBtnGenelAyarlar = new DevExpress.XtraBars.BarLargeButtonItem();

            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).BeginInit();
            this.SuspendLayout();

            // =====================================================================
            // xtraTabControl — içerik alanı (ribbon altındaki alan)
            // =====================================================================
            this.xtraTabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl.Location = new System.Drawing.Point(0, 144);
            this.xtraTabControl.Name = "xtraTabControl";
            this.xtraTabControl.Size = new System.Drawing.Size(1024, 456);
            this.xtraTabControl.TabIndex = 1;

            // =====================================================================
            // Ribbon butonları
            // =====================================================================
            KurButon(this.barBtnMasalar,               1,  "Masalar", "BO_Organization");
            KurButon(this.barBtnMasaHareketleri,       2,  "Masa Hareketleri", "List");
            KurButon(this.barBtnMasaSiparisleri,       3,  "Masa Siparişleri", "BO_Order");
            KurButon(this.barBtnMenuler,               4,  "Menüler", "BO_List");
            KurButon(this.barBtnMenuHareketleri,       5,  "Menü Hareketleri", "List");
            KurButon(this.barBtnUrunler,               6,  "Ürünler", "BO_Product");
            KurButon(this.barBtnUrunHareketleri,       7,  "Ürün Hareketleri", "List");
            KurButon(this.barBtnKullanicilar,          8,  "Kullanıcılar", "BO_Employee");
            KurButon(this.barBtnKullaniciHareketleri,  9,  "Kullanıcı\nHareketleri", "List");
            KurButon(this.barBtnBilgilerim,            10, "Bilgilerim", "BO_Department");
            KurButon(this.barBtnMusteriler,            11, "Müşteriler", "BO_Customer");
            KurButon(this.barBtnSatislar,              12, "Satışlar", "BO_Sale");
            KurButon(this.barBtnOdemeHareketleri,      13, "Ödeme\nHareketleri", "Currency");
            KurButon(this.barBtnPaketSiparisi,         14, "Paket Siparişi", "BO_Order");
            KurButon(this.barBtnMasaHareketleriRaporu, 15, "Masa Hareketleri\nRaporu", "BO_Report");
            KurButon(this.barBtnOzelRaporOlustur,      16, "Özel Rapor\nOluştur", "BO_Report");
            KurButon(this.barBtnDashboard,             17, "Dashboard", "Chart");
            KurButon(this.barBtnGenelAyarlar,          18, "Genel Ayarlar", "Action_Settings");

            // =====================================================================
            // ribbonControl
            // =====================================================================
            this.ribbonControl.ExpandCollapseItem.Id = 0;
            this.ribbonControl.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
                this.ribbonControl.ExpandCollapseItem,
                this.barBtnMasalar, this.barBtnMasaHareketleri, this.barBtnMasaSiparisleri,
                this.barBtnMenuler, this.barBtnMenuHareketleri,
                this.barBtnUrunler, this.barBtnUrunHareketleri,
                this.barBtnKullanicilar, this.barBtnKullaniciHareketleri, this.barBtnBilgilerim,
                this.barBtnMusteriler,
                this.barBtnSatislar, this.barBtnOdemeHareketleri,
                this.barBtnPaketSiparisi,
                this.barBtnMasaHareketleriRaporu, this.barBtnOzelRaporOlustur, this.barBtnDashboard,
                this.barBtnGenelAyarlar
            });
            this.ribbonControl.Location = new System.Drawing.Point(0, 0);
            this.ribbonControl.MaxItemId = 50;
            this.ribbonControl.Name = "ribbonControl";
            this.ribbonControl.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
                this.ribbonPage_CafeIslemleri,
                this.ribbonPage_Ayarlar
            });
            this.ribbonControl.Size = new System.Drawing.Size(1024, 144);
            this.ribbonControl.TabIndex = 0;

            // =====================================================================
            // Sayfa: Cafe İşlemleri
            // =====================================================================
            this.ribbonPage_CafeIslemleri.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
                this.ribbonPageGroup_Masalar,
                this.ribbonPageGroup_Menuler,
                this.ribbonPageGroup_Urunler,
                this.ribbonPageGroup_Kullanicilar,
                this.ribbonPageGroup_Musteriler,
                this.ribbonPageGroup_Satislar,
                this.ribbonPageGroup_PaketSiparisi,
                this.ribbonPageGroup_Raporlar
            });
            this.ribbonPage_CafeIslemleri.Name = "ribbonPage_CafeIslemleri";
            this.ribbonPage_CafeIslemleri.Text = "Cafe İşlemleri";

            this.ribbonPage_Ayarlar.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
                this.ribbonPageGroup_GenelAyarlar
            });
            this.ribbonPage_Ayarlar.Name = "ribbonPage_Ayarlar";
            this.ribbonPage_Ayarlar.Text = "Ayarlar";

            // Genel Ayarlar grubu
            this.ribbonPageGroup_GenelAyarlar.ItemLinks.Add(this.barBtnGenelAyarlar);
            this.ribbonPageGroup_GenelAyarlar.Name = "ribbonPageGroup_GenelAyarlar";
            this.ribbonPageGroup_GenelAyarlar.Text = "Sistem";

            // Masalar grubu
            this.ribbonPageGroup_Masalar.ItemLinks.Add(this.barBtnMasalar);
            this.ribbonPageGroup_Masalar.ItemLinks.Add(this.barBtnMasaHareketleri);
            this.ribbonPageGroup_Masalar.ItemLinks.Add(this.barBtnMasaSiparisleri);
            this.ribbonPageGroup_Masalar.Name = "ribbonPageGroup_Masalar";
            this.ribbonPageGroup_Masalar.Text = "Masalar";

            // Menüler grubu
            this.ribbonPageGroup_Menuler.ItemLinks.Add(this.barBtnMenuler);
            this.ribbonPageGroup_Menuler.ItemLinks.Add(this.barBtnMenuHareketleri);
            this.ribbonPageGroup_Menuler.Name = "ribbonPageGroup_Menuler";
            this.ribbonPageGroup_Menuler.Text = "Menüler";

            // Ürünler grubu
            this.ribbonPageGroup_Urunler.ItemLinks.Add(this.barBtnUrunler);
            this.ribbonPageGroup_Urunler.ItemLinks.Add(this.barBtnUrunHareketleri);
            this.ribbonPageGroup_Urunler.Name = "ribbonPageGroup_Urunler";
            this.ribbonPageGroup_Urunler.Text = "Ürünler";

            // Kullanıcılar grubu
            this.ribbonPageGroup_Kullanicilar.ItemLinks.Add(this.barBtnKullanicilar);
            this.ribbonPageGroup_Kullanicilar.ItemLinks.Add(this.barBtnKullaniciHareketleri);
            this.ribbonPageGroup_Kullanicilar.ItemLinks.Add(this.barBtnBilgilerim);
            this.ribbonPageGroup_Kullanicilar.Name = "ribbonPageGroup_Kullanicilar";
            this.ribbonPageGroup_Kullanicilar.Text = "Kullanıcılar";

            // Müşteriler grubu
            this.ribbonPageGroup_Musteriler.ItemLinks.Add(this.barBtnMusteriler);
            this.ribbonPageGroup_Musteriler.Name = "ribbonPageGroup_Musteriler";
            this.ribbonPageGroup_Musteriler.Text = "Müşteriler";

            // Satışlar grubu
            this.ribbonPageGroup_Satislar.ItemLinks.Add(this.barBtnSatislar);
            this.ribbonPageGroup_Satislar.ItemLinks.Add(this.barBtnOdemeHareketleri);
            this.ribbonPageGroup_Satislar.Name = "ribbonPageGroup_Satislar";
            this.ribbonPageGroup_Satislar.Text = "Satışlar";

            // Paket Siparişi grubu
            this.ribbonPageGroup_PaketSiparisi.ItemLinks.Add(this.barBtnPaketSiparisi);
            this.ribbonPageGroup_PaketSiparisi.Name = "ribbonPageGroup_PaketSiparisi";
            this.ribbonPageGroup_PaketSiparisi.Text = "Paket Siparişi";

            // Raporlar grubu
            this.ribbonPageGroup_Raporlar.ItemLinks.Add(this.barBtnMasaHareketleriRaporu);
            this.ribbonPageGroup_Raporlar.ItemLinks.Add(this.barBtnOzelRaporOlustur);
            this.ribbonPageGroup_Raporlar.ItemLinks.Add(this.barBtnDashboard);
            this.ribbonPageGroup_Raporlar.Name = "ribbonPageGroup_Raporlar";
            this.ribbonPageGroup_Raporlar.Text = "Raporlar";

            // =====================================================================
            // MainForm
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.xtraTabControl);
            this.Controls.Add(this.ribbonControl);
            this.Name = "MainForm";
            this.Ribbon = this.ribbonControl;
            this.Text = "Cafe Otomasyonu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;

            ((System.ComponentModel.ISupportInitialize)(this.ribbonControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private static void KurButon(DevExpress.XtraBars.BarLargeButtonItem btn, int id, string caption, string imageUriName = "Action_Execute")
        {
            btn.Id = id;
            btn.Name = "barBtn_" + id;
            btn.Caption = caption;
            try { btn.ImageOptions.ImageUri.Uri = imageUriName; } catch { }
        }

        #endregion

        // Kontroller
        private DevExpress.XtraBars.Ribbon.RibbonControl ribbonControl;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl;

        // Sayfalar
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_CafeIslemleri;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage_Ayarlar;

        // Gruplar
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Masalar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Menuler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Urunler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Kullanicilar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Musteriler;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Satislar;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_PaketSiparisi;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_Raporlar;

        // Butonlar - Masalar
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMasalar;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMasaHareketleri;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMasaSiparisleri;

        // Butonlar - Menüler
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMenuler;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMenuHareketleri;

        // Butonlar - Ürünler
        private DevExpress.XtraBars.BarLargeButtonItem barBtnUrunler;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnUrunHareketleri;

        // Butonlar - Kullanıcılar
        private DevExpress.XtraBars.BarLargeButtonItem barBtnKullanicilar;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnKullaniciHareketleri;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnBilgilerim;

        // Butonlar - Müşteriler
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMusteriler;

        // Butonlar - Satışlar
        private DevExpress.XtraBars.BarLargeButtonItem barBtnSatislar;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnOdemeHareketleri;

        // Butonlar - Paket Siparişi
        private DevExpress.XtraBars.BarLargeButtonItem barBtnPaketSiparisi;

        // Butonlar - Raporlar
        private DevExpress.XtraBars.BarLargeButtonItem barBtnMasaHareketleriRaporu;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnOzelRaporOlustur;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnDashboard;
        
        // Ayarlar
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup_GenelAyarlar;
        private DevExpress.XtraBars.BarLargeButtonItem barBtnGenelAyarlar;
    }
}
