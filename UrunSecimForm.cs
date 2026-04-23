using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    /// <summary>
    /// Ürün listesini gösterir; kullanıcı bir satır seçip "Seç" butonuna basınca
    /// SecilenUrun özelliği dolu olarak form kapanır.
    /// </summary>
    public partial class UrunSecimForm : Form
    {
        // Seçilen satır — dışarıdan okunur
        public DataRowView SecilenUrun { get; private set; }

        private DataTable _urunTablosu;

        public UrunSecimForm()
        {
            InitializeComponent();
            UrunTablosunuKur();
            OrnekUrunleriYukle();
        }

        // =========================================================
        // TABLO KURULUMU
        // =========================================================
        private void UrunTablosunuKur()
        {
            _urunTablosu = new DataTable();
            _urunTablosu.Columns.Add("Id",           typeof(int));
            _urunTablosu.Columns.Add("Menü",         typeof(string));
            _urunTablosu.Columns.Add("Ürün Kodu",    typeof(string));
            _urunTablosu.Columns.Add("Ürün Adı",     typeof(string));
            _urunTablosu.Columns.Add("Birim Fiyatı1", typeof(decimal));
            _urunTablosu.Columns.Add("Birim Fiyatı2", typeof(decimal));
            _urunTablosu.Columns.Add("Birim Fiyatı3", typeof(decimal));
            _urunTablosu.Columns.Add("Açıklama",     typeof(string));
            _urunTablosu.Columns.Add("Tarih",        typeof(string));

            dataGridView.DataSource = _urunTablosu;

            // Sütun genişlikleri
            if (dataGridView.Columns.Count >= 9)
            {
                dataGridView.Columns[0].Width = 40;   // Id
                dataGridView.Columns[1].Width = 120;  // Menü
                dataGridView.Columns[2].Width = 85;   // Ürün Kodu
                dataGridView.Columns[3].Width = 120;  // Ürün Adı
                dataGridView.Columns[4].Width = 90;   // Birim Fiyatı1
                dataGridView.Columns[5].Width = 90;   // Birim Fiyatı2
                dataGridView.Columns[6].Width = 90;   // Birim Fiyatı3
                dataGridView.Columns[7].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Açıklama
                dataGridView.Columns[8].Width = 90;   // Tarih
            }
        }

        // Fotoğraftaki örnek veriler
        private void OrnekUrunleriYukle()
        {
            _urunTablosu.Rows.Add(1, "Sıcak İçecekler", "001", "Çay",          2.75m, 2.50m, 2.25m, "Çay Açıklama",      "27.10.2021");
            _urunTablosu.Rows.Add(2, "Soğuk İçecekler", "002", "Coca Cola kutu", 7.75m, 7.25m, 7.00m, "",                "27.10.2021");
            _urunTablosu.Rows.Add(3, "Sıcak İçecekler", "003", "Kuşburnu",     3.25m, 3.50m, 3.75m, "Kuşburnu açıklama", "29.10.2021");
            _urunTablosu.Rows.Add(4, "Sıcak İçecekler", "004", "Cappucino",    5.75m, 6.25m, 6.50m, "Test",              "30.10.2021");
        }

        // =========================================================
        // BUTONLAR
        // =========================================================
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentRow == null || dataGridView.CurrentRow.IsNewRow)
            {
                MessageBox.Show("Lütfen bir ürün seçiniz.", "Uyarı",
                                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SecilenUrun = (DataRowView)dataGridView.CurrentRow.DataBoundItem;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
