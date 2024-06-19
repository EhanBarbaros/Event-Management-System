using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikKatilimUserControl : UserControl
    {
        private Etkinlik _etkinlik;
        private Kullanici _kullanici;
        private AnaSayfa _anaSayfa;

        public EtkinlikKatilimUserControl(Etkinlik etkinlik, Kullanici kullanici, AnaSayfa anaSayfa)
        {
            InitializeComponent();
            _etkinlik = etkinlik;
            _kullanici = kullanici;
            _anaSayfa = anaSayfa;
            LoadEtkinlikBilgileri();
        }

        private void LoadEtkinlikBilgileri()
        {
            lblEtkinlikAdi.Text = _etkinlik.EtkinlikAdi;
            lblFiyat.Text = _etkinlik.Fiyat == "0" ? "Ücretsiz" : $"Fiyat: {_etkinlik.Fiyat} TL";
            lblKontejan.Text = $"Kontenjan: {_etkinlik.ToplamKontejan}";
            lblMevcutKatılımcı.Text = $"Mevcut Katılımcı: {_etkinlik.MevcutKontejan}";
            lblEtkinlikTuru.Text = _etkinlik.EtkinlikTuru;
            lblAciklama.Text = _etkinlik.Aciklama;

            if (_etkinlik.Resim != null && _etkinlik.Resim.Length > 0)
            {
                pictureBox1.Image = ByteArrayToImage(_etkinlik.Resim);
            }

            if (_etkinlik.MevcutKontejan >= _etkinlik.ToplamKontejan)
            {
                btnYerAyirt.Enabled = false;
                lblKontenjanDurumu.Text = "Kontenjan bulunmamaktadır";
                lblKontenjanDurumu.ForeColor = Color.Red;
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void btnYerAyirt_Click(object sender, EventArgs e)
        {
            try
            {
                if (_etkinlik.Fiyat == "0")
                {
                    var result = MessageBox.Show("Katılmak istiyor musunuz?", "Ücretsiz Etkinlik", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        KatilimIslemi();
                    }
                }
                else
                {
                    var result = MessageBox.Show($"{_etkinlik.Fiyat} TL ücreti bakiyenizden düşecektir. Onaylıyor musunuz?", "Ücretli Etkinlik", MessageBoxButtons.YesNo);
                    if (result == DialogResult.Yes)
                    {
                        decimal etkinlikFiyati;
                        if (decimal.TryParse(_etkinlik.Fiyat, out etkinlikFiyati))
                        {
                            if (_kullanici.Bakiye >= etkinlikFiyati)
                            {
                                KatilimIslemi();
                            }
                            else
                            {
                                MessageBox.Show("Yetersiz bakiye.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Geçersiz etkinlik fiyatı.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void KatilimIslemi()
        {
            var etkinlikBL = new EtkinlikBL();
            if (etkinlikBL.EtkinligeKatilimEkle(_etkinlik, _kullanici))
            {
                MessageBox.Show("Etkinliğe başarıyla katıldınız.");
                _etkinlik.MevcutKontejan++;
                LoadEtkinlikBilgileri();
                _anaSayfa.UpdateUserInfo();
                _anaSayfa.LoadEtkinlikler();
            }
            else
            {
                MessageBox.Show("Etkinliğe katılım başarısız.");
            }
        }
    }
}
