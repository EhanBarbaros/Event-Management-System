using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using EtkinlikYS.BLL;
using EtkinlikYS.Model;

namespace EtkinlikYonetimSistemi
{
    public partial class KullaniciYonetimUserControl : UserControl
    {
        private KullaniciBL _kullaniciBL;
        private EtkinlikBL _etkinlikBL;

        public KullaniciYonetimUserControl()
        {
            InitializeComponent();
            _kullaniciBL = new KullaniciBL();
            _etkinlikBL = new EtkinlikBL();
        }

        private void lblKullanicilar_MouseEnter(object sender, EventArgs e)
        {
            lblKullanicilar.BackColor = Color.LightGray;
        }

        private void lblKullanicilar_MouseLeave(object sender, EventArgs e)
        {
            lblKullanicilar.BackColor = SystemColors.Control;
        }

        private void lblEtkinlikler_MouseEnter(object sender, EventArgs e)
        {
            lblEtkinlikler.BackColor = Color.LightGray;
        }

        private void lblEtkinlikler_MouseLeave(object sender, EventArgs e)
        {
            lblEtkinlikler.BackColor = SystemColors.Control;
        }

        private void lblKullanicilar_Click(object sender, EventArgs e)
        {
            LoadKullanicilar();
        }

        private void lblEtkinlikler_Click(object sender, EventArgs e)
        {
            LoadEtkinlikler();
        }

        private void btnKullanicilar_Click(object sender, EventArgs e)
        {
            LoadKullanicilar();
        }

        private void btnEtkinlikler_Click(object sender, EventArgs e)
        {
            LoadEtkinlikler();
        }

        private void LoadKullanicilar()
        {
            var kullanicilar = _kullaniciBL.KullanicilariGetir();
            dataGridView.DataSource = kullanicilar;
            ToggleView();
        }

        private void LoadEtkinlikler()
        {
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();
            dataGridView.DataSource = etkinlikler;
            ToggleView();
        }

        private void ToggleView()
        {
            lblKullanicilar.Visible = false;
            lblEtkinlikler.Visible = false;
            dataGridView.Visible = true;
            panelButtons.Visible = true;
        }
    }
}
