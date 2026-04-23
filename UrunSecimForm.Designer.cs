namespace CafeOtomasyonu
{
    partial class UrunSecimForm
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
            this.lblBaslik        = new System.Windows.Forms.Label();
            this.panelGroup       = new System.Windows.Forms.Panel();
            this.lblGroupText     = new System.Windows.Forms.Label();
            this.lblSearch        = new System.Windows.Forms.Label();
            this.dataGridView     = new System.Windows.Forms.DataGridView();
            this.panelIslemler    = new System.Windows.Forms.Panel();
            this.lblIslemler      = new System.Windows.Forms.Label();
            this.panelIslemlerSag = new System.Windows.Forms.Panel();
            this.btnSec           = new System.Windows.Forms.Button();
            this.btnKapat         = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelGroup.SuspendLayout();
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
            this.lblBaslik.Text      = "Ürün Seçim Sayfası";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblBaslik.BackColor = System.Drawing.Color.White;

            // =====================================================================
            // panelGroup — "Drag a column header..." çubuğu
            // =====================================================================
            this.panelGroup.Dock      = System.Windows.Forms.DockStyle.Top;
            this.panelGroup.Height    = 24;
            this.panelGroup.Name      = "panelGroup";
            this.panelGroup.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelGroup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;

            this.lblGroupText.AutoSize  = true;
            this.lblGroupText.Font      = new System.Drawing.Font("Segoe UI", 8F);
            this.lblGroupText.ForeColor = System.Drawing.Color.Gray;
            this.lblGroupText.Location  = new System.Drawing.Point(6, 4);
            this.lblGroupText.Name      = "lblGroupText";
            this.lblGroupText.Text      = "Drag a column header here to group by that column";

            this.lblSearch.AutoSize  = false;
            this.lblSearch.Dock      = System.Windows.Forms.DockStyle.Right;
            this.lblSearch.Width     = 24;
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
            this.dataGridView.Dock               = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.BackgroundColor    = System.Drawing.Color.White;
            this.dataGridView.BorderStyle        = System.Windows.Forms.BorderStyle.None;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Name               = "dataGridView";
            this.dataGridView.GridColor          = System.Drawing.Color.LightGray;
            this.dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.DefaultCellStyle.Font              = new System.Drawing.Font("Segoe UI", 9F);
            this.dataGridView.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(248, 248, 248);
            this.dataGridView.AllowUserToAddRows  = false;
            this.dataGridView.RowHeadersVisible   = true;
            this.dataGridView.RowHeadersWidth     = 18;
            this.dataGridView.SelectionMode       = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.None;
            this.dataGridView.MultiSelect         = false;
            this.dataGridView.EnableHeadersVisualStyles = true;

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

            // panelIslemlerSag
            this.panelIslemlerSag.BackColor = System.Drawing.Color.Transparent;
            this.panelIslemlerSag.Dock      = System.Windows.Forms.DockStyle.Right;
            this.panelIslemlerSag.Width     = 210;
            this.panelIslemlerSag.Name      = "panelIslemlerSag";

            // btnSec (yeşil tik)
            this.btnSec.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnSec.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSec.FlatAppearance.BorderSize = 0;
            this.btnSec.Font      = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSec.ForeColor = System.Drawing.Color.White;
            this.btnSec.Location  = new System.Drawing.Point(5, 11);
            this.btnSec.Name      = "btnSec";
            this.btnSec.Size      = new System.Drawing.Size(90, 28);
            this.btnSec.Text      = "✔  Seç";
            this.btnSec.Cursor    = System.Windows.Forms.Cursors.Hand;
            this.btnSec.Click    += new System.EventHandler(this.btnSec_Click);

            // btnKapat (kırmızı X)
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
                this.btnSec, this.btnKapat
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
            this.ClientSize          = new System.Drawing.Size(1000, 600);
            this.StartPosition       = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Name                = "UrunSecimForm";
            this.Text                = "Ürün Seçim Sayfası";

            // Kontroller (Fill en sona)
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelGroup);
            this.Controls.Add(this.panelIslemler);
            this.Controls.Add(this.lblBaslik);

            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelGroup.ResumeLayout(false);
            this.panelGroup.PerformLayout();
            this.panelIslemler.ResumeLayout(false);
            this.panelIslemler.PerformLayout();
            this.panelIslemlerSag.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label     lblBaslik;
        private System.Windows.Forms.Panel     panelGroup;
        private System.Windows.Forms.Label     lblGroupText;
        private System.Windows.Forms.Label     lblSearch;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel     panelIslemler;
        private System.Windows.Forms.Label     lblIslemler;
        private System.Windows.Forms.Panel     panelIslemlerSag;
        private System.Windows.Forms.Button    btnSec;
        private System.Windows.Forms.Button    btnKapat;
    }
}
