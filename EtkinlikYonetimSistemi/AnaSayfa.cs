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
        public AnaSayfa(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            UpdateUserInfo();
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
