namespace CafeOtomasyonu
{
    partial class PaketDurumDegistirForm
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
            this.panelAltDusuk = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnKapat = new System.Windows.Forms.Button();
            
            this.lblSiparisNoB = new System.Windows.Forms.Label();
            this.lblSiparisNo = new System.Windows.Forms.Label();
            
            this.lblDurum = new System.Windows.Forms.Label();
            this.cmbDurum = new System.Windows.Forms.ComboBox();

            this.panelAltDusuk.SuspendLayout();
            this.SuspendLayout();

            // 
            // lblBaslik
            // 
            this.lblBaslik.BackColor = System.Drawing.Color.FromArgb(23, 114, 190);
            this.lblBaslik.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblBaslik.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.ForeColor = System.Drawing.Color.White;
            this.lblBaslik.Location = new System.Drawing.Point(0, 0);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(400, 60);
            this.lblBaslik.Text = "Sipariş Durumu Güncelle";
            this.lblBaslik.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;

            // 
            // panelAltDusuk
            // 
            this.panelAltDusuk.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            this.panelAltDusuk.Controls.Add(this.btnKapat);
            this.panelAltDusuk.Controls.Add(this.btnKaydet);
            this.panelAltDusuk.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelAltDusuk.Location = new System.Drawing.Point(0, 220);
            this.panelAltDusuk.Name = "panelAltDusuk";
            this.panelAltDusuk.Size = new System.Drawing.Size(400, 60);

            // 
            // btnKapat
            // 
            this.btnKapat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKapat.BackColor = System.Drawing.Color.White;
            this.btnKapat.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.btnKapat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKapat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKapat.Location = new System.Drawing.Point(290, 15);
            this.btnKapat.Name = "btnKapat";
            this.btnKapat.Size = new System.Drawing.Size(90, 32);
            this.btnKapat.Text = "❌ İptal";
            this.btnKapat.UseVisualStyleBackColor = false;
            this.btnKapat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKapat.Click += new System.EventHandler(this.btnKapat_Click);

            // 
            // btnKaydet
            // 
            this.btnKaydet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnKaydet.BackColor = System.Drawing.Color.FromArgb(40, 167, 69);
            this.btnKaydet.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(30, 130, 50);
            this.btnKaydet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKaydet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.ForeColor = System.Drawing.Color.White;
            this.btnKaydet.Location = new System.Drawing.Point(160, 15);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 32);
            this.btnKaydet.Text = "💾 Güncelle";
            this.btnKaydet.UseVisualStyleBackColor = false;
            this.btnKaydet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            System.Drawing.Font lblBFont = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            System.Drawing.Font lblNFont = new System.Drawing.Font("Segoe UI", 10F);

            // lblSiparisNoB
            this.lblSiparisNoB.AutoSize = true;
            this.lblSiparisNoB.Font = lblBFont;
            this.lblSiparisNoB.Location = new System.Drawing.Point(40, 90);
            this.lblSiparisNoB.Text = "Sipariş No:";

            // lblSiparisNo
            this.lblSiparisNo.AutoSize = true;
            this.lblSiparisNo.Font = lblBFont;
            this.lblSiparisNo.ForeColor = System.Drawing.Color.FromArgb(23, 114, 190);
            this.lblSiparisNo.Location = new System.Drawing.Point(160, 90);
            this.lblSiparisNo.Text = "PKT-XXX";

            // lblDurum
            this.lblDurum.AutoSize = true;
            this.lblDurum.Font = lblBFont;
            this.lblDurum.Location = new System.Drawing.Point(40, 140);
            this.lblDurum.Text = "Yeni Durum:";

            // cmbDurum
            this.cmbDurum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDurum.Font = lblNFont;
            this.cmbDurum.FormattingEnabled = true;
            this.cmbDurum.Location = new System.Drawing.Point(160, 137);
            this.cmbDurum.Name = "cmbDurum";
            this.cmbDurum.Size = new System.Drawing.Size(200, 25);

            // PaketDurumDegistirForm
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(400, 280);
            
            this.Controls.Add(this.cmbDurum);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblSiparisNo);
            this.Controls.Add(this.lblSiparisNoB);

            this.Controls.Add(this.panelAltDusuk);
            this.Controls.Add(this.lblBaslik);
            
            this.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PaketDurumDegistirForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Sipariş Durumu";
            this.Load += new System.EventHandler(this.PaketDurumDegistirForm_Load);
            
            this.panelAltDusuk.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.Panel panelAltDusuk;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnKapat;
        
        private System.Windows.Forms.Label lblSiparisNoB;
        private System.Windows.Forms.Label lblSiparisNo;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.ComboBox cmbDurum;
    }
}
