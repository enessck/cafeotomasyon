namespace CafeOtomasyonu
{
    partial class OdemeHareketleriControl
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
            System.Windows.Forms.DataGridViewCellStyle cellStyle = new System.Windows.Forms.DataGridViewCellStyle();
            this.lblBaslik         = new System.Windows.Forms.Label();
            this.panelGroupBar     = new System.Windows.Forms.Panel();
            this.lblGroupBy        = new System.Windows.Forms.Label();
            this.lblSearchIcon     = new System.Windows.Forms.Label();
            this.dataGridView      = new System.Windows.Forms.DataGridView();
            this.panelAltDusuk     = new System.Windows.Forms.Panel();
            this.panelIslemler     = new System.Windows.Forms.Panel();
            this.lblIslemler       = new System.Windows.Forms.Label();
            
            this.panelSagButonlar  = new System.Windows.Forms.Panel();
            this.panelSolButonlar  = new System.Windows.Forms.Panel();
            
            this.btnDetay          = new System.Windows.Forms.Button();
            this.btnYazdir         = new System.Windows.Forms.Button();
            this.btnYenile         = new System.Windows.Forms.Button();
            this.btnSil            = new System.Windows.Forms.Button();
            this.btnKapat          = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelGroupBar.SuspendLayout();
            this.panelAltDusuk.SuspendLayout();
            this.panelIslemler.SuspendLayout();
            this.panelSagButonlar.SuspendLayout();
            this.panelSolButonlar.SuspendLayout();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.Dock      = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font      = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.FromArgb(40, 40, 40);
            this.lblBaslik.Height    = 55;
            this.lblBaslik.Name      = "lblBaslik";
            this.lblBaslik.Text      = "Ödeme Hareketleri";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // panelGroupBar
            this.panelGroupBar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelGroupBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelGroupBar.Height = 35;
            this.panelGroupBar.Controls.Add(this.lblSearchIcon);
            this.panelGroupBar.Controls.Add(this.lblGroupBy);

            // lblGroupBy
            this.lblGroupBy.AutoSize = true;
            this.lblGroupBy.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblGroupBy.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupBy.Location = new System.Drawing.Point(8, 10);
            this.lblGroupBy.Text = "Gruplamak istediğiniz sütun başlığını buraya sürükleyin";

            // lblSearchIcon
            this.lblSearchIcon.AutoSize = true;
            this.lblSearchIcon.Font = new System.Drawing.Font("Segoe UI Emoji", 10F);
            this.lblSearchIcon.ForeColor = System.Drawing.Color.DimGray;
            this.lblSearchIcon.Location = new System.Drawing.Point(1050, 7);
            this.lblSearchIcon.Anchor = System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right;
            this.lblSearchIcon.Text = "🔍";

            // dataGridView
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false; 
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.ReadOnly = true;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 90);
            this.dataGridView.RowHeadersVisible = true; 
            this.dataGridView.RowHeadersWidth = 30; 
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.MultiSelect = false;
            
            cellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            cellStyle.BackColor = System.Drawing.Color.White;
            cellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            cellStyle.ForeColor = System.Drawing.Color.Black;
            cellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(204, 232, 255);
            cellStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dataGridView.DefaultCellStyle = cellStyle;

            // panelAltDusuk 
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Height = 85;
            this.panelAltDusuk.Controls.Add(this.panelSagButonlar);
            this.panelAltDusuk.Controls.Add(this.panelSolButonlar);
            this.panelAltDusuk.Controls.Add(this.panelIslemler);

            // panelIslemler
            this.panelIslemler.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelIslemler.Height = 25;
            this.panelIslemler.BackColor = System.Drawing.Color.FromArgb(220, 220, 220);
            this.panelIslemler.Controls.Add(this.lblIslemler);

            // lblIslemler
            this.lblIslemler.AutoSize = true;
            this.lblIslemler.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblIslemler.ForeColor = System.Drawing.Color.FromArgb(50, 50, 50);
            this.lblIslemler.Location = new System.Drawing.Point(8, 5);
            this.lblIslemler.Text = "İşlemler";

            // panelSagButonlar 
            this.panelSagButonlar.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSagButonlar.Width = 200; 
            this.panelSagButonlar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelSagButonlar.Controls.Add(this.btnSil);
            this.panelSagButonlar.Controls.Add(this.btnKapat);

            // panelSolButonlar 
            this.panelSolButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelSolButonlar.Controls.Add(this.btnDetay);
            this.panelSolButonlar.Controls.Add(this.btnYazdir);
            this.panelSolButonlar.Controls.Add(this.btnYenile);

            // Buton Stilleri
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 9F);

            // btnDetay
            this.btnDetay.Location = new System.Drawing.Point(10, 10);
            this.btnDetay.Size = new System.Drawing.Size(125, 35);
            this.btnDetay.Text = "🔍 Satış Detayı";
            this.btnDetay.Font = btnFont;
            this.btnDetay.BackColor = System.Drawing.Color.White;
            this.btnDetay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDetay.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDetay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDetay.Click += new System.EventHandler(this.btnDetay_Click);

            // btnYazdir
            this.btnYazdir.Location = new System.Drawing.Point(145, 10);
            this.btnYazdir.Size = new System.Drawing.Size(100, 35);
            this.btnYazdir.Text = "🖨️ Yazdır";
            this.btnYazdir.Font = btnFont;
            this.btnYazdir.BackColor = System.Drawing.Color.White;
            this.btnYazdir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYazdir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnYazdir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);

            // btnYenile
            this.btnYenile.Location = new System.Drawing.Point(255, 10);
            this.btnYenile.Size = new System.Drawing.Size(140, 35);
            this.btnYenile.Text = "🔄 Yenile-Listele";
            this.btnYenile.Font = btnFont;
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(5, 10);
            this.btnSil.Size = new System.Drawing.Size(90, 35);
            this.btnSil.Text = "🗑 Sil";
            this.btnSil.Font = btnFont;
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // btnKapat 
            this.btnKapat.Location = new System.Drawing.Point(100, 10); 
            this.btnKapat.Size = new System.Drawing.Size(90, 35);
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // OdemeHareketleriControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGroupBar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAltDusuk);
            this.Name = "OdemeHareketleriControl";
            this.Size = new System.Drawing.Size(1100, 600);
            this.Load += new System.EventHandler(this.OdemeHareketleriControl_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelGroupBar.ResumeLayout(false);
            this.panelGroupBar.PerformLayout();
            this.panelAltDusuk.ResumeLayout(false);
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelSagButonlar.ResumeLayout(false);
            this.panelSolButonlar.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelGroupBar;
        private System.Windows.Forms.Label lblGroupBy;
        private System.Windows.Forms.Label lblSearchIcon;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Panel panelIslemler;
        private System.Windows.Forms.Label lblIslemler;
        
        private System.Windows.Forms.Panel panelSagButonlar;
        private System.Windows.Forms.Panel panelSolButonlar;
        
        private System.Windows.Forms.Button btnDetay;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}
