using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikDetayUserControl : UserControl
    {
        private Etkinlik _etkinlik;

        public EtkinlikDetayUserControl(Etkinlik etkinlik)
        {
            InitializeComponent();
            _etkinlik = etkinlik;
            LoadEtkinlikDetay();
        }
        private void LoadEtkinlikDetay()
        {
            lblEtkinlikAdi.Text = $"Etkinkik Adı: {_etkinlik.EtkinlikAdi}";
            lblFiyat.Text = _etkinlik.Fiyat == "0" ? "Fiyat: Ücretsiz" : $"Fiyat: {_etkinlik.Fiyat} TL";
            lblEtkinlikTuru.Text = $"Etkinlik Türü: {_etkinlik.EtkinlikTuru}";
            lblToplamKontejan.Text = $"Kontenjan: {_etkinlik.ToplamKontejan.ToString()}";
            lblMevcutKontejan.Text = $"Mevcut Katılımcı: {_etkinlik.MevcutKontejan.ToString()}";
            lblEtkinlikTarihi.Text = $"Etkinlik Tarihi: {_etkinlik.EtkinlikTarihi.ToShortDateString()}";
            lblEtkinlikYeri.Text = $"Etkinlik Adresi: {_etkinlik.EtkinlikYeri}";
            lblAciklama.Text = $"Açıklama: {_etkinlik.Aciklama}";

            if (_etkinlik.Resim != null)
            {
                pictureBoxResim.Image = ByteArrayToImage(_etkinlik.Resim);
                pictureBoxResim.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnBilgiGuncelle_Click_1(object sender, EventArgs e)
        {
            EtkinlikGuncelleUserControl etkinlikGuncelleUC = new EtkinlikGuncelleUserControl(_etkinlik);
            Form guncelleForm = new Form
            {
                Size = new Size(400, 700),
                Text = "Etkinlik Güncelle"
            };
            guncelleForm.Controls.Add(etkinlikGuncelleUC);
            etkinlikGuncelleUC.Dock = DockStyle.Fill;
            guncelleForm.Show();
            this.ParentForm?.Close();
        }
    }
}
