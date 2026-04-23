using System;
using System.Windows.Forms;

namespace CafeOtomasyonu
{
    public partial class AyarlarControl : UserControl
    {
        public AyarlarControl()
        {
            InitializeComponent();
        }

        private void AyarlarControl_Load(object sender, EventArgs e)
        {
            if (cmbYazici.Items.Count > 0)
                cmbYazici.SelectedIndex = 0;
            
            // Başlangıçta zamanı yazdır
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
            
            // Timer'ı başlat
            timerTarihSaat.Interval = 1000;
            timerTarihSaat.Tick += TimerTarihSaat_Tick;
            timerTarihSaat.Start();
        }

        private void TimerTarihSaat_Tick(object sender, EventArgs e)
        {
            lblTarihSaat.Text = DateTime.Now.ToString("dd.MM.yyyy HH:mm:ss");
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            // Kaydetme işlemleri...
            MessageBox.Show("Ayarlar başarıyla kaydedildi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            if (this.Parent is DevExpress.XtraTab.XtraTabPage tab)
            {
                if (tab.Parent is DevExpress.XtraTab.XtraTabControl tabControl)
                {
                    tabControl.TabPages.Remove(tab);
                }
            }
        }
    }
}
