namespace EtkinlikYonetimSistemi
{
    partial class ProfilDuzenle
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblAd;
        private System.Windows.Forms.Label lblSoyad;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblTelefon;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblDTarihi;
        private System.Windows.Forms.Label lblCinsiyet;
        private System.Windows.Forms.TextBox txtAd;
        private System.Windows.Forms.TextBox txtSoyad;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtTelefon;
        private System.Windows.Forms.TextBox txtAdres;
        private System.Windows.Forms.DateTimePicker dtpDTarihi;
        private System.Windows.Forms.ComboBox cmbCinsiyet;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnSifreDegistir;

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
            this.txtAd = new System.Windows.Forms.TextBox();
            this.txtSoyad = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdres = new System.Windows.Forms.TextBox();
            this.dtpDTarihi = new System.Windows.Forms.DateTimePicker();
            this.cmbCinsiyet = new System.Windows.Forms.ComboBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnSifreDegistir = new System.Windows.Forms.Button();
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
            this.lblDTarihi.Size = new System.Drawing.Size(73, 13);
            this.lblDTarihi.TabIndex = 5;
            this.lblDTarihi.Text = "Doğum Tarihi:";
            // 
            // lblCinsiyet
            // 
            this.lblCinsiyet.AutoSize = true;
            this.lblCinsiyet.Location = new System.Drawing.Point(30, 210);
            this.lblCinsiyet.Name = "lblCinsiyet";
            this.lblCinsiyet.Size = new System.Drawing.Size(46, 13);
            this.lblCinsiyet.TabIndex = 6;
            this.lblCinsiyet.Text = "Cinsiyet:";
            // 
            // txtAd
            // 
            this.txtAd.Location = new System.Drawing.Point(119, 27);
            this.txtAd.Name = "txtAd";
            this.txtAd.Size = new System.Drawing.Size(150, 20);
            this.txtAd.TabIndex = 7;
            // 
            // txtSoyad
            // 
            this.txtSoyad.Location = new System.Drawing.Point(119, 60);
            this.txtSoyad.Name = "txtSoyad";
            this.txtSoyad.Size = new System.Drawing.Size(150, 20);
            this.txtSoyad.TabIndex = 8;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(119, 90);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(150, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // txtTelefon
            // 
            this.txtTelefon.Location = new System.Drawing.Point(119, 120);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(150, 20);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtAdres
            // 
            this.txtAdres.Location = new System.Drawing.Point(119, 150);
            this.txtAdres.Name = "txtAdres";
            this.txtAdres.Size = new System.Drawing.Size(150, 20);
            this.txtAdres.TabIndex = 11;
            // 
            // dtpDTarihi
            // 
            this.dtpDTarihi.Location = new System.Drawing.Point(119, 180);
            this.dtpDTarihi.Name = "dtpDTarihi";
            this.dtpDTarihi.Size = new System.Drawing.Size(150, 20);
            this.dtpDTarihi.TabIndex = 12;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCinsiyet.FormattingEnabled = true;
            this.cmbCinsiyet.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Location = new System.Drawing.Point(119, 210);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Size = new System.Drawing.Size(150, 21);
            this.cmbCinsiyet.TabIndex = 13;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(100, 240);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(150, 23);
            this.btnSave.TabIndex = 14;
            this.btnSave.Text = "Kaydet";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnSifreDegistir
            // 
            this.btnSifreDegistir.Location = new System.Drawing.Point(100, 270);
            this.btnSifreDegistir.Name = "btnSifreDegistir";
            this.btnSifreDegistir.Size = new System.Drawing.Size(150, 23);
            this.btnSifreDegistir.TabIndex = 15;
            this.btnSifreDegistir.Text = "Şifre Değiştir";
            this.btnSifreDegistir.UseVisualStyleBackColor = true;
            this.btnSifreDegistir.Click += new System.EventHandler(this.btnSifreDegistir_Click);
            // 
            // ProfilDuzenle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 308);
            this.Controls.Add(this.btnSifreDegistir);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.cmbCinsiyet);
            this.Controls.Add(this.dtpDTarihi);
            this.Controls.Add(this.txtAdres);
            this.Controls.Add(this.txtTelefon);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtSoyad);
            this.Controls.Add(this.txtAd);
            this.Controls.Add(this.lblCinsiyet);
            this.Controls.Add(this.lblDTarihi);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.lblTelefon);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblSoyad);
            this.Controls.Add(this.lblAd);
            this.Name = "ProfilDuzenle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Profil Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}