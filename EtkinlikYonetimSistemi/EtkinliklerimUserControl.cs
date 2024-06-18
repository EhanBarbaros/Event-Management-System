using EtkinlikYS.BLL;
using EtkinlikYS.Model;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    public partial class EtkinliklerimUserControl : UserControl
    {
        private Kullanici _kullanici;
        private EtkinlikBL _etkinlikBL;

        public EtkinliklerimUserControl(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            _etkinlikBL = new EtkinlikBL();
            LoadEtkinlikler();
        }

        private void LoadEtkinlikler()
        {
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();
            flowLayoutPanel1.Controls.Clear();

            foreach (var etkinlik in etkinlikler)
            {
                if (etkinlik.OlusturanKullaniciID == _kullanici.Kullaniciid)
                {
                    var etkinlikPanel = CreateEtkinlikPanel(etkinlik);
                    flowLayoutPanel1.Controls.Add(etkinlikPanel);
                }
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

            panel.Click += (s, e) => ShowEtkinlikDetay(etkinlik);

            return panel;
        }

        private void ShowEtkinlikDetay(Etkinlik etkinlik)
        {
            EtkinlikDetayUserControl etkinlikDetayUC = new EtkinlikDetayUserControl(etkinlik);
            Form detayForm = new Form
            {
                Size = new Size(800, 600),
                Text = "Etkinlik Detay"
            };
            detayForm.Controls.Add(etkinlikDetayUC);
            etkinlikDetayUC.Dock = DockStyle.Fill;
            detayForm.ShowDialog();
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            using (var ms = new System.IO.MemoryStream(byteArray))
            {
                return Image.FromStream(ms);
            }
        }
    }
}
