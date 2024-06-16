using EtkinlikYS.Model;
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
    public partial class AnaSayfa : Form
    {
        private Kullanici _kullanici;
        public AnaSayfa(Kullanici kullanici)
        {
            InitializeComponent();
            _kullanici = kullanici;
            lbl_kullaniciAdi.Text = _kullanici.KullaniciAdi;
        }

        private void btn_EtkinlikOlustur_Click(object sender, EventArgs e)
        {
            EtkinlikOlustur etkinlikOlusturForm = new EtkinlikOlustur(_kullanici);
            etkinlikOlusturForm.ShowDialog();
        }
    }
}
