using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class ProfilDuzenle : Form
    {
        private Kullanici _kullanici;
        private KullaniciBL _kullaniciBL;

        public ProfilDuzenle(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _kullaniciBL = new KullaniciBL();
            DisplayKullaniciInfo();
        }

        private void DisplayKullaniciInfo()
        {
            txtAd.Text = _kullanici.Ad;
            txtSoyad.Text = _kullanici.Soyad;
            txtEmail.Text = _kullanici.Email;
            txtTelefon.Text = _kullanici.Telefon;
            txtAdres.Text = _kullanici.Adres;
            dtpDTarihi.Value = DateTime.Parse(_kullanici.DTarihi);
            cmbCinsiyet.SelectedItem = _kullanici.Cinsiyet;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                _kullanici.Ad = txtAd.Text;
                _kullanici.Soyad = txtSoyad.Text;
                _kullanici.Email = txtEmail.Text;
                _kullanici.Telefon = txtTelefon.Text;
                _kullanici.Adres = txtAdres.Text;
                _kullanici.DTarihi = dtpDTarihi.Value.ToString("yyyy-MM-dd");
                _kullanici.Cinsiyet = cmbCinsiyet.SelectedItem.ToString();

                if (_kullaniciBL.KullaniciGuncelle(_kullanici))
                {
                    MessageBox.Show("Profil başarıyla güncellendi.");
                    this.DialogResult = DialogResult.OK;
                }
                else
                {
                    MessageBox.Show("Profil güncelleme sırasında bir hata oluştu.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }

        private void btnSifreDegistir_Click(object sender, EventArgs e)
        {
            using (Form sifreForm = new Form())
            {
                sifreForm.Text = "Şifre Değiştir";
                sifreForm.Size = new Size(300, 200);
                sifreForm.StartPosition = FormStartPosition.CenterParent;
                sifreForm.FormBorderStyle = FormBorderStyle.FixedDialog;
                sifreForm.MaximizeBox = false;
                sifreForm.MinimizeBox = false;

                Label lblEskiSifre = new Label { Text = "Eski Şifre:", Location = new Point(10, 20), AutoSize = true };
                TextBox txtEskiSifre = new TextBox { Location = new Point(100, 20), PasswordChar = '*', Width = 150 };

                Label lblYeniSifre = new Label { Text = "Yeni Şifre:", Location = new Point(10, 60), AutoSize = true };
                TextBox txtYeniSifre = new TextBox { Location = new Point(100, 60), PasswordChar = '*', Width = 150 };

                Label lblYeniSifreTekrar = new Label { Text = "Yeni Şifre Tekrar:", Location = new Point(10, 100), AutoSize = true };
                TextBox txtYeniSifreTekrar = new TextBox { Location = new Point(100, 100), PasswordChar = '*', Width = 150 };

                Button btnSave = new Button { Text = "Kaydet", Location = new Point(100, 140), Width = 150 };
                btnSave.Click += (s, ev) =>
                {
                    if (txtYeniSifre.Text != txtYeniSifreTekrar.Text)
                    {
                        MessageBox.Show("Yeni şifreler eşleşmiyor.");
                        return;
                    }

                    try
                    {
                        if (_kullaniciBL.KullaniciGuncelle(_kullanici, txtEskiSifre.Text, txtYeniSifre.Text))
                        {
                            MessageBox.Show("Şifre başarıyla değiştirildi.");
                            sifreForm.Close();
                        }
                        else
                        {
                            MessageBox.Show("Şifre değiştirme sırasında bir hata oluştu.");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Bir hata oluştu: " + ex.Message);
                    }
                };

                sifreForm.Controls.Add(lblEskiSifre);
                sifreForm.Controls.Add(txtEskiSifre);
                sifreForm.Controls.Add(lblYeniSifre);
                sifreForm.Controls.Add(txtYeniSifre);
                sifreForm.Controls.Add(lblYeniSifreTekrar);
                sifreForm.Controls.Add(txtYeniSifreTekrar);
                sifreForm.Controls.Add(btnSave);

                sifreForm.ShowDialog();
            }
        }

    }
}
