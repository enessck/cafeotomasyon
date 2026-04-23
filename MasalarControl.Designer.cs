namespace CafeOtomasyonu
{
    partial class MasalarControl
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
            
            this.btnEkle           = new System.Windows.Forms.Button();
            this.btnDuzenle        = new System.Windows.Forms.Button();
            this.btnYenile         = new System.Windows.Forms.Button();
            this.btnDurumDegistir  = new System.Windows.Forms.Button();
            this.btnRezervDegistir = new System.Windows.Forms.Button();
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
            this.lblBaslik.Text      = "Masalar";
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
            this.lblGroupBy.Text = "Drag a column header here to group by that column";

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
            this.panelSagButonlar.Width = 510; 
            this.panelSagButonlar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelSagButonlar.Controls.Add(this.btnDurumDegistir);
            this.panelSagButonlar.Controls.Add(this.btnRezervDegistir);
            this.panelSagButonlar.Controls.Add(this.btnSil);
            this.panelSagButonlar.Controls.Add(this.btnKapat);

            // panelSolButonlar (Yeni, Düzenle, Yenile-Listele için)
            this.panelSolButonlar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelSolButonlar.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelSolButonlar.Controls.Add(this.btnEkle);
            this.panelSolButonlar.Controls.Add(this.btnDuzenle);
            this.panelSolButonlar.Controls.Add(this.btnYenile);

            // Buton Stilleri
            System.Drawing.Font btnFont = new System.Drawing.Font("Segoe UI", 9F);

            // btnEkle
            this.btnEkle.Location = new System.Drawing.Point(10, 10);
            this.btnEkle.Size = new System.Drawing.Size(95, 35);
            this.btnEkle.Text = "➕ Yeni";
            this.btnEkle.Font = btnFont;
            this.btnEkle.BackColor = System.Drawing.Color.White;
            this.btnEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEkle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnEkle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // btnDuzenle
            this.btnDuzenle.Location = new System.Drawing.Point(115, 10);
            this.btnDuzenle.Size = new System.Drawing.Size(100, 35);
            this.btnDuzenle.Text = "✏️ Düzenle";
            this.btnDuzenle.Font = btnFont;
            this.btnDuzenle.BackColor = System.Drawing.Color.White;
            this.btnDuzenle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDuzenle.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDuzenle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // btnYenile
            this.btnYenile.Location = new System.Drawing.Point(225, 10);
            this.btnYenile.Size = new System.Drawing.Size(140, 35);
            this.btnYenile.Text = "🔄 Yenile-Listele";
            this.btnYenile.Font = btnFont;
            this.btnYenile.BackColor = System.Drawing.Color.White;
            this.btnYenile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYenile.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnYenile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYenile.Click += new System.EventHandler(this.btnYenile_Click);

            // btnDurumDegistir
            this.btnDurumDegistir.Location = new System.Drawing.Point(5, 10);
            this.btnDurumDegistir.Size = new System.Drawing.Size(140, 35);
            this.btnDurumDegistir.Text = "♼ Durum Değiştir";
            this.btnDurumDegistir.Font = btnFont;
            this.btnDurumDegistir.BackColor = System.Drawing.Color.White;
            this.btnDurumDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDurumDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnDurumDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDurumDegistir.Click += new System.EventHandler(this.btnDurumDegistir_Click);

            // btnRezervDegistir
            this.btnRezervDegistir.Location = new System.Drawing.Point(155, 10);
            this.btnRezervDegistir.Size = new System.Drawing.Size(145, 35);
            this.btnRezervDegistir.Text = "📝 Rezerve Değiştir";
            this.btnRezervDegistir.Font = btnFont;
            this.btnRezervDegistir.BackColor = System.Drawing.Color.White;
            this.btnRezervDegistir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRezervDegistir.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnRezervDegistir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervDegistir.Click += new System.EventHandler(this.btnRezervDegistir_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(310, 10);
            this.btnSil.Size = new System.Drawing.Size(90, 35);
            this.btnSil.Text = "🗑 Sil";
            this.btnSil.Font = btnFont;
            this.btnSil.BackColor = System.Drawing.Color.White;
            this.btnSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSil.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnSil.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // btnKapat 
            this.btnKapat.Location = new System.Drawing.Point(410, 10); 
            this.btnKapat.Size = new System.Drawing.Size(90, 35);
            this.btnKapat.Text = "❌ Kapat";
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.BackColor = System.Drawing.Color.FromArgb(220, 53, 69);
            this.btnKapat.ForeColor = System.Drawing.Color.White;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.FlatAppearance.BorderSize = 0;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // MasalarControl
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGroupBar);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.panelAltDusuk);
            this.Name = "MasalarControl";
            this.Size = new System.Drawing.Size(1100, 600);

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
        
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnYenile;
        private System.Windows.Forms.Button btnDurumDegistir;
        private System.Windows.Forms.Button btnRezervDegistir;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnKapat;
    }
}
