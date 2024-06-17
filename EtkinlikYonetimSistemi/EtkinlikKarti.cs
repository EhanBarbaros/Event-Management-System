using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikKarti : UserControl
    {
        public EtkinlikKarti()
        {
            InitializeComponent();
        }

        public void SetEtkinlikBilgileri(string etkinlikAdi, string fiyat, string kontejan, string mevcutKatılımcı, string etkinlikTuru, byte[] resim)
        {
            lblEtkinlikAdi.Text = etkinlikAdi;
            lblFiyat.Text = fiyat == "0" ? "Ücretsiz" : $"Fiyat: {fiyat} TL";
            lblKontejan.Text = $"Kontejan: {kontejan}";
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
