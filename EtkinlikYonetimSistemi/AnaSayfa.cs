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

        public void LoadEtkinlikler()
        {
            flowLayoutPanel1.Controls.Clear();
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();

            foreach (var etkinlik in etkinlikler)
            {
                EtkinlikKarti etkinlikKarti = new EtkinlikKarti();
                etkinlikKarti.SetEtkinlikBilgileri(etkinlik.EtkinlikAdi, etkinlik.Fiyat, etkinlik.ToplamKontejan.ToString(), etkinlik.MevcutKontejan.ToString(), etkinlik.EtkinlikTuru, etkinlik.Resim);
                etkinlikKarti.EtkinlikKartiClicked += (sender, e) => ShowEtkinlikKatilim(etkinlik);
                flowLayoutPanel1.Controls.Add(etkinlikKarti);
            }
        }

        private void ShowEtkinlikKatilim(Etkinlik etkinlik)
        {
            EtkinlikKatilimUserControl etkinlikKatilimUserControl = new EtkinlikKatilimUserControl(etkinlik, _kullanici,this);
            Form detayForm = new Form
            {
                Size = new Size(800, 600),
                Text = "Etkinlik Detayları"
            };
            detayForm.Controls.Add(etkinlikKatilimUserControl);
            etkinlikKatilimUserControl.Dock = DockStyle.Fill;
            detayForm.ShowDialog();
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
            form_ilk girisYapForm = new form_ilk();
            girisYapForm.Show();
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

        public void UpdateUserInfo()
        {
            lbl_kullaniciAdi.Text = _kullanici.KullaniciAdi;
            lblBakiye.Text = $"Bakiye: {_kullanici.Bakiye:C} TL"; 
            if (_kullanici.ProfilFotografi != null && _kullanici.ProfilFotografi.Length > 0)
            {
                pictureBox1.Image = ByteArrayToImage(_kullanici.ProfilFotografi);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnBakiyeEkle_Click(object sender, EventArgs e)
        {
            Form bakiyeEkleForm = new Form
            {
                Text = "Bakiye Ekle",
                Size = new Size(250, 150),
                StartPosition = FormStartPosition.CenterParent,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                MaximizeBox = false,
                MinimizeBox = false
            };

            Label lblMiktar = new Label
            {
                Text = "Miktar:",
                Location = new Point(10, 20),
                AutoSize = true
            };

            TextBox txtMiktar = new TextBox
            {
                Location = new Point(60, 20),
                Width = 150
            };

            Button btnEkle = new Button
            {
                Text = "Ekle",
                Location = new Point(60, 60),
                Width = 150
            };

            btnEkle.Click += (s, args) =>
            {
                try
                {
                    decimal miktar = Convert.ToDecimal(txtMiktar.Text);

                    if (_kullanici.Bakiye + miktar > 1000)
                    {
                        MessageBox.Show("Toplam bakiye 1000 TL'yi aşamaz.");
                        return;
                    }

                    _kullanici.Bakiye += miktar;
                    var kullaniciBL = new KullaniciBL();
                    if (kullaniciBL.KullaniciGuncelle(_kullanici))
                    {
                        MessageBox.Show("Bakiye başarıyla eklendi.");
                        UpdateUserInfo();
                        bakiyeEkleForm.Close();
                    }
                    else
                    {
                        MessageBox.Show("Bakiye ekleme başarısız.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Bir hata oluştu: " + ex.Message);
                }
            };

            bakiyeEkleForm.Controls.Add(lblMiktar);
            bakiyeEkleForm.Controls.Add(txtMiktar);
            bakiyeEkleForm.Controls.Add(btnEkle);

            bakiyeEkleForm.ShowDialog();
        }

        private void btn_Etkinliklerim_Click_1(object sender, EventArgs e)
        {
            LoadUserEtkinlikler();
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
