using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinlikOlustur : Form
    {
        private Kullanici _kullanici;
        private EtkinlikBL _etkinlikBL;
        private byte[] _selectedImage;
        public EtkinlikOlustur(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _etkinlikBL = new EtkinlikBL();
            _selectedImage = null;

        }

        public byte[] GetDefaultImage()
        {
            var assembly = Assembly.GetExecutingAssembly();
            using (var stream = assembly.GetManifestResourceStream("EtkinlikYonetimSistemi.defaultEtkinlik.jpg"))
            {
                if (stream == null)
                {
                    return null;
                }
                using (var ms = new MemoryStream())
                {
                    stream.CopyTo(ms);
                    return ms.ToArray();
                }
            }
        }


        private void btnAddEvent_Click(object sender, EventArgs e)
        {
            byte[] imageToSave;
            if (_selectedImage != null)
            {
                imageToSave = _selectedImage;
            }
            else
            {
                imageToSave = GetDefaultImage();
                if (imageToSave == null)
                {
                    MessageBox.Show("Default resim yüklenemedi. Lütfen bir resim seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }

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
                    Resim = imageToSave,
                    OlusturanKullaniciID = (int)_kullanici.Kullaniciid
                };

                bool isAdded = _etkinlikBL.EtkinlikKayit(yeniEtkinlik);
                if (isAdded)
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
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _selectedImage = File.ReadAllBytes(openFileDialog.FileName);
                    pictureBox.Image = Image.FromFile(openFileDialog.FileName);
                }
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            if (byteArray == null)
                return null;

            using (var ms = new MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
