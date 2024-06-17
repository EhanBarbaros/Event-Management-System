using EtkinlikYS.Model;
using System;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class ProfilDuzenle : Form
    {
        private Kullanici _kullanici;

        public ProfilDuzenle(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            LoadUserData();
        }

        private void LoadUserData()
        {
            txtAd.Text = _kullanici.Ad;
            txtSoyad.Text = _kullanici.Soyad;
            txtEmail.Text = _kullanici.Email;
            txtTelefon.Text = _kullanici.Telefon;
            txtAdres.Text = _kullanici.Adres;
            txtDTarihi.Text = _kullanici.DTarihi;
            txtCinsiyet.Text = _kullanici.Cinsiyet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtEskiSifre.Text == _kullanici.Sifre)
            {
                if (txtYeniSifre.Text == txtYeniSifreTekrar.Text)
                {
                    _kullanici.Sifre = txtYeniSifre.Text;
                    MessageBox.Show("Şifre başarıyla güncellendi.");
                }
                else
                {
                    MessageBox.Show("Yeni şifreler eşleşmiyor.");
                }
            }
            else
            {
                MessageBox.Show("Eski şifre yanlış.");
            }

            _kullanici.Ad = txtAd.Text;
            _kullanici.Soyad = txtSoyad.Text;
            _kullanici.Email = txtEmail.Text;
            _kullanici.Telefon = txtTelefon.Text;
            _kullanici.Adres = txtAdres.Text;
            _kullanici.DTarihi = txtDTarihi.Text;
            _kullanici.Cinsiyet = txtCinsiyet.Text;

            this.Close();
        }
    }
}
