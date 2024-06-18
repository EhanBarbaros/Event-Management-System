namespace EtkinlikYonetimSistemi
{
    partial class EtkinlikDetayUserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEtkinlikAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblEtkinlikTuru;
        private System.Windows.Forms.Label lblToplamKontejan;
        private System.Windows.Forms.Label lblMevcutKontejan;
        private System.Windows.Forms.Label lblEtkinlikTarihi;
        private System.Windows.Forms.Label lblEtkinlikYeri;
        private System.Windows.Forms.PictureBox pictureBoxResim;

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
            this.lblEtkinlikAdi = new System.Windows.Forms.Label();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblEtkinlikTuru = new System.Windows.Forms.Label();
            this.lblToplamKontejan = new System.Windows.Forms.Label();
            this.lblMevcutKontejan = new System.Windows.Forms.Label();
            this.lblEtkinlikTarihi = new System.Windows.Forms.Label();
            this.lblEtkinlikYeri = new System.Windows.Forms.Label();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtkinlikAdi
            // 
            this.lblEtkinlikAdi.AutoSize = true;
            this.lblEtkinlikAdi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikAdi.Location = new System.Drawing.Point(12, 9);
            this.lblEtkinlikAdi.Name = "lblEtkinlikAdi";
            this.lblEtkinlikAdi.Size = new System.Drawing.Size(112, 22);
            this.lblEtkinlikAdi.TabIndex = 0;
            this.lblEtkinlikAdi.Text = "Etkinlik Adı";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(14, 50);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(29, 13);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat";
            // 
            // lblEtkinlikTuru
            // 
            this.lblEtkinlikTuru.AutoSize = true;
            this.lblEtkinlikTuru.Location = new System.Drawing.Point(14, 80);
            this.lblEtkinlikTuru.Name = "lblEtkinlikTuru";
            this.lblEtkinlikTuru.Size = new System.Drawing.Size(66, 13);
            this.lblEtkinlikTuru.TabIndex = 2;
            this.lblEtkinlikTuru.Text = "Etkinlik Türü";
            // 
            // lblToplamKontejan
            // 
            this.lblToplamKontejan.AutoSize = true;
            this.lblToplamKontejan.Location = new System.Drawing.Point(14, 110);
            this.lblToplamKontejan.Name = "lblToplamKontejan";
            this.lblToplamKontejan.Size = new System.Drawing.Size(87, 13);
            this.lblToplamKontejan.TabIndex = 3;
            this.lblToplamKontejan.Text = "Toplam Kontejan";
            // 
            // lblMevcutKontejan
            // 
            this.lblMevcutKontejan.AutoSize = true;
            this.lblMevcutKontejan.Location = new System.Drawing.Point(14, 140);
            this.lblMevcutKontejan.Name = "lblMevcutKontejan";
            this.lblMevcutKontejan.Size = new System.Drawing.Size(88, 13);
            this.lblMevcutKontejan.TabIndex = 4;
            this.lblMevcutKontejan.Text = "Mevcut Kontejan";
            // 
            // lblEtkinlikTarihi
            // 
            this.lblEtkinlikTarihi.AutoSize = true;
            this.lblEtkinlikTarihi.Location = new System.Drawing.Point(14, 170);
            this.lblEtkinlikTarihi.Name = "lblEtkinlikTarihi";
            this.lblEtkinlikTarihi.Size = new System.Drawing.Size(70, 13);
            this.lblEtkinlikTarihi.TabIndex = 5;
            this.lblEtkinlikTarihi.Text = "Etkinlik Tarihi";
            // 
            // lblEtkinlikYeri
            // 
            this.lblEtkinlikYeri.AutoSize = true;
            this.lblEtkinlikYeri.Location = new System.Drawing.Point(14, 200);
            this.lblEtkinlikYeri.Name = "lblEtkinlikYeri";
            this.lblEtkinlikYeri.Size = new System.Drawing.Size(62, 13);
            this.lblEtkinlikYeri.TabIndex = 6;
            this.lblEtkinlikYeri.Text = "Etkinlik Yeri";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.Location = new System.Drawing.Point(380, 9);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(300, 300);
            this.pictureBoxResim.TabIndex = 8;
            this.pictureBoxResim.TabStop = false;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(13, 227);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(50, 13);
            this.lblAciklama.TabIndex = 9;
            this.lblAciklama.Text = "Açıklama";
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(270, 326);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(174, 27);
            this.btnBilgiGuncelle.TabIndex = 10;
            this.btnBilgiGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = true;
            // 
            // EtkinlikDetayUserControl
            // 
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.lblEtkinlikYeri);
            this.Controls.Add(this.lblEtkinlikTarihi);
            this.Controls.Add(this.lblMevcutKontejan);
            this.Controls.Add(this.lblToplamKontejan);
            this.Controls.Add(this.lblEtkinlikTuru);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblEtkinlikAdi);
            this.Name = "EtkinlikDetayUserControl";
            this.Size = new System.Drawing.Size(700, 365);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.Button btnBilgiGuncelle;
    }
}
