using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikGuncelleUserControl : UserControl
    {
        private Etkinlik _etkinlik;
        private EtkinlikBL _etkinlikBL;

        public EtkinlikGuncelleUserControl(Etkinlik etkinlik)
        {
            InitializeComponent();
            _etkinlik = etkinlik;
            _etkinlikBL = new EtkinlikBL();
            LoadEtkinlikBilgileri();
        }

        private void LoadEtkinlikBilgileri()
        {
            txtEtkinlikAdi.Text = _etkinlik.EtkinlikAdi;
            txtFiyat.Text = _etkinlik.Fiyat;
            txtEtkinlikTuru.Text = _etkinlik.EtkinlikTuru;
            txtToplamKontejan.Text = _etkinlik.ToplamKontejan.ToString();
            dtpEtkinlikTarihi.Value = _etkinlik.EtkinlikTarihi;
            txtEtkinlikYeri.Text = _etkinlik.EtkinlikYeri;
            txtAciklama.Text = _etkinlik.Aciklama;

            if (_etkinlik.Resim != null)
            {
                pictureBoxResim.Image = ByteArrayToImage(_etkinlik.Resim);
                pictureBoxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                pictureBoxResim.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBoxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            _etkinlik.EtkinlikAdi = txtEtkinlikAdi.Text;
            _etkinlik.Fiyat = txtFiyat.Text;
            _etkinlik.EtkinlikTuru = txtEtkinlikTuru.Text;
            _etkinlik.ToplamKontejan = int.Parse(txtToplamKontejan.Text);
            _etkinlik.EtkinlikTarihi = dtpEtkinlikTarihi.Value;
            _etkinlik.EtkinlikYeri = txtEtkinlikYeri.Text;
            _etkinlik.Aciklama = txtAciklama.Text;

            if (pictureBoxResim.Image != null)
            {
                _etkinlik.Resim = ImageToByteArray(pictureBoxResim.Image);
            }

            if (_etkinlikBL.EtkinlikGuncelle(_etkinlik))
            {
                MessageBox.Show("Etkinlik bilgileri başarıyla güncellendi.");
            }
            else
            {
                MessageBox.Show("Etkinlik bilgileri güncellenirken bir hata oluştu.");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new System.IO.MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
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
