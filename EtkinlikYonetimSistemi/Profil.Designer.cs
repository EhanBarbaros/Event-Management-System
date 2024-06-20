namespace EtkinlikYonetimSistemi
{
    partial class Profil
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.PictureBox pictureBoxProfil;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnResimYukle;
        private System.Windows.Forms.Button btnResimKaydet;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYetki;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblAd = new System.Windows.Forms.Label();
            this.lblSoyad = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblTelefon = new System.Windows.Forms.Label();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblDTarihi = new System.Windows.Forms.Label();
            this.lblCinsiyet = new System.Windows.Forms.Label();
            this.pictureBoxProfil = new System.Windows.Forms.PictureBox();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnResimYukle = new System.Windows.Forms.Button();
            this.btnResimKaydet = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYetki = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Location = new System.Drawing.Point(30, 30);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(23, 13);
            this.lblAd.TabIndex = 0;
            this.lblAd.Text = "Ad:";
            // 
            // lblSoyad
            // 
            this.lblSoyad.AutoSize = true;
            this.lblSoyad.Location = new System.Drawing.Point(30, 60);
            this.lblSoyad.Name = "lblSoyad";
            this.lblSoyad.Size = new System.Drawing.Size(40, 13);
            this.lblSoyad.TabIndex = 1;
            this.lblSoyad.Text = "Soyad:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(30, 90);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(35, 13);
            this.lblEmail.TabIndex = 2;
            this.lblEmail.Text = "Email:";
            // 
            // lblTelefon
            // 
            this.lblTelefon.AutoSize = true;
            this.lblTelefon.Location = new System.Drawing.Point(30, 120);
            this.lblTelefon.Name = "lblTelefon";
            this.lblTelefon.Size = new System.Drawing.Size(46, 13);
            this.lblTelefon.TabIndex = 3;
            this.lblTelefon.Text = "Telefon:";
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Location = new System.Drawing.Point(30, 150);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(37, 13);
            this.lblAdres.TabIndex = 4;
            this.lblAdres.Text = "Adres:";
            // 
            // lblDTarihi
            // 
            this.lblDTarihi.AutoSize = true;
            this.lblDTarihi.Location = new System.Drawing.Point(30, 180);
            this.lblDTarihi.Name = "lblDTarihi";
            this.lblDTarihi.Size = new System.Drawing.Size(68, 13);
            this.lblDTarihi.TabIndex = 5;
            this.lblDTarihi.Text = "Doğum Tarihi:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(30, 210);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(45, 13);
            this.lblCinsiyet.TabIndex = 6;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // pictureBoxProfil
            // 
            this.pictureBoxProfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxProfil.Location = new System.Drawing.Point(250, 30);
            this.pictureBoxProfil.Name = "pictureBoxProfil";
            this.pictureBoxProfil.Size = new System.Drawing.Size(150, 150);
            this.pictureBoxProfil.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxProfil.TabIndex = 7;
            this.pictureBoxProfil.TabStop = false;
            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(80, 240);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(150, 23);
            this.btnDuzenle.TabIndex = 8;
            this.btnDuzenle.Text = "Profili Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);
            // 
            // btnResimYukle
            // 
            this.btnResimYukle.Location = new System.Drawing.Point(250, 190);
            this.btnResimYukle.Name = "btnResimYukle";
            this.btnResimYukle.Size = new System.Drawing.Size(150, 23);
            this.btnResimYukle.TabIndex = 9;
            this.btnResimYukle.Text = "Resim Yükle";
            this.btnResimYukle.UseVisualStyleBackColor = true;
            this.btnResimYukle.Click += new System.EventHandler(this.btnResimYukle_Click);
            // 
            // btnResimKaydet
            // 
            this.btnResimKaydet.Location = new System.Drawing.Point(250, 220);
            this.btnResimKaydet.Name = "btnResimKaydet";
            this.btnResimKaydet.Size = new System.Drawing.Size(150, 23);
            this.btnResimKaydet.TabIndex = 10;
            this.btnResimKaydet.Text = "Resmi Kaydet";
            this.btnResimKaydet.UseVisualStyleBackColor = true;
            this.btnResimKaydet.Click += new System.EventHandler(this.btnResimKaydet_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(250, 250);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(150, 23);
            this.btnSil.TabIndex = 11;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // btnYetki
            // 
            this.btnYetki.Location = new System.Drawing.Point(250, 280);
            this.btnYetki.Name = "btnYetki";
            this.btnYetki.Size = new System.Drawing.Size(150, 23);
            this.btnYetki.TabIndex = 12;
            this.btnYetki.Text = "Yetkilendir";
            this.btnYetki.UseVisualStyleBackColor = true;
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // Profil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(434, 311);
            this.Controls.Add(this.btnYetki);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnResimKaydet);
            this.Controls.Add(this.btnResimYukle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.pictureBoxProfil);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "Profil";
            this.Text = "Profil";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxProfil)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
