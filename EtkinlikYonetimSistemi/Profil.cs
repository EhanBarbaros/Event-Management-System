using EtkinlikYS.Model;
using EtkinlikYS.BLL;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class Profil : Form
    {
        private Kullanici _kullanici;
        private KullaniciBL _kullaniciBL;
        private Kullanici _currentUser;

        public Profil(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _kullaniciBL = new KullaniciBL();
            ProfilBilgileriniYukle();
            StartPosition = FormStartPosition.CenterParent;
        }

        public Profil(Kullanici kullanici, Kullanici currentUser) : this(kullanici)
        {
            _currentUser = currentUser;
            if (currentUser.Yetki == "kurucu")
            {
                InitializeAdminButtons();
                ConfigureAdminButtons();
            }
            // Profili Düzenle, Resim Yükle ve Resim Kaydet butonlarını gizle
            btnDuzenle.Visible = false;
            btnResimYukle.Visible = false;
            btnResimKaydet.Visible = false;
        }

        private void InitializeAdminButtons()
        {
            btnSil.Visible = true;
            btnYetki.Visible = true;
        }

        private void ConfigureAdminButtons()
        {
            if (_kullanici.Yetki == "admin")
            {
                btnYetki.Text = "Yetkiyi Kaldır";
                btnYetki.Click += BtnYetkiKaldir_Click;
            }
            else
            {
                btnYetki.Text = "Yetkilendir";
                btnYetki.Click += BtnYetkilendir_Click;
            }
        }

        private void ProfilBilgileriniYukle()
        {
            lblAd.Text = "Ad: " + _kullanici.Ad;
            lblSoyad.Text = "Soyad: " + _kullanici.Soyad;
            lblEmail.Text = "Email: " + _kullanici.Email;
            lblTelefon.Text = "Telefon: " + _kullanici.Telefon;
            lblAdres.Text = "Adres: " + _kullanici.Adres;
            lblDTarihi.Text = "Doğum Tarihi: " + _kullanici.DTarihi;
            lblCinsiyet.Text = "Cinsiyet: " + _kullanici.Cinsiyet;

            if (_kullanici.ProfilFotografi != null && _kullanici.ProfilFotografi.Length > 0)
            {
                pictureBoxProfil.Image = ByteArrayToImage(_kullanici.ProfilFotografi);
                pictureBoxProfil.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            ProfilDuzenle profilDuzenleForm = new ProfilDuzenle(_kullanici);
            profilDuzenleForm.ShowDialog();
            ProfilBilgileriniYukle();
        }

        private void btnResimYukle_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pictureBoxProfil.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void btnResimKaydet_Click(object sender, EventArgs e)
        {
            if (pictureBoxProfil.Image != null)
            {
                _kullanici.ProfilFotografi = ImageToByteArray(pictureBoxProfil.Image);
                if (_kullaniciBL.KullaniciGuncelle(_kullanici))
                {
                    MessageBox.Show("Profil fotoğrafı başarıyla güncellendi.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Profil güncelleme sırasında bir hata oluştu.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen bir resim yükleyin.");
            }
        }

        private byte[] ImageToByteArray(Image image)
        {
            using (var ms = new MemoryStream())
            {
                image.Save(ms, image.RawFormat);
                return ms.ToArray();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void BtnSil_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Kullanıcıyı silmek istediğinizden emin misiniz?", "Kullanıcı Sil", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (_kullaniciBL.KullaniciSil((int)_kullanici.Kullaniciid))
                {
                    MessageBox.Show("Kullanıcı silindi.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kullanıcı silme sırasında bir hata oluştu.");
                }
            }
        }

        private void BtnYetkiKaldir_Click(object sender, EventArgs e)
        {
            if (_kullaniciBL.KullaniciYetkiGuncelle((int)_kullanici.Kullaniciid, "user"))
            {
                MessageBox.Show("Yetki kaldırıldı.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Yetki kaldırma sırasında bir hata oluştu.");
            }
        }

        private void BtnYetkilendir_Click(object sender, EventArgs e)
        {
            if (_kullaniciBL.KullaniciYetkiGuncelle((int)_kullanici.Kullaniciid, "admin"))
            {
                MessageBox.Show("Kullanıcı yetkilendirildi.");
                this.Close();
            }
            else
            {
                MessageBox.Show("Yetkilendirme sırasında bir hata oluştu.");
            }
        }
    }
}
