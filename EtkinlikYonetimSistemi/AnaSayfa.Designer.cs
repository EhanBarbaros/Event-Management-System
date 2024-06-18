using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    partial class AnaSayfa
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnKullaniciYonetim = new System.Windows.Forms.Button();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.buttonAnaSayfa = new System.Windows.Forms.Button();
            this.buttonHakkimizda = new System.Windows.Forms.Button();
            this.btn_EtkinlikOlustur = new System.Windows.Forms.Button();
            this.btn_Etkinliklerim = new System.Windows.Forms.Button();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.lblBakiye = new System.Windows.Forms.Label();
            this.btnBakiyeEkle = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.profilMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profilAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelScroll.SuspendLayout();
            this.profilMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.btnKullaniciYonetim);
            this.panel1.Controls.Add(this.pictureBoxLogo);
            this.panel1.Controls.Add(this.lbl_baslik);
            this.panel1.Controls.Add(this.buttonAnaSayfa);
            this.panel1.Controls.Add(this.buttonHakkimizda);
            this.panel1.Controls.Add(this.btn_EtkinlikOlustur);
            this.panel1.Controls.Add(this.btn_Etkinliklerim);
            this.panel1.Controls.Add(this.lbl_kullaniciAdi);
            this.panel1.Controls.Add(this.lblBakiye);
            this.panel1.Controls.Add(this.btnBakiyeEkle);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 80);
            this.panel1.TabIndex = 2;
            // 
            // btnKullaniciYonetim
            // 
            this.btnKullaniciYonetim.Location = new System.Drawing.Point(827, 23);
            this.btnKullaniciYonetim.Name = "btnKullaniciYonetim";
            this.btnKullaniciYonetim.Size = new System.Drawing.Size(111, 37);
            this.btnKullaniciYonetim.TabIndex = 12;
            this.btnKullaniciYonetim.Text = "Kullanıcı Yönetimi";
            this.btnKullaniciYonetim.UseVisualStyleBackColor = true;
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Image = global::EtkinlikYonetimSistemi.Properties.Resources.logo;
            this.pictureBoxLogo.Location = new System.Drawing.Point(15, 15);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 11;
            this.pictureBoxLogo.TabStop = false;
            this.pictureBoxLogo.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxLogo_Paint);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_baslik.Location = new System.Drawing.Point(75, 27);
            this.lbl_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(257, 26);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "Etkinlik Yönetim Sistemi";
            // 
            // buttonAnaSayfa
            // 
            this.buttonAnaSayfa.Location = new System.Drawing.Point(350, 22);
            this.buttonAnaSayfa.Name = "buttonAnaSayfa";
            this.buttonAnaSayfa.Size = new System.Drawing.Size(111, 37);
            this.buttonAnaSayfa.TabIndex = 7;
            this.buttonAnaSayfa.Text = "Ana Sayfa";
            this.buttonAnaSayfa.UseVisualStyleBackColor = true;
            this.buttonAnaSayfa.Click += new System.EventHandler(this.buttonAnaSayfa_Click);
            // 
            // buttonHakkimizda
            // 
            this.buttonHakkimizda.Location = new System.Drawing.Point(470, 22);
            this.buttonHakkimizda.Name = "buttonHakkimizda";
            this.buttonHakkimizda.Size = new System.Drawing.Size(111, 37);
            this.buttonHakkimizda.TabIndex = 8;
            this.buttonHakkimizda.Text = "Hakkımızda";
            this.buttonHakkimizda.UseVisualStyleBackColor = true;
            this.buttonHakkimizda.Click += new System.EventHandler(this.buttonHakkimizda_Click);
            // 
            // btn_EtkinlikOlustur
            // 
            this.btn_EtkinlikOlustur.Location = new System.Drawing.Point(590, 22);
            this.btn_EtkinlikOlustur.Name = "btn_EtkinlikOlustur";
            this.btn_EtkinlikOlustur.Size = new System.Drawing.Size(111, 37);
            this.btn_EtkinlikOlustur.TabIndex = 1;
            this.btn_EtkinlikOlustur.Text = "Etkinlik Oluştur";
            this.btn_EtkinlikOlustur.UseVisualStyleBackColor = true;
            this.btn_EtkinlikOlustur.Click += new System.EventHandler(this.btn_EtkinlikOlustur_Click);
            // 
            // btn_Etkinliklerim
            // 
            this.btn_Etkinliklerim.Location = new System.Drawing.Point(710, 22);
            this.btn_Etkinliklerim.Name = "btn_Etkinliklerim";
            this.btn_Etkinliklerim.Size = new System.Drawing.Size(111, 37);
            this.btn_Etkinliklerim.TabIndex = 2;
            this.btn_Etkinliklerim.Text = "Etkinliklerim";
            this.btn_Etkinliklerim.UseVisualStyleBackColor = true;
            this.btn_Etkinliklerim.Click += new System.EventHandler(this.btn_Etkinliklerim_Click_1);
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(1157, 60);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(120, 23);
            this.lbl_kullaniciAdi.TabIndex = 6;
            this.lbl_kullaniciAdi.Text = "Ertuğrul Han Barbaros";
            this.lbl_kullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_kullaniciAdi.Click += new System.EventHandler(this.lbl_kullaniciAdi_Click);
            // 
            // lblBakiye
            // 
            this.lblBakiye.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBakiye.Location = new System.Drawing.Point(1000, 30);
            this.lblBakiye.Name = "lblBakiye";
            this.lblBakiye.Size = new System.Drawing.Size(106, 23);
            this.lblBakiye.TabIndex = 10;
            this.lblBakiye.Text = "Bakiye: 0 TL";
            this.lblBakiye.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblBakiye.Click += new System.EventHandler(this.lblBakiye_Click);
            // 
            // btnBakiyeEkle
            // 
            this.btnBakiyeEkle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBakiyeEkle.Location = new System.Drawing.Point(980, 25);
            this.btnBakiyeEkle.Name = "btnBakiyeEkle";
            this.btnBakiyeEkle.Size = new System.Drawing.Size(30, 23);
            this.btnBakiyeEkle.TabIndex = 9;
            this.btnBakiyeEkle.Text = "+";
            this.btnBakiyeEkle.BringToFront();
            this.btnBakiyeEkle.UseVisualStyleBackColor = true;
            this.btnBakiyeEkle.Click += new System.EventHandler(this.btnBakiyeEkle_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1101, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(50, 50);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // panelScroll
            // 
            this.panelScroll.AutoScroll = true;
            this.panelScroll.Controls.Add(this.flowLayoutPanel1);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(0, 80);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1280, 670);
            this.panelScroll.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1263, 1000);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // profilMenu
            // 
            this.profilMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.profilMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilAyarlarıToolStripMenuItem,
            this.cikisYapToolStripMenuItem});
            this.profilMenu.Name = "profilMenu";
            this.profilMenu.Size = new System.Drawing.Size(146, 48);
            // 
            // profilAyarlarıToolStripMenuItem
            // 
            this.profilAyarlarıToolStripMenuItem.Name = "profilAyarlarıToolStripMenuItem";
            this.profilAyarlarıToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.profilAyarlarıToolStripMenuItem.Text = "Profil Ayarları";
            this.profilAyarlarıToolStripMenuItem.Click += new System.EventHandler(this.btnProfilAyarları_Click);
            // 
            // cikisYapToolStripMenuItem
            // 
            this.cikisYapToolStripMenuItem.Name = "cikisYapToolStripMenuItem";
            this.cikisYapToolStripMenuItem.Size = new System.Drawing.Size(145, 22);
            this.cikisYapToolStripMenuItem.Text = "Çıkış Yap";
            this.cikisYapToolStripMenuItem.Click += new System.EventHandler(this.btnCikisYap_Click);
            // 
            // AnaSayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.panelScroll);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "AnaSayfa";
            this.Text = "AnaSayfa";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.profilMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_baslik;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_Etkinliklerim;
        private System.Windows.Forms.Button btn_EtkinlikOlustur;
        private System.Windows.Forms.Panel panelScroll;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ContextMenuStrip profilMenu;
        private System.Windows.Forms.ToolStripMenuItem profilAyarlarıToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cikisYapToolStripMenuItem;
        private System.Windows.Forms.Button buttonAnaSayfa;
        private System.Windows.Forms.Button buttonHakkimizda;
        private System.Windows.Forms.Label lblBakiye;
        private System.Windows.Forms.Button btnBakiyeEkle;
        private System.Windows.Forms.PictureBox pictureBoxLogo;

        // logo.jpg resmini daire şekline dönüştürmek için gerekli event handler
        private void pictureBoxLogo_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddEllipse(0, 0, pictureBoxLogo.Width, pictureBoxLogo.Height);
            pictureBoxLogo.Region = new Region(path);
        }

        private Button btnKullaniciYonetim;
    }
}
