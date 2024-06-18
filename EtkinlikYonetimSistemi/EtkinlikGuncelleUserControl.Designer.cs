using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    partial class EtkinlikGuncelleUserControl
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblEtkinlikAdi;
        private System.Windows.Forms.TextBox txtEtkinlikAdi;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Label lblEtkinlikTuru;
        private System.Windows.Forms.TextBox txtEtkinlikTuru;
        private System.Windows.Forms.Label lblToplamKontejan;
        private System.Windows.Forms.TextBox txtToplamKontejan;
        private System.Windows.Forms.Label lblEtkinlikTarihi;
        private System.Windows.Forms.DateTimePicker dtpEtkinlikTarihi;
        private System.Windows.Forms.Label lblEtkinlikYeri;
        private System.Windows.Forms.TextBox txtEtkinlikYeri;
        private System.Windows.Forms.Label lblAciklama;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Label lblResim;
        private System.Windows.Forms.PictureBox pictureBoxResim;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnGuncelle;
        private OpenFileDialog openFileDialog1;

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
            this.txtEtkinlikAdi = new System.Windows.Forms.TextBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.lblEtkinlikTuru = new System.Windows.Forms.Label();
            this.txtEtkinlikTuru = new System.Windows.Forms.TextBox();
            this.lblToplamKontejan = new System.Windows.Forms.Label();
            this.txtToplamKontejan = new System.Windows.Forms.TextBox();
            this.lblEtkinlikTarihi = new System.Windows.Forms.Label();
            this.dtpEtkinlikTarihi = new System.Windows.Forms.DateTimePicker();
            this.lblEtkinlikYeri = new System.Windows.Forms.Label();
            this.txtEtkinlikYeri = new System.Windows.Forms.TextBox();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.lblResim = new System.Windows.Forms.Label();
            this.pictureBoxResim = new System.Windows.Forms.PictureBox();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEtkinlikAdi
            // 
            this.lblEtkinlikAdi.AutoSize = true;
            this.lblEtkinlikAdi.Location = new System.Drawing.Point(20, 20);
            this.lblEtkinlikAdi.Name = "lblEtkinlikAdi";
            this.lblEtkinlikAdi.Size = new System.Drawing.Size(67, 13);
            this.lblEtkinlikAdi.TabIndex = 0;
            this.lblEtkinlikAdi.Text = "Etkinlik Adı:";
            // 
            // txtEtkinlikAdi
            // 
            this.txtEtkinlikAdi.Location = new System.Drawing.Point(120, 20);
            this.txtEtkinlikAdi.Name = "txtEtkinlikAdi";
            this.txtEtkinlikAdi.Size = new System.Drawing.Size(200, 20);
            this.txtEtkinlikAdi.TabIndex = 1;
            // 
            // lblFiyat
            // 
            this.lblFiyat.AutoSize = true;
            this.lblFiyat.Location = new System.Drawing.Point(20, 60);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(34, 13);
            this.lblFiyat.TabIndex = 2;
            this.lblFiyat.Text = "Fiyat:";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Location = new System.Drawing.Point(120, 60);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 20);
            this.txtFiyat.TabIndex = 3;
            // 
            // lblEtkinlikTuru
            // 
            this.lblEtkinlikTuru.AutoSize = true;
            this.lblEtkinlikTuru.Location = new System.Drawing.Point(20, 100);
            this.lblEtkinlikTuru.Name = "lblEtkinlikTuru";
            this.lblEtkinlikTuru.Size = new System.Drawing.Size(68, 13);
            this.lblEtkinlikTuru.TabIndex = 4;
            this.lblEtkinlikTuru.Text = "Etkinlik Türü:";
            // 
            // txtEtkinlikTuru
            // 
            this.txtEtkinlikTuru.Location = new System.Drawing.Point(120, 100);
            this.txtEtkinlikTuru.Name = "txtEtkinlikTuru";
            this.txtEtkinlikTuru.Size = new System.Drawing.Size(200, 20);
            this.txtEtkinlikTuru.TabIndex = 5;
            // 
            // lblToplamKontejan
            // 
            this.lblToplamKontejan.AutoSize = true;
            this.lblToplamKontejan.Location = new System.Drawing.Point(20, 140);
            this.lblToplamKontejan.Name = "lblToplamKontejan";
            this.lblToplamKontejan.Size = new System.Drawing.Size(89, 13);
            this.lblToplamKontejan.TabIndex = 6;
            this.lblToplamKontejan.Text = "Toplam Kontejan:";
            // 
            // txtToplamKontejan
            // 
            this.txtToplamKontejan.Location = new System.Drawing.Point(120, 140);
            this.txtToplamKontejan.Name = "txtToplamKontejan";
            this.txtToplamKontejan.Size = new System.Drawing.Size(200, 20);
            this.txtToplamKontejan.TabIndex = 7;
            // 
            // lblEtkinlikTarihi
            // 
            this.lblEtkinlikTarihi.AutoSize = true;
            this.lblEtkinlikTarihi.Location = new System.Drawing.Point(20, 180);
            this.lblEtkinlikTarihi.Name = "lblEtkinlikTarihi";
            this.lblEtkinlikTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblEtkinlikTarihi.TabIndex = 8;
            this.lblEtkinlikTarihi.Text = "Etkinlik Tarihi:";
            // 
            // dtpEtkinlikTarihi
            // 
            this.dtpEtkinlikTarihi.Location = new System.Drawing.Point(120, 180);
            this.dtpEtkinlikTarihi.Name = "dtpEtkinlikTarihi";
            this.dtpEtkinlikTarihi.Size = new System.Drawing.Size(200, 20);
            this.dtpEtkinlikTarihi.TabIndex = 9;
            // 
            // lblEtkinlikYeri
            // 
            this.lblEtkinlikYeri.AutoSize = true;
            this.lblEtkinlikYeri.Location = new System.Drawing.Point(20, 220);
            this.lblEtkinlikYeri.Name = "lblEtkinlikYeri";
            this.lblEtkinlikYeri.Size = new System.Drawing.Size(64, 13);
            this.lblEtkinlikYeri.TabIndex = 10;
            this.lblEtkinlikYeri.Text = "Etkinlik Yeri:";
            // 
            // txtEtkinlikYeri
            // 
            this.txtEtkinlikYeri.Location = new System.Drawing.Point(120, 220);
            this.txtEtkinlikYeri.Name = "txtEtkinlikYeri";
            this.txtEtkinlikYeri.Size = new System.Drawing.Size(200, 20);
            this.txtEtkinlikYeri.TabIndex = 11;
            // 
            // lblAciklama
            // 
            this.lblAciklama.AutoSize = true;
            this.lblAciklama.Location = new System.Drawing.Point(20, 260);
            this.lblAciklama.Name = "lblAciklama";
            this.lblAciklama.Size = new System.Drawing.Size(54, 13);
            this.lblAciklama.TabIndex = 12;
            this.lblAciklama.Text = "Açıklama:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(120, 260);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 60);
            this.txtAciklama.TabIndex = 13;
            // 
            // lblResim
            // 
            this.lblResim.AutoSize = true;
            this.lblResim.Location = new System.Drawing.Point(20, 340);
            this.lblResim.Name = "lblResim";
            this.lblResim.Size = new System.Drawing.Size(39, 13);
            this.lblResim.TabIndex = 14;
            this.lblResim.Text = "Resim:";
            // 
            // pictureBoxResim
            // 
            this.pictureBoxResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxResim.Location = new System.Drawing.Point(120, 340);
            this.pictureBoxResim.Name = "pictureBoxResim";
            this.pictureBoxResim.Size = new System.Drawing.Size(200, 150);
            this.pictureBoxResim.TabIndex = 15;
            this.pictureBoxResim.TabStop = false;
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(120, 500);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(200, 23);
            this.btnResimSec.TabIndex = 16;
            this.btnResimSec.Text = "Resim Seç";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(120, 540);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(200, 23);
            this.btnGuncelle.TabIndex = 17;
            this.btnGuncelle.Text = "Bilgileri Güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // EtkinlikGuncelleUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnGuncelle);
            this.Controls.Add(this.btnResimSec);
            this.Controls.Add(this.pictureBoxResim);
            this.Controls.Add(this.lblResim);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.lblAciklama);
            this.Controls.Add(this.txtEtkinlikYeri);
            this.Controls.Add(this.lblEtkinlikYeri);
            this.Controls.Add(this.dtpEtkinlikTarihi);
            this.Controls.Add(this.lblEtkinlikTarihi);
            this.Controls.Add(this.txtToplamKontejan);
            this.Controls.Add(this.lblToplamKontejan);
            this.Controls.Add(this.txtEtkinlikTuru);
            this.Controls.Add(this.lblEtkinlikTuru);
            this.Controls.Add(this.txtFiyat);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.txtEtkinlikAdi);
            this.Controls.Add(this.lblEtkinlikAdi);
            this.Name = "EtkinlikGuncelleUserControl";
            this.Size = new System.Drawing.Size(350, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxResim)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}
