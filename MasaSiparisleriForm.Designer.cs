namespace CafeOtomasyonu
{
    partial class MasaSiparisleriForm
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
            // ---- Başlık ----
            this.lblBaslik             = new System.Windows.Forms.Label();

            // ---- Ana container (sidebar + içerik) ----
            this.panelMain             = new System.Windows.Forms.Panel();

            // ---- Sol sidebar ----
            this.panelSidebar          = new System.Windows.Forms.Panel();
            this.btnNavSiparisler      = new System.Windows.Forms.Button();
            this.btnNavOdemeler        = new System.Windows.Forms.Button();

            // ---- Siparişler paneli ----
            this.panelSiparisler       = new System.Windows.Forms.Panel();
            this.lblSiparisler         = new System.Windows.Forms.Label();
            this.panelMusteri          = new System.Windows.Forms.Panel();
            this.lblMusteri            = new System.Windows.Forms.Label();
            this.cmbMusteri            = new System.Windows.Forms.ComboBox();
            this.btnMusteriTemizle     = new System.Windows.Forms.Button();
            this.lblTarih              = new System.Windows.Forms.Label();
            this.dtpTarih              = new System.Windows.Forms.DateTimePicker();
            this.panelAciklama         = new System.Windows.Forms.Panel();
            this.lblAciklama           = new System.Windows.Forms.Label();
            this.txtAciklama           = new System.Windows.Forms.TextBox();
            this.dataGridView          = new System.Windows.Forms.DataGridView();
            this.colSil                = new System.Windows.Forms.DataGridViewButtonColumn();

            // ---- Ödemeler paneli ----
            this.panelOdemeler         = new System.Windows.Forms.Panel();
            this.lblOdemeler           = new System.Windows.Forms.Label();
            this.panelGroupOdemeler    = new System.Windows.Forms.Panel();
            this.lblGroupTextOdemeler  = new System.Windows.Forms.Label();
            this.lblSearchOdemeler     = new System.Windows.Forms.Label();
            this.panelNakitKredi       = new System.Windows.Forms.Panel();
            this.btnNakit              = new System.Windows.Forms.Button();
            this.btnKrediKarti         = new System.Windows.Forms.Button();
            this.dataGridViewOdemeler  = new System.Windows.Forms.DataGridView();
            this.colSilOdeme           = new System.Windows.Forms.DataGridViewButtonColumn();

            // ---- Alt toplam paneli ----
            this.panelToplam           = new System.Windows.Forms.Panel();
            this.lblOdenenEtiket       = new System.Windows.Forms.Label();
            this.lblOdenen             = new System.Windows.Forms.Label();
            this.lblKalanEtiket        = new System.Windows.Forms.Label();
            this.lblKalan              = new System.Windows.Forms.Label();
            this.lblIndToplamıEtiket   = new System.Windows.Forms.Label();
            this.lblIndToplamı         = new System.Windows.Forms.Label();
            this.lblIndOraniEtiket     = new System.Windows.Forms.Label();
            this.lblIndOrani           = new System.Windows.Forms.Label();
            this.lblToplamEtiket       = new System.Windows.Forms.Label();
            this.lblToplam             = new System.Windows.Forms.Label();
            this.lblIndliToplamEtiket  = new System.Windows.Forms.Label();
            this.lblIndliToplam        = new System.Windows.Forms.Label();

            // ---- İşlemler barı ----
            this.panelIslemler         = new System.Windows.Forms.Panel();
            this.lblIslemler           = new System.Windows.Forms.Label();
            this.btnSiparisEkle        = new System.Windows.Forms.Button();
            this.btnYeni               = new System.Windows.Forms.Button();
            this.btnYenileListele      = new System.Windows.Forms.Button();
            this.btnKaydet             = new System.Windows.Forms.Button();
            this.panelIslemlerSag      = new System.Windows.Forms.Panel();
            this.btnSonuclandır        = new System.Windows.Forms.Button();
            this.btnKapat              = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).BeginInit();
            this.panelMain.SuspendLayout();
            this.panelSidebar.SuspendLayout();
            this.panelSiparisler.SuspendLayout();
            this.panelMusteri.SuspendLayout();
            this.panelAciklama.SuspendLayout();
            this.panelOdemeler.SuspendLayout();
            this.panelGroupOdemeler.SuspendLayout();
            this.panelNakitKredi.SuspendLayout();
            this.panelToplam.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelIslemlerSag.SuspendLayout();
            this.SuspendLayout();

            // =====================================================================
            // lblBaslik
            // =====================================================================
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Height    = 54;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Masa Siparişleri";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.BackColor = System.Drawing.Color.White;

            // =====================================================================
            // panelMain — tüm orta alanı kaplar
            // =====================================================================
            this.panelMain.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelMain.Name      = "panelMain";
            this.panelMain.BackColor = System.Drawing.Color.White;

            // =====================================================================
            // panelSidebar — sol dar şerit
            // =====================================================================
            this.panelSidebar.Dock       = System.Windows.Forms.DockStyle.Left;
            this.panelSidebar.Width      = 44;
            this.panelSidebar.Name       = "panelSidebar";
            this.panelSidebar.BackColor  = System.Drawing.Color.White;
            this.panelSidebar.BorderStyle = System.Windows.Forms.BorderStyle.None;

            // btnNavSiparisler
            this.btnNavSiparisler.Location  = new System.Drawing.Point(4, 10);
            this.btnNavSiparisler.Size      = new System.Drawing.Size(36, 36);
            this.btnNavSiparisler.Name      = "btnNavSiparisler";
            this.btnNavSiparisler.Text      = "🛒";
            this.btnNavSiparisler.Font      = new System.Drawing.Font("Segoe UI", 13F);
            this.btnNavSiparisler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavSiparisler.FlatAppearance.BorderSize  = 1;
            this.btnNavSiparisler.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(0, 120, 215);
            this.btnNavSiparisler.BackColor = System.Drawing.Color.FromArgb(219, 234, 255);
            this.btnNavSiparisler.ForeColor = System.Drawing.Color.Black;
            this.btnNavSiparisler.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnNavSiparisler.Click    += new System.EventHandler(this.btnNavSiparisler_Click);

            // btnNavOdemeler
            this.btnNavOdemeler.Location  = new System.Drawing.Point(4, 54);
            this.btnNavOdemeler.Size      = new System.Drawing.Size(36, 36);
            this.btnNavOdemeler.Name      = "btnNavOdemeler";
            this.btnNavOdemeler.Text      = "🏷";
            this.btnNavOdemeler.Font      = new System.Drawing.Font("Segoe UI", 13F);
            this.btnNavOdemeler.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNavOdemeler.FlatAppearance.BorderSize  = 1;
            this.btnNavOdemeler.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btnNavOdemeler.BackColor = System.Drawing.Color.White;
            this.btnNavOdemeler.ForeColor = System.Drawing.Color.Black;
            this.btnNavOdemeler.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnNavOdemeler.Click    += new System.EventHandler(this.btnNavOdemeler_Click);

            this.panelSidebar.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNavSiparisler, this.btnNavOdemeler
            });

            // =====================================================================
            // panelSiparisler — Siparişler görünümü (varsayılan görünür)
            // =====================================================================
            this.panelSiparisler.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelSiparisler.Name      = "panelSiparisler";
            this.panelSiparisler.BackColor = System.Drawing.Color.White;
            this.panelSiparisler.Visible   = true;

            // lblSiparisler
            this.lblSiparisler.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblSiparisler.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblSiparisler.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.lblSiparisler.Height    = 34;
            this.lblSiparisler.Name      = "lblSiparisler";
            this.lblSiparisler.Padding   = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblSiparisler.Text      = "Siparişler";
            this.lblSiparisler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // panelMusteri
            this.panelMusteri.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelMusteri.Height    = 34;
            this.panelMusteri.Name      = "panelMusteri";
            this.panelMusteri.BackColor = System.Drawing.Color.White;

            this.lblMusteri.AutoSize = true;
            this.lblMusteri.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblMusteri.Location = new System.Drawing.Point(4, 8);
            this.lblMusteri.Name     = "lblMusteri";
            this.lblMusteri.Text     = "Müşteri :";

            this.cmbMusteri.Location     = new System.Drawing.Point(68, 5);
            this.cmbMusteri.Name         = "cmbMusteri";
            this.cmbMusteri.Size         = new System.Drawing.Size(260, 21);
            this.cmbMusteri.Text         = "Müşteri Seçiniz";
            this.cmbMusteri.Font         = new System.Drawing.Font("Segoe UI", 9F);
            this.cmbMusteri.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDown;

            this.btnMusteriTemizle.Location  = new System.Drawing.Point(330, 5);
            this.btnMusteriTemizle.Name      = "btnMusteriTemizle";
            this.btnMusteriTemizle.Size      = new System.Drawing.Size(22, 21);
            this.btnMusteriTemizle.Text      = "X";
            this.btnMusteriTemizle.Font      = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.btnMusteriTemizle.ForeColor = System.Drawing.Color.White;
            this.btnMusteriTemizle.BackColor = System.Drawing.Color.FromArgb(200, 30, 30);
            this.btnMusteriTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMusteriTemizle.FlatAppearance.BorderSize = 0;
            this.btnMusteriTemizle.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnMusteriTemizle.Click    += new System.EventHandler(this.btnMusteriTemizle_Click);

            this.lblTarih.AutoSize = true;
            this.lblTarih.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTarih.Location = new System.Drawing.Point(370, 8);
            this.lblTarih.Name     = "lblTarih";
            this.lblTarih.Text     = "Tarih :";

            this.dtpTarih.Location = new System.Drawing.Point(415, 5);
            this.dtpTarih.Name     = "dtpTarih";
            this.dtpTarih.Size     = new System.Drawing.Size(160, 21);
            this.dtpTarih.Format   = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Font     = new System.Drawing.Font("Segoe UI", 9F);

            this.panelMusteri.Controls.Add(this.dtpTarih);
            this.panelMusteri.Controls.Add(this.lblTarih);
            this.panelMusteri.Controls.Add(this.btnMusteriTemizle);
            this.panelMusteri.Controls.Add(this.cmbMusteri);
            this.panelMusteri.Controls.Add(this.lblMusteri);

            // panelAciklama
            this.panelAciklama.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelAciklama.Height    = 54;
            this.panelAciklama.Name      = "panelAciklama";
            this.panelAciklama.BackColor = System.Drawing.Color.White;

            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font     = new System.Drawing.Font("Segoe UI", 9F);
            this.lblAciklama.Location = new System.Drawing.Point(4, 18);
            this.lblAciklama.Name     = "lblAciklama";
            this.lblAciklama.Text     = "Açıklama :";

            this.txtAciklama.Anchor     = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right;
            this.txtAciklama.Font       = new System.Drawing.Font("Segoe UI", 9F);
            this.txtAciklama.Location   = new System.Drawing.Point(68, 4);
            this.txtAciklama.Multiline  = true;
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Name       = "txtAciklama";
            this.txtAciklama.Size       = new System.Drawing.Size(900, 46);

            this.panelAciklama.Controls.Add(this.txtAciklama);
            this.panelAciklama.Controls.Add(this.lblAciklama);

            // dataGridView
            this.dataGridView.Dock               = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.BackgroundColor    = System.Drawing.Color.White;
            this.dataGridView.BorderStyle        = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Name               = "dataGridView";
            this.dataGridView.GridColor          = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.DefaultCellStyle.Font              = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(245, 248, 255);
            this.dataGridView.AllowUserToAddRows  = false;
            this.dataGridView.RowHeadersVisible   = false;
            this.dataGridView.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridView.EnableHeadersVisualStyles = true;

            this.colSil.HeaderText = "Sil";
            this.colSil.Name       = "colSil";
            this.colSil.Width      = 35;
            this.colSil.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridView.Columns.Add(this.colSil);
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);

            // panelSiparisler Controls (Fill son eklenir)
            this.panelSiparisler.Controls.Add(this.dataGridView);
            this.panelSiparisler.Controls.Add(this.panelAciklama);
            this.panelSiparisler.Controls.Add(this.panelMusteri);
            this.panelSiparisler.Controls.Add(this.lblSiparisler);

            // =====================================================================
            // panelOdemeler — Ödemeler görünümü (başlangıçta gizli)
            // =====================================================================
            this.panelOdemeler.Dock      = System.Windows.Forms.DockStyle.Fill;
            this.panelOdemeler.Name      = "panelOdemeler";
            this.panelOdemeler.BackColor = System.Drawing.Color.White;
            this.panelOdemeler.Visible   = false;

            // lblOdemeler
            this.lblOdemeler.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblOdemeler.Font      = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblOdemeler.ForeColor = System.Drawing.Color.FromArgb(30, 80, 160);
            this.lblOdemeler.Height    = 34;
            this.lblOdemeler.Name      = "lblOdemeler";
            this.lblOdemeler.Padding   = new System.Windows.Forms.Padding(4, 0, 0, 0);
            this.lblOdemeler.Text      = "Ödemeler";
            this.lblOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // panelGroupOdemeler (Drag a column header bar)
            this.panelGroupOdemeler.Dock        = System.Windows.Forms.DockStyle.Top;
            this.panelGroupOdemeler.Height      = 24;
            this.panelGroupOdemeler.Name        = "panelGroupOdemeler";
            this.panelGroupOdemeler.BackColor   = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelGroupOdemeler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblGroupTextOdemeler.AutoSize  = true;
            this.lblGroupTextOdemeler.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupTextOdemeler.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupTextOdemeler.Location  = new System.Drawing.Point(6, 4);
            this.lblGroupTextOdemeler.Name      = "lblGroupTextOdemeler";
            this.lblGroupTextOdemeler.Text      = "Drag a column header here to group by that column";

            this.lblSearchOdemeler.AutoSize  = false;
            this.lblSearchOdemeler.Dock      = System.Windows.Forms.DockStyle.Right;
            this.lblSearchOdemeler.Width     = 24;
            this.lblSearchOdemeler.Font      = new System.Drawing.Font("Segoe UI", 11F);
            this.lblSearchOdemeler.ForeColor = System.Drawing.Color.Gray;
            this.lblSearchOdemeler.Name      = "lblSearchOdemeler";
            this.lblSearchOdemeler.Text      = "🔍";
            this.lblSearchOdemeler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelGroupOdemeler.Controls.Add(this.lblSearchOdemeler);
            this.panelGroupOdemeler.Controls.Add(this.lblGroupTextOdemeler);

            // panelNakitKredi — Nakit ve Kredi Kartı butonları (grid altında)
            this.panelNakitKredi.Dock        = System.Windows.Forms.DockStyle.Bottom;
            this.panelNakitKredi.Height      = 40;
            this.panelNakitKredi.Name        = "panelNakitKredi";
            this.panelNakitKredi.BackColor   = System.Drawing.Color.White;
            this.panelNakitKredi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.btnNakit.Location  = new System.Drawing.Point(6, 7);
            this.btnNakit.Size      = new System.Drawing.Size(90, 26);
            this.btnNakit.Name      = "btnNakit";
            this.btnNakit.Text      = "Nakit";
            this.btnNakit.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNakit.BackColor = System.Drawing.Color.White;
            this.btnNakit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNakit.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnNakit.FlatAppearance.BorderSize  = 1;
            this.btnNakit.ForeColor = System.Drawing.Color.Black;
            this.btnNakit.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnNakit.Click    += new System.EventHandler(this.btnNakit_Click);

            this.btnKrediKarti.Location  = new System.Drawing.Point(104, 7);
            this.btnKrediKarti.Size      = new System.Drawing.Size(100, 26);
            this.btnKrediKarti.Name      = "btnKrediKarti";
            this.btnKrediKarti.Text      = "Kredi Kartı";
            this.btnKrediKarti.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnKrediKarti.BackColor = System.Drawing.Color.White;
            this.btnKrediKarti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKrediKarti.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKrediKarti.FlatAppearance.BorderSize  = 1;
            this.btnKrediKarti.ForeColor = System.Drawing.Color.Black;
            this.btnKrediKarti.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnKrediKarti.Click    += new System.EventHandler(this.btnKrediKarti_Click);

            this.panelNakitKredi.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnNakit, this.btnKrediKarti
            });

            // dataGridViewOdemeler
            this.dataGridViewOdemeler.Dock               = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewOdemeler.BackgroundColor    = System.Drawing.Color.White;
            this.dataGridViewOdemeler.BorderStyle        = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewOdemeler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOdemeler.Name               = "dataGridViewOdemeler";
            this.dataGridViewOdemeler.GridColor          = System.Drawing.Color.LightGray;
            this.dataGridViewOdemeler.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridViewOdemeler.DefaultCellStyle.Font              = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridViewOdemeler.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.dataGridViewOdemeler.AllowUserToAddRows  = false;
            this.dataGridViewOdemeler.RowHeadersVisible   = true;
            this.dataGridViewOdemeler.RowHeadersWidth     = 18;
            this.dataGridViewOdemeler.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOdemeler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridViewOdemeler.EnableHeadersVisualStyles = true;

            this.colSilOdeme.HeaderText = "Sil";
            this.colSilOdeme.Name       = "colSilOdeme";
            this.colSilOdeme.Width      = 35;
            this.colSilOdeme.FlatStyle  = System.Windows.Forms.FlatStyle.Flat;
            this.dataGridViewOdemeler.Columns.Add(this.colSilOdeme);
            this.dataGridViewOdemeler.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewOdemeler_CellClick);

            // panelOdemeler Controls (Fill son)
            this.panelOdemeler.Controls.Add(this.dataGridViewOdemeler);
            this.panelOdemeler.Controls.Add(this.panelNakitKredi);
            this.panelOdemeler.Controls.Add(this.panelGroupOdemeler);
            this.panelOdemeler.Controls.Add(this.lblOdemeler);

            // =====================================================================
            // panelMain — içerik panellerini barındırır
            // =====================================================================
            this.panelMain.Controls.Add(this.panelOdemeler);     // Fill (gizli)
            this.panelMain.Controls.Add(this.panelSiparisler);   // Fill (görünür)
            this.panelMain.Controls.Add(this.panelSidebar);      // Left

            // =====================================================================
            // panelToplam — 2 satır, 3 grup
            // =====================================================================
            this.panelToplam.BackColor = System.Drawing.Color.FromArgb(235, 235, 235);
            this.panelToplam.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelToplam.Height    = 58;
            this.panelToplam.Name      = "panelToplam";

            // Sol: Ödenen + Kalan
            this.lblOdenenEtiket.AutoSize  = true;
            this.lblOdenenEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblOdenenEtiket.Location  = new System.Drawing.Point(10, 8);
            this.lblOdenenEtiket.Name      = "lblOdenenEtiket";
            this.lblOdenenEtiket.Text      = "Ödenen :";

            this.lblOdenen.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblOdenen.ForeColor  = System.Drawing.Color.White;
            this.lblOdenen.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblOdenen.Location   = new System.Drawing.Point(80, 6);
            this.lblOdenen.Name       = "lblOdenen";
            this.lblOdenen.Size       = new System.Drawing.Size(130, 20);
            this.lblOdenen.Text       = "₺0,00";
            this.lblOdenen.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblKalanEtiket.AutoSize  = true;
            this.lblKalanEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblKalanEtiket.Location  = new System.Drawing.Point(10, 33);
            this.lblKalanEtiket.Name      = "lblKalanEtiket";
            this.lblKalanEtiket.Text      = "Kalan :";

            this.lblKalan.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblKalan.ForeColor  = System.Drawing.Color.White;
            this.lblKalan.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblKalan.Location   = new System.Drawing.Point(80, 31);
            this.lblKalan.Name       = "lblKalan";
            this.lblKalan.Size       = new System.Drawing.Size(130, 20);
            this.lblKalan.Text       = "₺0,00";
            this.lblKalan.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            // Orta: İndirim Toplamı + İndirim Oranı
            this.lblIndToplamıEtiket.AutoSize  = true;
            this.lblIndToplamıEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndToplamıEtiket.Location  = new System.Drawing.Point(360, 8);
            this.lblIndToplamıEtiket.Name      = "lblIndToplamıEtiket";
            this.lblIndToplamıEtiket.Text      = "İndirim Toplamı :";

            this.lblIndToplamı.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblIndToplamı.ForeColor  = System.Drawing.Color.White;
            this.lblIndToplamı.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndToplamı.Location   = new System.Drawing.Point(475, 6);
            this.lblIndToplamı.Name       = "lblIndToplamı";
            this.lblIndToplamı.Size       = new System.Drawing.Size(120, 20);
            this.lblIndToplamı.Text       = "₺0,00";
            this.lblIndToplamı.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblIndOraniEtiket.AutoSize  = true;
            this.lblIndOraniEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndOraniEtiket.Location  = new System.Drawing.Point(360, 33);
            this.lblIndOraniEtiket.Name      = "lblIndOraniEtiket";
            this.lblIndOraniEtiket.Text      = "İndirim Oranı(%) :";

            this.lblIndOrani.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblIndOrani.ForeColor  = System.Drawing.Color.White;
            this.lblIndOrani.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndOrani.Location   = new System.Drawing.Point(475, 31);
            this.lblIndOrani.Name       = "lblIndOrani";
            this.lblIndOrani.Size       = new System.Drawing.Size(120, 20);
            this.lblIndOrani.Text       = "%0,00";
            this.lblIndOrani.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            // Sağ: Toplam + İndirimli Toplam
            this.lblToplamEtiket.AutoSize  = true;
            this.lblToplamEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblToplamEtiket.Location  = new System.Drawing.Point(720, 8);
            this.lblToplamEtiket.Name      = "lblToplamEtiket";
            this.lblToplamEtiket.Text      = "Toplam :";

            this.lblToplam.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblToplam.ForeColor  = System.Drawing.Color.White;
            this.lblToplam.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblToplam.Location   = new System.Drawing.Point(790, 6);
            this.lblToplam.Name       = "lblToplam";
            this.lblToplam.Size       = new System.Drawing.Size(130, 20);
            this.lblToplam.Text       = "₺0,00";
            this.lblToplam.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            this.lblIndliToplamEtiket.AutoSize  = true;
            this.lblIndliToplamEtiket.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.lblIndliToplamEtiket.Location  = new System.Drawing.Point(720, 33);
            this.lblIndliToplamEtiket.Name      = "lblIndliToplamEtiket";
            this.lblIndliToplamEtiket.Text      = "İndirimli Toplam :";

            this.lblIndliToplam.BackColor  = System.Drawing.Color.FromArgb(40, 167, 69);
            this.lblIndliToplam.ForeColor  = System.Drawing.Color.White;
            this.lblIndliToplam.Font       = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIndliToplam.Location   = new System.Drawing.Point(820, 31);
            this.lblIndliToplam.Name       = "lblIndliToplam";
            this.lblIndliToplam.Size       = new System.Drawing.Size(130, 20);
            this.lblIndliToplam.Text       = "₺0,00";
            this.lblIndliToplam.TextAlign  = System.Drawing.ContentAlignment.MiddleCenter;

            this.panelToplam.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblOdenenEtiket,    this.lblOdenen,
                this.lblKalanEtiket,     this.lblKalan,
                this.lblIndToplamıEtiket, this.lblIndToplamı,
                this.lblIndOraniEtiket,  this.lblIndOrani,
                this.lblToplamEtiket,    this.lblToplam,
                this.lblIndliToplamEtiket, this.lblIndliToplam
            });

            // =====================================================================
            // panelIslemler — alt bar
            // =====================================================================
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(225, 225, 225);
            this.panelIslemler.Dock      = System.Windows.Forms.DockStyle.Bottom;
            this.panelIslemler.Height    = 50;
            this.panelIslemler.Name      = "panelIslemler";

            this.lblIslemler.AutoSize  = true;
            this.lblIslemler.Font      = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.Location  = new System.Drawing.Point(8, 4);
            this.lblIslemler.Name      = "lblIslemler";
            this.lblIslemler.Text      = "İşlemler";

            KurIslemButon(this.btnSiparisEkle,  "btnSiparisEkle",  "✚  Sipariş Ekle",   System.Drawing.Color.FromArgb(40, 167, 69),  8,   14, 115);
            KurIslemButon(this.btnYeni,          "btnYeni",         "📄  Yeni",          System.Drawing.Color.FromArgb(23, 162, 184), 130, 14, 90);
            KurIslemButon(this.btnYenileListele, "btnYenileListele","↺  Yenile-Listele", System.Drawing.Color.FromArgb(0, 123, 255),  228, 14, 125);
            KurIslemButon(this.btnKaydet,        "btnKaydet",       "💾  Kaydet",        System.Drawing.Color.FromArgb(108, 117, 125),361, 14, 95);

            this.btnSiparisEkle.Click   += new System.EventHandler(this.btnSiparisEkle_Click);
            this.btnYeni.Click           += new System.EventHandler(this.btnYeni_Click);
            this.btnYenileListele.Click += new System.EventHandler(this.btnYenileListele_Click);
            this.btnKaydet.Click        += new System.EventHandler(this.btnKaydet_Click);

            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Width     = 210;
            this.panelIslemlerSag.Name      = "panelIslemlerSag";

            KurIslemButon(this.btnSonuclandır, "btnSonuclandır", "✔  Sonuçlandır", System.Drawing.Color.FromArgb(40, 167, 69),  5,   11, 128);
            KurIslemButon(this.btnKapat,        "btnKapat",       "✖  Kapat",      System.Drawing.Color.FromArgb(220, 53, 69),  140, 11, 68);

            this.btnSonuclandır.Click += new System.EventHandler(this.btnSonuclandır_Click);
            this.btnKapat.Click       += new System.EventHandler(this.btnKapat_Click);

            this.panelIslemlerSag.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnSonuclandır, this.btnKapat
            });

            this.panelIslemler.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.lblIslemler,
                this.btnSiparisEkle, this.btnYeni, this.btnYenileListele, this.btnKaydet,
                this.panelIslemlerSag
            });

            // =====================================================================
            // Form
            // =====================================================================
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode       = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor           = System.Drawing.Color.White;
            this.ClientSize          = new System.Drawing.Size(1060, 680);
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Name                = "MasaSiparisleriForm";
            this.WindowState         = System.Windows.Forms.FormWindowState.Maximized;

            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelToplam);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lblBaslik);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOdemeler)).EndInit();
            this.panelMain.ResumeLayout(false);
            this.panelSidebar.ResumeLayout(false);
            this.panelSiparisler.ResumeLayout(false);
            this.panelSiparisler.PerformLayout();
            this.panelMusteri.ResumeLayout(false);
            this.panelMusteri.PerformLayout();
            this.panelAciklama.ResumeLayout(false);
            this.panelAciklama.PerformLayout();
            this.panelOdemeler.ResumeLayout(false);
            this.panelGroupOdemeler.ResumeLayout(false);
            this.panelGroupOdemeler.PerformLayout();
            this.panelNakitKredi.ResumeLayout(false);
            this.panelToplam.ResumeLayout(false);
            this.panelToplam.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private static void KurIslemButon(System.Windows.Forms.Button btn, string name, string text,
                                          System.Drawing.Color renk, int x, int y, int w)
        {
            btn.BackColor                = renk;
            btn.FlatStyle                = System.Windows.Forms.FlatStyle.Flat;
            btn.FlatAppearance.BorderSize = 0;
            btn.Font                     = new System.Drawing.Font("Segoe UI", 9F);
            btn.ForeColor                = System.Drawing.Color.White;
            btn.Location                 = new System.Drawing.Point(x, y);
            btn.Name                     = name;
            btn.Size                     = new System.Drawing.Size(w, 28);
            btn.Text                     = text;
            btn.Cursor                   = System.Windows.Forms.Cursors.Hand;
        }

        #endregion

        private System.Windows.Forms.Label     lblBaslik;
        private System.Windows.Forms.Panel     panelMain;
        private System.Windows.Forms.Panel     panelSidebar;
        private System.Windows.Forms.Button    btnNavSiparisler;
        private System.Windows.Forms.Button    btnNavOdemeler;
        private System.Windows.Forms.Panel     panelSiparisler;
        private System.Windows.Forms.Label     lblSiparisler;
        private System.Windows.Forms.Panel     panelMusteri;
        private System.Windows.Forms.Label     lblMusteri;
        private System.Windows.Forms.ComboBox  cmbMusteri;
        private System.Windows.Forms.Button    btnMusteriTemizle;
        private System.Windows.Forms.Label     lblTarih;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Panel     panelAciklama;
        private System.Windows.Forms.Label     lblAciklama;
        private System.Windows.Forms.TextBox   txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataGridViewButtonColumn colSil;
        private System.Windows.Forms.Panel     panelOdemeler;
        private System.Windows.Forms.Label     lblOdemeler;
        private System.Windows.Forms.Panel     panelGroupOdemeler;
        private System.Windows.Forms.Label     lblGroupTextOdemeler;
        private System.Windows.Forms.Label     lblSearchOdemeler;
        private System.Windows.Forms.Panel     panelNakitKredi;
        private System.Windows.Forms.Button    btnNakit;
        private System.Windows.Forms.Button    btnKrediKarti;
        private System.Windows.Forms.DataGridView dataGridViewOdemeler;
        private System.Windows.Forms.DataGridViewButtonColumn colSilOdeme;
        private System.Windows.Forms.Panel     panelToplam;
        private System.Windows.Forms.Label     lblOdenenEtiket;
        private System.Windows.Forms.Label     lblOdenen;
        private System.Windows.Forms.Label     lblKalanEtiket;
        private System.Windows.Forms.Label     lblKalan;
        private System.Windows.Forms.Label     lblIndToplamıEtiket;
        private System.Windows.Forms.Label     lblIndToplamı;
        private System.Windows.Forms.Label     lblIndOraniEtiket;
        private System.Windows.Forms.Label     lblIndOrani;
        private System.Windows.Forms.Label     lblToplamEtiket;
        private System.Windows.Forms.Label     lblToplam;
        private System.Windows.Forms.Label     lblIndliToplamEtiket;
        private System.Windows.Forms.Label     lblIndliToplam;
        private System.Windows.Forms.Panel     panelIslemler;
        private System.Windows.Forms.Label     lblIslemler;
        private System.Windows.Forms.Button    btnSiparisEkle;
        private System.Windows.Forms.Button    btnYeni;
        private System.Windows.Forms.Button    btnYenileListele;
        private System.Windows.Forms.Button    btnKaydet;
        private System.Windows.Forms.Panel     panelIslemlerSag;
        private System.Windows.Forms.Button    btnSonuclandır;
        private System.Windows.Forms.Button    btnKapat;
    }
}
