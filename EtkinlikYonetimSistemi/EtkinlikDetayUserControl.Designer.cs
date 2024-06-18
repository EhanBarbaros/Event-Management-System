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
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button btnBilgiGuncelle;
        private System.Windows.Forms.TextBox txtAciklama;

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
            this.lblAciklama = new System.Windows.Forms.Label();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.btnBilgiGuncelle = new System.Windows.Forms.Button();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtkinlikAdi
            // 
            this.lblEtkinlikAdi.AutoSize = true;
            this.lblEtkinlikAdi.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikAdi.Location = new System.Drawing.Point(20, 20);
            this.lblEtkinlikAdi.Name = "lblEtkinlikAdi";
            this.lblEtkinlikAdi.Size = new System.Drawing.Size(119, 22);
            this.lblEtkinlikAdi.TabIndex = 0;
            this.lblEtkinlikAdi.Text = "Etkinlik Adı:";
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblFiyat.Location = new System.Drawing.Point(20, 60);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(52, 19);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // lblEtkinlikTuru
            // 
            this.lblEtkinlikTuru.AutoSize = true;
            this.lblEtkinlikTuru.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikTuru.Location = new System.Drawing.Point(20, 100);
            this.lblEtkinlikTuru.Name = "lblEtkinlikTuru";
            this.lblEtkinlikTuru.Size = new System.Drawing.Size(111, 19);
            this.lblEtkinlikTuru.TabIndex = 2;
            this.lblEtkinlikTuru.Text = "Etkinlik Türü:";
            // 
            // lblToplamKontejan
            // 
            this.lblToplamKontejan.AutoSize = true;
            this.lblToplamKontejan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblToplamKontejan.Location = new System.Drawing.Point(20, 140);
            this.lblToplamKontejan.Name = "lblToplamKontejan";
            this.lblToplamKontejan.Size = new System.Drawing.Size(144, 19);
            this.lblToplamKontejan.TabIndex = 3;
            this.lblToplamKontejan.Text = "Toplam Kontejan:";
            // 
            // lblMevcutKontejan
            // 
            this.lblMevcutKontejan.AutoSize = true;
            this.lblMevcutKontejan.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblMevcutKontejan.Location = new System.Drawing.Point(20, 180);
            this.lblMevcutKontejan.Name = "lblMevcutKontejan";
            this.lblMevcutKontejan.Size = new System.Drawing.Size(139, 19);
            this.lblMevcutKontejan.TabIndex = 4;
            this.lblMevcutKontejan.Text = "Mevcut Katılımcı:";
            // 
            // lblEtkinlikTarihi
            // 
            this.lblEtkinlikTarihi.AutoSize = true;
            this.lblEtkinlikTarihi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikTarihi.Location = new System.Drawing.Point(20, 220);
            this.lblEtkinlikTarihi.Name = "lblEtkinlikTarihi";
            this.lblEtkinlikTarihi.Size = new System.Drawing.Size(117, 19);
            this.lblEtkinlikTarihi.TabIndex = 5;
            this.lblEtkinlikTarihi.Text = "Etkinlik Tarihi:";
            // 
            // lblEtkinlikYeri
            // 
            this.lblEtkinlikYeri.AutoSize = true;
            this.lblEtkinlikYeri.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikYeri.Location = new System.Drawing.Point(20, 260);
            this.lblEtkinlikYeri.Name = "lblEtkinlikYeri";
            this.lblEtkinlikYeri.Size = new System.Drawing.Size(103, 19);
            this.lblEtkinlikYeri.TabIndex = 6;
            this.lblEtkinlikYeri.Text = "Etkinlik Yeri:";
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblAciklama.Location = new System.Drawing.Point(20, 300);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(84, 19);
            this.lblAciklama.TabIndex = 7;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.Location = new System.Drawing.Point(350, 40);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(250, 200);
            this.pictureBoxResim.TabIndex = 8;
            this.pictureBoxResim.TabStop = false;
            // 
            // btnBilgiGuncelle
            // 
            this.btnBilgiGuncelle.Location = new System.Drawing.Point(350, 250);
            this.btnBilgiGuncelle.Name = "btnBilgiGuncelle";
            this.btnBilgiGuncelle.Size = new System.Drawing.Size(250, 23);
            this.btnBilgiGuncelle.TabIndex = 9;
            this.btnBilgiGuncelle.Text = "Bilgileri Güncelle";
            this.btnBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnBilgiGuncelle.Click += new System.EventHandler(this.btnBilgiGuncelle_Click_1);
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(20, 330);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.ReadOnly = true;
            this.txtAciklama.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtAciklama.Size = new System.Drawing.Size(580, 100);
            this.txtAciklama.TabIndex = 10;
            // 
            // EtkinlikDetayUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBilgiGuncelle);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.lblEtkinlikYeri);
            this.Controls.Add(this.lblEtkinlikTarihi);
            this.Controls.Add(this.lblMevcutKontejan);
            this.Controls.Add(this.lblToplamKontejan);
            this.Controls.Add(this.lblEtkinlikTuru);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.lblEtkinlikAdi);
            this.Controls.Add(this.txtAciklama);
            this.Name = "EtkinlikDetayUserControl";
            this.Size = new System.Drawing.Size(650, 450);
            this.MaximumSize = new System.Drawing.Size(650, 450);
            this.MinimumSize = new System.Drawing.Size(650, 450);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}
