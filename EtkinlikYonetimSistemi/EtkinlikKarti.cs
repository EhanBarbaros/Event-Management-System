using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikKarti : UserControl
    {
        public event EventHandler EtkinlikKartiClicked;
        public EtkinlikKarti()
        {
            InitializeComponent();
            RegisterClickEvents(this);

        }
        private void RegisterClickEvents(Control control)
        {
            control.Click += OnEtkinlikKartiClicked;
            foreach (Control childControl in control.Controls)
            {
                RegisterClickEvents(childControl);
            }
        }
        private void OnEtkinlikKartiClicked(object sender, EventArgs e)
        {
            EtkinlikKartiClicked?.Invoke(this, e);
        }

        public void SetEtkinlikBilgileri(string etkinlikAdi, string fiyat, string kontejan, string mevcutKatılımcı, string etkinlikTuru, byte[] resim)
        {
            lblEtkinlikAdi.Text = etkinlikAdi;
            lblFiyat.Text = fiyat == "0" ? "Ücretsiz" : $"Fiyat: {fiyat} TL";
            lblKontejan.Text = $"Kontenjan: {kontejan}";
            lblMevcutKatılımcı.Text = $"Mevcut: {mevcutKatılımcı}";
            lblEtkinlikTuru.Text = etkinlikTuru;

            if (resim != null && resim.Length > 0)
            {
                pictureBox1.Image = ByteArrayToImage(resim);
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
