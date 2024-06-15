using System.Drawing;
using System.Windows.Forms;

namespace EtkinlikYonetimSistemi
{
    partial class form_ilk
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.btn_GirisYap = new System.Windows.Forms.Button();
            this.lbl_kullaniciAdi = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lbl_hosgeldiniz = new System.Windows.Forms.Label();
            this.lbl_sifre = new System.Windows.Forms.Label();
            this.txt_kullaniciAdi = new System.Windows.Forms.TextBox();
            this.txt_sifre = new System.Windows.Forms.TextBox();
            this.lbl_girisyapiniz = new System.Windows.Forms.Label();
            this.lbl_Kayitlidegilmi = new System.Windows.Forms.Label();
            this.btn_GirisFormKayitOl = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_GirisYap
            // 
            this.btn_GirisYap.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btn_GirisYap.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GirisYap.Location = new System.Drawing.Point(487, 336);
            this.btn_GirisYap.Name = "btn_GirisYap";
            this.btn_GirisYap.Size = new System.Drawing.Size(123, 50);
            this.btn_GirisYap.TabIndex = 2;
            this.btn_GirisYap.Text = "Giriş Yap";
            this.btn_GirisYap.UseVisualStyleBackColor = false;
            this.btn_GirisYap.Click += new System.EventHandler(this.btn_GirisYap_Click);
            // 
            // lbl_kullaniciAdi
            // 
            this.lbl_kullaniciAdi.AutoSize = true;
            this.lbl_kullaniciAdi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_kullaniciAdi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.lbl_kullaniciAdi.Location = new System.Drawing.Point(361, 164);
            this.lbl_kullaniciAdi.Name = "lbl_kullaniciAdi";
            this.lbl_kullaniciAdi.Size = new System.Drawing.Size(104, 19);
            this.lbl_kullaniciAdi.TabIndex = 3;
            this.lbl_kullaniciAdi.Text = "Kullanıcı Adı";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Location = new System.Drawing.Point(0, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(61, 469);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Location = new System.Drawing.Point(88, -1);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(52, 469);
            this.panel2.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel3.Location = new System.Drawing.Point(172, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(57, 469);
            this.panel3.TabIndex = 6;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel4.Location = new System.Drawing.Point(139, -1);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(37, 472);
            this.panel4.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panel5.Location = new System.Drawing.Point(55, -1);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(33, 475);
            this.panel5.TabIndex = 8;
            // 
            // lbl_hosgeldiniz
            // 
            this.lbl_hosgeldiniz.AutoSize = true;
            this.lbl_hosgeldiniz.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hosgeldiniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.lbl_hosgeldiniz.Location = new System.Drawing.Point(272, 22);
            this.lbl_hosgeldiniz.Name = "lbl_hosgeldiniz";
            this.lbl_hosgeldiniz.Size = new System.Drawing.Size(253, 46);
            this.lbl_hosgeldiniz.TabIndex = 0;
            this.lbl_hosgeldiniz.Text = "Hoşgeldiniz!";
            // 
            // lbl_sifre
            // 
            this.lbl_sifre.AutoSize = true;
            this.lbl_sifre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sifre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.lbl_sifre.Location = new System.Drawing.Point(361, 250);
            this.lbl_sifre.Name = "lbl_sifre";
            this.lbl_sifre.Size = new System.Drawing.Size(45, 19);
            this.lbl_sifre.TabIndex = 9;
            this.lbl_sifre.Text = "Şifre";
            // 
            // txt_kullaniciAdi
            // 
            this.txt_kullaniciAdi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_kullaniciAdi.Location = new System.Drawing.Point(364, 194);
            this.txt_kullaniciAdi.Name = "txt_kullaniciAdi";
            this.txt_kullaniciAdi.Size = new System.Drawing.Size(246, 27);
            this.txt_kullaniciAdi.TabIndex = 10;
            // 
            // txt_sifre
            // 
            this.txt_sifre.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_sifre.Location = new System.Drawing.Point(364, 289);
            this.txt_sifre.Name = "txt_sifre";
            this.txt_sifre.Size = new System.Drawing.Size(246, 27);
            this.txt_sifre.TabIndex = 11;
            // 
            // lbl_girisyapiniz
            // 
            this.lbl_girisyapiniz.AutoSize = true;
            this.lbl_girisyapiniz.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_girisyapiniz.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.lbl_girisyapiniz.Location = new System.Drawing.Point(276, 90);
            this.lbl_girisyapiniz.Name = "lbl_girisyapiniz";
            this.lbl_girisyapiniz.Size = new System.Drawing.Size(184, 23);
            this.lbl_girisyapiniz.TabIndex = 12;
            this.lbl_girisyapiniz.Text = "Lütfen Giriş Yapınız";
            // 
            // lbl_Kayitlidegilmi
            // 
            this.lbl_Kayitlidegilmi.AutoSize = true;
            this.lbl_Kayitlidegilmi.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Kayitlidegilmi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(82)))));
            this.lbl_Kayitlidegilmi.Location = new System.Drawing.Point(361, 412);
            this.lbl_Kayitlidegilmi.Name = "lbl_Kayitlidegilmi";
            this.lbl_Kayitlidegilmi.Size = new System.Drawing.Size(194, 19);
            this.lbl_Kayitlidegilmi.TabIndex = 13;
            this.lbl_Kayitlidegilmi.Text = "Henüz kayıtlı değil misin?";
            // 
            // btn_GirisFormKayitOl
            // 
            this.btn_GirisFormKayitOl.BackColor = System.Drawing.SystemColors.Control;
            this.btn_GirisFormKayitOl.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_GirisFormKayitOl.ForeColor = System.Drawing.Color.Blue;
            this.btn_GirisFormKayitOl.Location = new System.Drawing.Point(561, 410);
            this.btn_GirisFormKayitOl.Name = "btn_GirisFormKayitOl";
            this.btn_GirisFormKayitOl.Size = new System.Drawing.Size(70, 24);
            this.btn_GirisFormKayitOl.TabIndex = 14;
            this.btn_GirisFormKayitOl.Text = "Kayıt Ol";
            this.btn_GirisFormKayitOl.UseVisualStyleBackColor = false;
            this.btn_GirisFormKayitOl.Click += new System.EventHandler(this.btn_GirisFormKayitOl_Click);
            // 
            // form_ilk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 467);
            this.Controls.Add(this.btn_GirisFormKayitOl);
            this.Controls.Add(this.lbl_Kayitlidegilmi);
            this.Controls.Add(this.lbl_girisyapiniz);
            this.Controls.Add(this.txt_sifre);
            this.Controls.Add(this.txt_kullaniciAdi);
            this.Controls.Add(this.lbl_sifre);
            this.Controls.Add(this.lbl_hosgeldiniz);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_kullaniciAdi);
            this.Controls.Add(this.btn_GirisYap);
            this.Name = "form_ilk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Etkinlik Yönetim Sistemi";
            this.ResumeLayout(false);
            this.PerformLayout();

            //tam ekran olmasını engellemek için kod 
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.WindowState = FormWindowState.Normal;

        }



        #endregion
        private System.Windows.Forms.Button btn_GirisYap;
        private System.Windows.Forms.Label lbl_kullaniciAdi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbl_hosgeldiniz;
        private System.Windows.Forms.Label lbl_sifre;
        private System.Windows.Forms.TextBox txt_kullaniciAdi;
        private System.Windows.Forms.TextBox txt_sifre;
        private System.Windows.Forms.Label lbl_girisyapiniz;
        private System.Windows.Forms.Label lbl_Kayitlidegilmi;
        private System.Windows.Forms.Button btn_GirisFormKayitOl;
    }
}

