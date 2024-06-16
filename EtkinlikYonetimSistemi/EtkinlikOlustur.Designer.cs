namespace EtkinlikYonetimSistemi
{
    partial class EtkinlikOlustur
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
            this.txtEventName = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtEventType = new System.Windows.Forms.TextBox();
            this.txtTotalSlots = new System.Windows.Forms.TextBox();
            this.txtAvailableSlots = new System.Windows.Forms.TextBox();
            this.btnAddEvent = new System.Windows.Forms.Button();
            this.lblEventName = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEventType = new System.Windows.Forms.Label();
            this.lblTotalSlots = new System.Windows.Forms.Label();
            this.lblAvailableSlots = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.btnUploadImage = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.dtpEventDate = new System.Windows.Forms.DateTimePicker();
            this.txtEventLocation = new System.Windows.Forms.TextBox();
            this.lblEventDate = new System.Windows.Forms.Label();
            this.lblEventLocation = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEventName
            // 
            this.txtEventName.Location = new System.Drawing.Point(112, 10);
            this.txtEventName.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventName.Name = "txtEventName";
            this.txtEventName.Size = new System.Drawing.Size(151, 20);
            this.txtEventName.TabIndex = 0;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(112, 32);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(2);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(151, 20);
            this.txtPrice.TabIndex = 1;
            // 
            // txtEventType
            // 
            this.txtEventType.Location = new System.Drawing.Point(112, 55);
            this.txtEventType.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventType.Name = "txtEventType";
            this.txtEventType.Size = new System.Drawing.Size(151, 20);
            this.txtEventType.TabIndex = 2;
            // 
            // txtTotalSlots
            // 
            this.txtTotalSlots.Location = new System.Drawing.Point(112, 78);
            this.txtTotalSlots.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotalSlots.Name = "txtTotalSlots";
            this.txtTotalSlots.Size = new System.Drawing.Size(151, 20);
            this.txtTotalSlots.TabIndex = 3;
            // 
            // txtAvailableSlots
            // 
            this.txtAvailableSlots.Location = new System.Drawing.Point(112, 101);
            this.txtAvailableSlots.Margin = new System.Windows.Forms.Padding(2);
            this.txtAvailableSlots.Name = "txtAvailableSlots";
            this.txtAvailableSlots.Size = new System.Drawing.Size(151, 20);
            this.txtAvailableSlots.TabIndex = 4;
            // 
            // btnAddEvent
            // 
            this.btnAddEvent.Location = new System.Drawing.Point(112, 262);
            this.btnAddEvent.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddEvent.Name = "btnAddEvent";
            this.btnAddEvent.Size = new System.Drawing.Size(151, 30);
            this.btnAddEvent.TabIndex = 5;
            this.btnAddEvent.Text = "Etkinlik Ekle";
            this.btnAddEvent.UseVisualStyleBackColor = true;
            this.btnAddEvent.Click += new System.EventHandler(this.btnAddEvent_Click);
            // 
            // lblEventName
            // 
            this.lblEventName.AutoSize = true;
            this.lblEventName.Location = new System.Drawing.Point(9, 12);
            this.lblEventName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventName.Name = "lblEventName";
            this.lblEventName.Size = new System.Drawing.Size(59, 13);
            this.lblEventName.TabIndex = 6;
            this.lblEventName.Text = "Etkinlik Adı";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Location = new System.Drawing.Point(9, 35);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(29, 13);
            this.lblPrice.TabIndex = 7;
            this.lblPrice.Text = "Fiyat";
            // 
            // lblEventType
            // 
            this.lblEventType.AutoSize = true;
            this.lblEventType.Location = new System.Drawing.Point(9, 58);
            this.lblEventType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventType.Name = "lblEventType";
            this.lblEventType.Size = new System.Drawing.Size(66, 13);
            this.lblEventType.TabIndex = 8;
            this.lblEventType.Text = "Etkinlik Türü";
            // 
            // lblTotalSlots
            // 
            this.lblTotalSlots.AutoSize = true;
            this.lblTotalSlots.Location = new System.Drawing.Point(9, 80);
            this.lblTotalSlots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTotalSlots.Name = "lblTotalSlots";
            this.lblTotalSlots.Size = new System.Drawing.Size(87, 13);
            this.lblTotalSlots.TabIndex = 9;
            this.lblTotalSlots.Text = "Toplam Kontejan";
            // 
            // lblAvailableSlots
            // 
            this.lblAvailableSlots.AutoSize = true;
            this.lblAvailableSlots.Location = new System.Drawing.Point(9, 103);
            this.lblAvailableSlots.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAvailableSlots.Name = "lblAvailableSlots";
            this.lblAvailableSlots.Size = new System.Drawing.Size(88, 13);
            this.lblAvailableSlots.TabIndex = 10;
            this.lblAvailableSlots.Text = "Mevcut Kontejan";
            // 
            // pictureBox
            // 
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(285, 10);
            this.pictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(150, 109);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 11;
            this.pictureBox.TabStop = false;
            // 
            // btnUploadImage
            // 
            this.btnUploadImage.Location = new System.Drawing.Point(285, 124);
            this.btnUploadImage.Margin = new System.Windows.Forms.Padding(2);
            this.btnUploadImage.Name = "btnUploadImage";
            this.btnUploadImage.Size = new System.Drawing.Size(150, 19);
            this.btnUploadImage.TabIndex = 12;
            this.btnUploadImage.Text = "Resim Yükle";
            this.btnUploadImage.UseVisualStyleBackColor = true;
            this.btnUploadImage.Click += new System.EventHandler(this.btnUploadImage_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            // 
            // dtpEventDate
            // 
            this.dtpEventDate.Location = new System.Drawing.Point(112, 124);
            this.dtpEventDate.Name = "dtpEventDate";
            this.dtpEventDate.Size = new System.Drawing.Size(151, 20);
            this.dtpEventDate.TabIndex = 13;
            // 
            // txtEventLocation
            // 
            this.txtEventLocation.Location = new System.Drawing.Point(112, 147);
            this.txtEventLocation.Margin = new System.Windows.Forms.Padding(2);
            this.txtEventLocation.Name = "txtEventLocation";
            this.txtEventLocation.Size = new System.Drawing.Size(151, 20);
            this.txtEventLocation.TabIndex = 14;
            // 
            // lblEventDate
            // 
            this.lblEventDate.AutoSize = true;
            this.lblEventDate.Location = new System.Drawing.Point(9, 127);
            this.lblEventDate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventDate.Name = "lblEventDate";
            this.lblEventDate.Size = new System.Drawing.Size(70, 13);
            this.lblEventDate.TabIndex = 15;
            this.lblEventDate.Text = "Etkinlik Tarihi";
            // 
            // lblEventLocation
            // 
            this.lblEventLocation.AutoSize = true;
            this.lblEventLocation.Location = new System.Drawing.Point(9, 150);
            this.lblEventLocation.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEventLocation.Name = "lblEventLocation";
            this.lblEventLocation.Size = new System.Drawing.Size(70, 13);
            this.lblEventLocation.TabIndex = 16;
            this.lblEventLocation.Text = "Etkinlik Yeri";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(112, 170);
            this.txtDescription.Margin = new System.Windows.Forms.Padding(2);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(151, 80);
            this.txtDescription.TabIndex = 17;
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(9, 173);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(50, 13);
            this.lblDescription.TabIndex = 18;
            this.lblDescription.Text = "Açıklama";
            // 
            // EtkinlikOlustur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 303);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.lblEventLocation);
            this.Controls.Add(this.txtEventLocation);
            this.Controls.Add(this.lblEventDate);
            this.Controls.Add(this.dtpEventDate);
            this.Controls.Add(this.btnUploadImage);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.lblAvailableSlots);
            this.Controls.Add(this.lblTotalSlots);
            this.Controls.Add(this.lblEventType);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEventName);
            this.Controls.Add(this.btnAddEvent);
            this.Controls.Add(this.txtAvailableSlots);
            this.Controls.Add(this.txtTotalSlots);
            this.Controls.Add(this.txtEventType);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtEventName);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "EtkinlikOlustur";
            this.Text = "Etkinlik Oluştur";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private System.Windows.Forms.TextBox txtEventName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtEventType;
        private System.Windows.Forms.TextBox txtTotalSlots;
        private System.Windows.Forms.TextBox txtAvailableSlots;
        private System.Windows.Forms.Button btnAddEvent;
        private System.Windows.Forms.Label lblEventName;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEventType;
        private System.Windows.Forms.Label lblTotalSlots;
        private System.Windows.Forms.Label lblAvailableSlots;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button btnUploadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.DateTimePicker dtpEventDate;
        private System.Windows.Forms.TextBox txtEventLocation;
        private System.Windows.Forms.Label lblEventDate;
        private System.Windows.Forms.Label lblEventLocation;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Label lblDescription;
    }
}
