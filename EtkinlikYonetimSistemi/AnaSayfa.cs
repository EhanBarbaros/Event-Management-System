using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class AnaSayfa : Form
    {
        private Kullanici _kullanici;
        private EtkinlikBL _etkinlikBL;

        public AnaSayfa(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _etkinlikBL = new EtkinlikBL();
            LoadEtkinlikler();
            UpdateUserInfo();
            UpdateProfilePicturePosition();
        }

        private void LoadEtkinlikler()
        {
            flowLayoutPanel1.Controls.Clear();
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();

            foreach (var etkinlik in etkinlikler)
            {
                EtkinlikKarti etkinlikKarti = new EtkinlikKarti();
                etkinlikKarti.SetEtkinlikBilgileri(etkinlik.EtkinlikAdi, etkinlik.Fiyat, etkinlik.ToplamKontejan.ToString(), etkinlik.MevcutKontejan.ToString(), etkinlik.EtkinlikTuru, etkinlik.Resim);
                flowLayoutPanel1.Controls.Add(etkinlikKarti);
            }
        }

        private void ShowEtkinlikDetay(Etkinlik etkinlik)
        {
            EtkinlikDetayUserControl etkinlikDetayUC = new EtkinlikDetayUserControl(etkinlik);
            Form detayForm = new Form
            {
                Size = new Size(800, 600),
                Text = "Etkinlik Detayları"
            };
            detayForm.Controls.Add(etkinlikDetayUC);
            etkinlikDetayUC.Dock = DockStyle.Fill;
            detayForm.ShowDialog();
        }

        private void UpdateProfilePicturePosition()
        {
            lbl_kullaniciAdi.AutoSize = true;
            int labelWidth = lbl_kullaniciAdi.Width;
            int pictureBoxHeight = pictureBox1.Height;

            lbl_kullaniciAdi.Location = new Point(panel1.Width - labelWidth - pictureBox1.Width - 20, 30); 
            pictureBox1.Location = new Point(lbl_kullaniciAdi.Left - pictureBox1.Width - 5, lbl_kullaniciAdi.Top + (lbl_kullaniciAdi.Height - pictureBoxHeight) / 2);
        }


        private void lbl_kullaniciAdi_Click(object sender, EventArgs e)
        {
            profilMenu.Show(lbl_kullaniciAdi, new Point(0, lbl_kullaniciAdi.Height));
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_kullanici);
            profil.ShowDialog();
        }

        private void btnProfilAyarları_Click(object sender, EventArgs e)
        {
            Profil profil = new Profil(_kullanici);
            if (profil.ShowDialog() == DialogResult.OK)
            {
                UpdateUserInfo();
            }
        }

        private void btnCikisYap_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_EtkinlikOlustur_Click(object sender, EventArgs e)
        {
            EtkinlikOlustur etkinlikOlusturForm = new EtkinlikOlustur(_kullanici);
            etkinlikOlusturForm.FormClosed += EtkinlikOlusturForm_FormClosed;
            etkinlikOlusturForm.ShowDialog();
        }

        private void EtkinlikOlusturForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadEtkinlikler();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }

        private void UpdateUserInfo()
        {
            lbl_kullaniciAdi.Text = _kullanici.KullaniciAdi;
            if (_kullanici.ProfilFotografi != null && _kullanici.ProfilFotografi.Length > 0)
            {
                pictureBox1.Image = ByteArrayToImage(_kullanici.ProfilFotografi);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btn_Etkinliklerim_Click_1(object sender, EventArgs e)
        {
            LoadUserEtkinlikler();
        }

        private void LoadUserEtkinlikler()
        {
            flowLayoutPanel1.Controls.Clear();
            var etkinlikler = _etkinlikBL.KullaniciEtkinlikleriGetir((int)_kullanici.Kullaniciid);

            foreach (var etkinlik in etkinlikler)
            {
                EtkinlikKarti etkinlikKarti = new EtkinlikKarti();
                etkinlikKarti.SetEtkinlikBilgileri(etkinlik.EtkinlikAdi, etkinlik.Fiyat, etkinlik.ToplamKontejan.ToString(), etkinlik.MevcutKontejan.ToString(), etkinlik.EtkinlikTuru, etkinlik.Resim);
                etkinlikKarti.EtkinlikKartiClicked += (sender, e) => ShowEtkinlikDetay(etkinlik);
                flowLayoutPanel1.Controls.Add(etkinlikKarti);
            }
        }

        private void buttonAnaSayfa_Click(object sender, EventArgs e)
        {
            LoadEtkinlikler();
        }

        private void buttonHakkimizda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hakkımızda bilgiler burada yer alacaktır.", "Hakkımızda");
        }

        private void lblBakiye_Click(object sender, EventArgs e)
        {

        }
    }
}