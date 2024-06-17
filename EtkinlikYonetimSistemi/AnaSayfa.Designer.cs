using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    partial class AnaSayfa
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, bool."></param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.btn_Etkinliklerim = new System.Windows.Forms.Button();
            this.btn_EtkinlikOlustur = new System.Windows.Forms.Button();
            this.lbl_baslik = new System.Windows.Forms.Label();
            this.panelScroll = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.profilMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.profilAyarlarıToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cikisYapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
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
            this.panel1.Controls.Add(this.lbl_kullaniciAdi);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btn_Etkinliklerim);
            this.panel1.Controls.Add(this.btn_EtkinlikOlustur);
            this.panel1.Controls.Add(this.lbl_baslik);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1280, 90);
            this.panel1.TabIndex = 2;
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(1130, 30);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(125, 23);
            this.lbl_kullaniciAdi.TabIndex = 6;
            this.lbl_kullaniciAdi.Text = "Ertuğrul Han Barbaros";
            this.lbl_kullaniciAdi.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbl_kullaniciAdi.Click += new System.EventHandler(this.lbl_kullaniciAdi_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.pictureBox1.Location = new System.Drawing.Point(1080, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(688, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(111, 37);
            this.button3.TabIndex = 3;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // btn_Etkinliklerim
            // 
            this.btn_Etkinliklerim.Location = new System.Drawing.Point(559, 12);
            this.btn_Etkinliklerim.Name = "btn_Etkinliklerim";
            this.btn_Etkinliklerim.Size = new System.Drawing.Size(111, 37);
            this.btn_Etkinliklerim.TabIndex = 2;
            this.btn_Etkinliklerim.Text = "Etkinliklerimi Yönet";
            this.btn_Etkinliklerim.UseVisualStyleBackColor = true;
            // 
            // btn_EtkinlikOlustur
            // 
            this.btn_EtkinlikOlustur.Location = new System.Drawing.Point(429, 12);
            this.btn_EtkinlikOlustur.Name = "btn_EtkinlikOlustur";
            this.btn_EtkinlikOlustur.Size = new System.Drawing.Size(111, 37);
            this.btn_EtkinlikOlustur.TabIndex = 1;
            this.btn_EtkinlikOlustur.Text = "Etkinlik Oluştur";
            this.btn_EtkinlikOlustur.UseVisualStyleBackColor = true;
            this.btn_EtkinlikOlustur.Click += new System.EventHandler(this.btn_EtkinlikOlustur_Click);
            // 
            // lbl_baslik
            // 
            this.lbl_baslik.AutoSize = true;
            this.lbl_baslik.Font = new System.Drawing.Font("Baskerville Old Face", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_baslik.ForeColor = System.Drawing.Color.IndianRed;
            this.lbl_baslik.Location = new System.Drawing.Point(11, 18);
            this.lbl_baslik.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_baslik.Name = "lbl_baslik";
            this.lbl_baslik.Size = new System.Drawing.Size(400, 31);
            this.lbl_baslik.TabIndex = 0;
            this.lbl_baslik.Text = "ETKİNLİK YÖNETİM SİSTEMİ";
            // 
            // panelScroll
            // 
            this.panelScroll.Controls.Add(this.flowLayoutPanel1);
            this.panelScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelScroll.Location = new System.Drawing.Point(0, 90);
            this.panelScroll.Name = "panelScroll";
            this.panelScroll.Size = new System.Drawing.Size(1280, 660);
            this.panelScroll.TabIndex = 3;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.LeftToRight;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Padding = new System.Windows.Forms.Padding(10);
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1280, 660);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = true;
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
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelScroll.ResumeLayout(false);
            this.profilMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ContextMenuStrip contextMenuStrip1;
        private Panel panel1;
        private Label lbl_baslik;
        private Label lbl_kullaniciAdi;
        private PictureBox pictureBox1;
        private Button button3;
        private Button btn_Etkinliklerim;
        private Button btn_EtkinlikOlustur;
        private Panel panelScroll;
        private FlowLayoutPanel flowLayoutPanel1;
        private ContextMenuStrip profilMenu;
        private ToolStripMenuItem profilAyarlarıToolStripMenuItem;
        private ToolStripMenuItem cikisYapToolStripMenuItem;
    }
}
