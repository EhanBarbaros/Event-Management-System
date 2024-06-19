namespace EtkinlikYonetimSistemi
{
    partial class KullaniciYonetimUserControl
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

        #region Component Designer generated code

        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.lblKullanicilar = new System.Windows.Forms.Label();
            this.lblEtkinlikler = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.btnKullanicilar = new System.Windows.Forms.Button();
            this.btnEtkinlikler = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.lblKullanicilar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.lblEtkinlikler);
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 400;
            this.splitContainer1.TabIndex = 0;
            // 
            // lblKullanicilar
            // 
            this.lblKullanicilar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblKullanicilar.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKullanicilar.Location = new System.Drawing.Point(0, 0);
            this.lblKullanicilar.Name = "lblKullanicilar";
            this.lblKullanicilar.Size = new System.Drawing.Size(400, 450);
            this.lblKullanicilar.TabIndex = 0;
            this.lblKullanicilar.Text = "KULLANICILAR";
            this.lblKullanicilar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblKullanicilar.Click += new System.EventHandler(this.lblKullanicilar_Click);
            this.lblKullanicilar.MouseEnter += new System.EventHandler(this.lblKullanicilar_MouseEnter);
            this.lblKullanicilar.MouseLeave += new System.EventHandler(this.lblKullanicilar_MouseLeave);
            // 
            // lblEtkinlikler
            // 
            this.lblEtkinlikler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblEtkinlikler.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEtkinlikler.Location = new System.Drawing.Point(0, 0);
            this.lblEtkinlikler.Name = "lblEtkinlikler";
            this.lblEtkinlikler.Size = new System.Drawing.Size(396, 450);
            this.lblEtkinlikler.TabIndex = 1;
            this.lblEtkinlikler.Text = "ETKİNLİKLER";
            this.lblEtkinlikler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblEtkinlikler.Click += new System.EventHandler(this.lblEtkinlikler_Click);
            this.lblEtkinlikler.MouseEnter += new System.EventHandler(this.lblEtkinlikler_MouseEnter);
            this.lblEtkinlikler.MouseLeave += new System.EventHandler(this.lblEtkinlikler_MouseLeave);
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView.Location = new System.Drawing.Point(0, 50);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(800, 400);
            this.dataGridView.TabIndex = 0;
            this.dataGridView.Visible = false;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            // 
            // panelButtons
            // 
            this.panelButtons.Controls.Add(this.btnKullanicilar);
            this.panelButtons.Controls.Add(this.btnEtkinlikler);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(800, 50);
            this.panelButtons.TabIndex = 1;
            this.panelButtons.Visible = false;
            // 
            // btnKullanicilar
            // 
            this.btnKullanicilar.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKullanicilar.Location = new System.Drawing.Point(310, 10);
            this.btnKullanicilar.Name = "btnKullanicilar";
            this.btnKullanicilar.Size = new System.Drawing.Size(75, 23);
            this.btnKullanicilar.TabIndex = 0;
            this.btnKullanicilar.Text = "Kullanıcılar";
            this.btnKullanicilar.UseVisualStyleBackColor = true;
            this.btnKullanicilar.Click += new System.EventHandler(this.btnKullanicilar_Click);
            // 
            // btnEtkinlikler
            // 
            this.btnEtkinlikler.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnEtkinlikler.Location = new System.Drawing.Point(410, 10);
            this.btnEtkinlikler.Name = "btnEtkinlikler";
            this.btnEtkinlikler.Size = new System.Drawing.Size(75, 23);
            this.btnEtkinlikler.TabIndex = 1;
            this.btnEtkinlikler.Text = "Etkinlikler";
            this.btnEtkinlikler.UseVisualStyleBackColor = true;
            this.btnEtkinlikler.Click += new System.EventHandler(this.btnEtkinlikler_Click);
            // 
            // KullaniciYonetimUserControl
            // 
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.panelButtons);
            this.Controls.Add(this.splitContainer1);
            this.Name = "KullaniciYonetimUserControl";
            this.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label lblKullanicilar;
        private System.Windows.Forms.Label lblEtkinlikler;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Button btnKullanicilar;
        private System.Windows.Forms.Button btnEtkinlikler;
    }
}
