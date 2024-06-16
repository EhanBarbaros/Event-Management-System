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
    public partial class EtkinlikOlustur : Form
    {
        private Kullanici _kullanici;
        public EtkinlikOlustur(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;

        }

        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            try
            {
                Etkinlik yeniEtkinlik = new Etkinlik
                {
                    EtkinlikAdi = txtEventName.Text,
                    Fiyat = txtPrice.Text,
                    EtkinlikTuru = txtEventType.Text,
                    ToplamKontejan = int.Parse(txtTotalSlots.Text),
                    MevcutKontejan = int.Parse(txtAvailableSlots.Text),
                    EtkinlikTarihi = dtpEventDate.Value,
                    EtkinlikYeri = txtEventLocation.Text,
                    Aciklama = txtDescription.Text,
                    Resim = pictureBox.Image != null ? ImageToByteArray(pictureBox.Image) : null,
                    OlusturanKullaniciID = (int)_kullanici.Kullaniciid
                };

                EtkinlikBL etkinlikBL = new EtkinlikBL();
                bool isAdded = etkinlikBL.EtkinlikKayit(yeniEtkinlik);
                if (isAdded == true)
                {
                    MessageBox.Show("Etkinlik başarıyla eklendi!");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Etkinlik ekleme başarısız!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Bir hata oluştu: " + ex.Message);
            }
        }
        private void btnUploadImage_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFileDialog.FileName);
                pictureBox.Image = image;
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
    }
}
