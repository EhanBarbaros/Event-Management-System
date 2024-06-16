using EtkinlikYS.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class form_ilk : Form
    {
        public form_ilk()
        {
            InitializeComponent();
        }


        private void CloseButton_Click(object sender, EventArgs e)
        {
            //Kapama butonuna tıklandığında çalışacak fonksiyon.
            this.Close();
        }

        private void btn_GirisYap_Click(object sender, EventArgs e)
        {
            try
            {
                var kbl = new KullaniciBL();
                var kullanici = kbl.KullaniciBul(txt_kullaniciAdi.Text.Trim(), txt_sifre.Text.Trim());

                if (kullanici != null)
                {
                    AnaSayfa anaSayfa = new AnaSayfa(kullanici);
                    this.Hide();
                    anaSayfa.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Kullanıcı adı veya şifre yanlış.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btn_GirisFormKayitOl_Click(object sender, EventArgs e)
        {
            //Kayıt ol sayfasına yönlendirmek i çin bir değişken tanımlandı.
            //İlk olarak Kayıt ol formunu açıyoruz. Sonra arka planda kalan formu gizliyoruz ve eğer kayıt formu kapatılırsa giriş formunu tekrar görünür yapıyrouz
            Form frm = new KayitOl();
            frm.Show();
            this.Hide();

            frm.FormClosed += (s, args) => this.Show();
        }
    }
}
