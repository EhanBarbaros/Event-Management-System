using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class ProfilAyarlari : Form
    {
        private Kullanici _kullanici;

        public ProfilAyarlari(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            LoadUserDetails();
        }

        private void LoadUserDetails()
        {
            txtAd.Text = _kullanici.Ad;
            txtSoyad.Text = _kullanici.Soyad;
            txtEmail.Text = _kullanici.Email;
            txtTelefon.Text = _kullanici.Telefon;
            txtAdres.Text = _kullanici.Adres;
            txtDTarihi.Text = _kullanici.DTarihi;
            txtCinsiyet.Text = _kullanici.Cinsiyet;
            txtKullaniciAdi.Text = _kullanici.KullaniciAdi;
            txtSifre.Text = _kullanici.Sifre;
            if (!string.IsNullOrEmpty(_kullanici.ProfilFotografi))
            {
                pictureBoxProfil.ImageLocation = _kullanici.ProfilFotografi;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Kullanıcı bilgilerini güncelleme işlemleri
            _kullanici.Ad = txtAd.Text;
            _kullanici.Soyad = txtSoyad.Text;
            _kullanici.Email = txtEmail.Text;
            _kullanici.Telefon = txtTelefon.Text;
            _kullanici.Adres = txtAdres.Text;
            _kullanici.DTarihi = txtDTarihi.Text;
            _kullanici.Cinsiyet = txtCinsiyet.Text;
            _kullanici.KullaniciAdi = txtKullaniciAdi.Text;
            _kullanici.Sifre = txtSifre.Text;

            // Profil fotoğrafı güncelleme
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _kullanici.ProfilFotografi = openFileDialog1.FileName;
                pictureBoxProfil.ImageLocation = _kullanici.ProfilFotografi;
            }

            // Veritabanına güncellemeleri kaydetme
            // KullaniciBL bl = new KullaniciBL();
            // bl.KullaniciGuncelle(_kullanici);

            MessageBox.Show("Profil başarıyla güncellendi.");
        }

        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                _kullanici.ProfilFotografi = openFileDialog1.FileName;
                pictureBoxProfil.ImageLocation = _kullanici.ProfilFotografi;
            }
        }
    }
}
