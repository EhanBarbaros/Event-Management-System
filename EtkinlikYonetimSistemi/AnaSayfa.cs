using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();

            foreach (var etkinlik in etkinlikler)
            {
                var etkinlikPanel = CreateEtkinlikPanel(etkinlik);
                flowLayoutPanel1.Controls.Add(etkinlikPanel);
            }
        }

        private Panel CreateEtkinlikPanel(Etkinlik etkinlik)
        {
            var panel = new Panel
            {
                Size = new Size(350, 400),
                BorderStyle = BorderStyle.FixedSingle,
                Margin = new Padding(15),
                BackColor = Color.LightBlue
            };

            var lblEtkinlikAdi = new Label
            {
                Text = etkinlik.EtkinlikAdi,
                Font = new Font("Arial", 14, FontStyle.Bold),
                Dock = DockStyle.Top,
                TextAlign = ContentAlignment.MiddleCenter
            };

            var picEtkinlik = new PictureBox
            {
                Size = new Size(330, 200),
                Image = etkinlik.Resim != null ? ByteArrayToImage(etkinlik.Resim) : null,
                SizeMode = PictureBoxSizeMode.StretchImage,
                Dock = DockStyle.Top,
                Margin = new Padding(10)
            };

            var lblEtkinlikBilgi = new Label
            {
                Text = $"Fiyat: {etkinlik.Fiyat}\nTarih: {etkinlik.EtkinlikTarihi.ToShortDateString()}\nYeri: {etkinlik.EtkinlikYeri}",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleLeft
            };

            panel.Controls.Add(lblEtkinlikBilgi);
            panel.Controls.Add(picEtkinlik);
            panel.Controls.Add(lblEtkinlikAdi);

            return panel;
        }


        private void UpdateProfilePicturePosition()
        {
            lbl_kullaniciAdi.AutoSize = true;
            int labelWidth = lbl_kullaniciAdi.Width;
            int pictureBoxHeight = pictureBox1.Height;
            lbl_kullaniciAdi.Location = new Point(panel1.Width - labelWidth - pictureBox1.Width - 20, 20);
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
            etkinlikOlusturForm.ShowDialog();
        }
        private void EtkinlikOlusturForm_FormClosing(object sender, FormClosedEventArgs e)
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
    }
}
