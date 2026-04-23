using System;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class YeniPaketSiparisiForm : Form
    {
        public string MusteriAdi { get; private set; }
        public string Telefon { get; private set; }
        public string Adres { get; private set; }
        public decimal Tutar { get; private set; }
        
        public YeniPaketSiparisiForm()
        {
            InitializeComponent();
        }

        private void YeniPaketSiparisiForm_Load(object sender, EventArgs e)
        {
            // Set some initial view structure
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMusteriAdi.Text) || !txtTelefon.MaskCompleted || string.IsNullOrWhiteSpace(txtAdres.Text) || string.IsNullOrWhiteSpace(txtSiparisNotu.Text))
            {
                MessageBox.Show("Lütfen Müşteri, Telefon, Adres ve Sipariş İçeriği alanlarını doldurunuz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtTutar.Text, out decimal tutar))
            {
                MessageBox.Show("Lütfen geçerli bir Tutar (örn: 150,50) giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            MusteriAdi = txtMusteriAdi.Text;
            Telefon = txtTelefon.Text;
            Adres = txtAdres.Text;
            Tutar = tutar;

            MessageBox.Show("Yeni paket siparişi başarıyla oluşturuldu.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
