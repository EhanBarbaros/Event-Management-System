using System.Drawing;

namespace EtkinlikYonetimSistemi
{
    partial class EtkinlikKarti
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

        private void InitializeComponent()
        {
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblFiyat = new System.Windows.Forms.Label();
            this.lblEtkinlikAdi = new System.Windows.Forms.Label();
            this.lblKontejan = new System.Windows.Forms.Label();
            this.lblMevcutKatılımcı = new System.Windows.Forms.Label();
            this.lblEtkinlikTuru = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(300, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblFiyat
            // 
            this.lblFiyat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFiyat.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblFiyat.ForeColor = System.Drawing.Color.White;
            this.lblFiyat.Location = new System.Drawing.Point(200, 0);
            this.lblFiyat.Name = "lblFiyat";
            this.lblFiyat.Size = new System.Drawing.Size(100, 30);
            this.lblFiyat.TabIndex = 1;
            this.lblFiyat.Text = "Fiyat";
            this.lblFiyat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEtkinlikAdi
            // 
            this.lblEtkinlikAdi.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEtkinlikAdi.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblEtkinlikAdi.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikAdi.ForeColor = System.Drawing.Color.White;
            this.lblEtkinlikAdi.Location = new System.Drawing.Point(0, 200);
            this.lblEtkinlikAdi.Name = "lblEtkinlikAdi";
            this.lblEtkinlikAdi.Size = new System.Drawing.Size(300, 30);
            this.lblEtkinlikAdi.TabIndex = 2;
            this.lblEtkinlikAdi.Text = "Etkinlik Adı";
            this.lblEtkinlikAdi.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblKontejan
            // 
            this.lblKontejan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblKontejan.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblKontejan.ForeColor = System.Drawing.Color.White;
            this.lblKontejan.Location = new System.Drawing.Point(0, 170);
            this.lblKontejan.Name = "lblKontejan";
            this.lblKontejan.Size = new System.Drawing.Size(150, 30);
            this.lblKontejan.TabIndex = 3;
            this.lblKontejan.Text = "Kontejan";
            this.lblKontejan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMevcutKatılımcı
            // 
            this.lblMevcutKatılımcı.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMevcutKatılımcı.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblMevcutKatılımcı.ForeColor = System.Drawing.Color.White;
            this.lblMevcutKatılımcı.Location = new System.Drawing.Point(150, 170);
            this.lblMevcutKatılımcı.Name = "lblMevcutKatılımcı";
            this.lblMevcutKatılımcı.Size = new System.Drawing.Size(150, 30);
            this.lblMevcutKatılımcı.TabIndex = 4;
            this.lblMevcutKatılımcı.Text = "Mevcut Katılımcı";
            this.lblMevcutKatılımcı.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEtkinlikTuru
            // 
            this.lblEtkinlikTuru.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblEtkinlikTuru.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold);
            this.lblEtkinlikTuru.ForeColor = System.Drawing.Color.White;
            this.lblEtkinlikTuru.Location = new System.Drawing.Point(0, 0);
            this.lblEtkinlikTuru.Name = "lblEtkinlikTuru";
            this.lblEtkinlikTuru.Size = new System.Drawing.Size(150, 30);
            this.lblEtkinlikTuru.TabIndex = 5;
            this.lblEtkinlikTuru.Text = "Etkinlik Türü";
            this.lblEtkinlikTuru.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // EtkinlikKarti
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEtkinlikAdi);
            this.Controls.Add(this.lblKontejan);
            this.Controls.Add(this.lblMevcutKatılımcı);
            this.Controls.Add(this.lblEtkinlikTuru);
            this.Controls.Add(this.lblFiyat);
            this.Controls.Add(this.pictureBox1);
            this.Name = "EtkinlikKarti";
            this.Size = new System.Drawing.Size(300, 250);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblFiyat;
        private System.Windows.Forms.Label lblEtkinlikAdi;
        private System.Windows.Forms.Label lblKontejan;
        private System.Windows.Forms.Label lblMevcutKatılımcı;
        private System.Windows.Forms.Label lblEtkinlikTuru;
    }
}
