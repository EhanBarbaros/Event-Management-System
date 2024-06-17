using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using EtkinlikYS.BLL;
using EtkinlikYS.Model;

namespace EtkinlikYonetimSistemi
{
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }

        private void link_lbl_GirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
        }

        public byte[] GetDefaultProfileImage()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            using (Stream stream = assembly.GetManifestResourceStream("EtkinlikYonetimSistemi.defaultpp.jpg"))
            {
                if (stream == null)
                    return null;

                using (MemoryStream ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }

        private void btn_KayitOl_Click(object sender, EventArgs e)
        {
            try
            {

                if (txt_Sifre.Text.Trim() != txt_SifreTekrar.Text.Trim())
                {
                    MessageBox.Show("Şifreler aynı değil. Lütfen tekrar deneyin.");
                    return;
                }

                var kullanici = new Kullanici
                {
                    Ad = txt_Ad.Text.Trim(),
                    Soyad = txt_Soyad.Text.Trim(),
                    Email = txt_Email.Text.Trim(),
                    Telefon = txt_Telefon.Text.Trim(),
                    Adres = txt_Adres.Text.Trim(),
                    DTarihi = date_DogumT.Value.ToString("yyyy-MM-dd"),
                    Cinsiyet = radio_Erkek.Checked ? "Erkek" : "Kadın",
                    KullaniciAdi = txt_KullaniciAdi.Text.Trim(),
                    Sifre = txt_Sifre.Text.Trim(),
                    ProfilFotografi = GetDefaultProfileImage()

                };

                var kbl = new KullaniciBL();
                bool sonuc = kbl.KullaniciKayit(kullanici);
                if (sonuc)
                {
                    MessageBox.Show("Kayıt başarılı!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız!!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
    }
}
