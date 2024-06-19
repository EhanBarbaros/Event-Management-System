using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using EtkinlikYS.BLL;
using EtkinlikYS.Model;

namespace EtkinlikYonetimSistemi
{
    public partial class KullaniciYonetimUserControl : UserControl
    {
        private KullaniciBL _kullaniciBL;
        private EtkinlikBL _etkinlikBL;
        private Kullanici _currentUser;

        public KullaniciYonetimUserControl(Kullanici currentUser)
        {
            InitializeComponent();
            _kullaniciBL = new KullaniciBL();
            _etkinlikBL = new EtkinlikBL();
            _currentUser = currentUser;
            dataGridView.CellFormatting += dataGridView_CellFormatting;
            dataGridView.CellDoubleClick += dataGridView_CellDoubleClick;
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.ReadOnly = true;
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
            List<Kullanici> kullanicilar;
            if (_currentUser.Yetki == "kurucu")
            {
                // Kurucu, tüm kullanıcıları görebilir
                kullanicilar = _kullaniciBL.KullanicilariGetir().ToList();
            }
            else
            {
                // Admin ve diğer kullanıcılar adminleri göremez
                kullanicilar = _kullaniciBL.KullanicilariGetir().Where(k => k.Yetki != "admin" && k.Yetki != "kurucu").ToList();
            }
            dataGridView.DataSource = kullanicilar;
            dataGridView.Columns["ProfilFotografi"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToggleView();
        }

        private void LoadEtkinlikler()
        {
            var etkinlikler = _etkinlikBL.EtkinlikleriGetir();
            dataGridView.DataSource = etkinlikler;
            dataGridView.Columns["Resim"].Visible = false;
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToggleView();
        }

        private void ToggleView()
        {
            lblKullanicilar.Visible = false;
            lblEtkinlikler.Visible = false;
            dataGridView.Visible = true;
            panelButtons.Visible = true;
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.RowIndex % 2 == 0)
            {
                e.CellStyle.BackColor = Color.LightGray;
            }
            else
            {
                e.CellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Çift tıklamayı engellemek için içeriği boş bırakın
        }
    }
}
