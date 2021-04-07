namespace UI
{
    partial class PerEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PerEkran));
            this.label1 = new System.Windows.Forms.Label();
            this.btnStok = new System.Windows.Forms.Button();
            this.btnOzelDikim = new System.Windows.Forms.Button();
            this.btnToptanci = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbSoyad = new System.Windows.Forms.Label();
            this.lblAdSoyad = new System.Windows.Forms.Label();
            this.lblAdd = new System.Windows.Forms.Label();
            this.lbAd = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.StokHepsi = new System.Windows.Forms.Button();
            this.bilgiduzenle = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.LightCyan;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(114, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(473, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "PERSONEL YETKİLERİ";
            // 
            // btnStok
            // 
            this.btnStok.BackColor = System.Drawing.Color.LightCyan;
            this.btnStok.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStok.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnStok.Location = new System.Drawing.Point(33, 266);
            this.btnStok.Name = "btnStok";
            this.btnStok.Size = new System.Drawing.Size(180, 70);
            this.btnStok.TabIndex = 4;
            this.btnStok.Text = "STOK DURUMU";
            this.btnStok.UseVisualStyleBackColor = false;
            this.btnStok.Click += new System.EventHandler(this.btnStok_Click);
            // 
            // btnOzelDikim
            // 
            this.btnOzelDikim.BackColor = System.Drawing.Color.LightCyan;
            this.btnOzelDikim.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOzelDikim.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnOzelDikim.Location = new System.Drawing.Point(438, 266);
            this.btnOzelDikim.Name = "btnOzelDikim";
            this.btnOzelDikim.Size = new System.Drawing.Size(180, 70);
            this.btnOzelDikim.TabIndex = 5;
            this.btnOzelDikim.Text = "ÖZEL DİKİM RANDEVUSU";
            this.btnOzelDikim.UseVisualStyleBackColor = false;
            this.btnOzelDikim.Click += new System.EventHandler(this.btnOzelDikim_Click);
            // 
            // btnToptanci
            // 
            this.btnToptanci.BackColor = System.Drawing.Color.LightCyan;
            this.btnToptanci.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnToptanci.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnToptanci.Location = new System.Drawing.Point(233, 266);
            this.btnToptanci.Name = "btnToptanci";
            this.btnToptanci.Size = new System.Drawing.Size(180, 70);
            this.btnToptanci.TabIndex = 6;
            this.btnToptanci.Text = "TOPTANCI";
            this.btnToptanci.UseVisualStyleBackColor = false;
            this.btnToptanci.Click += new System.EventHandler(this.btnToptanci_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.LightCyan;
            this.button4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button4.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button4.Location = new System.Drawing.Point(33, 370);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(111, 49);
            this.button4.TabIndex = 7;
            this.button4.Text = "Anasayfa";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.LightCyan;
            this.button5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button5.Location = new System.Drawing.Point(540, 370);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(111, 49);
            this.button5.TabIndex = 8;
            this.button5.Text = "Çıkış";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightCyan;
            this.groupBox1.Controls.Add(this.lbSoyad);
            this.groupBox1.Controls.Add(this.lblAdSoyad);
            this.groupBox1.Controls.Add(this.lblAdd);
            this.groupBox1.Controls.Add(this.lbAd);
            this.groupBox1.Location = new System.Drawing.Point(33, 114);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personel Bilgi";
            // 
            // lbSoyad
            // 
            this.lbSoyad.AutoSize = true;
            this.lbSoyad.Location = new System.Drawing.Point(91, 64);
            this.lbSoyad.Name = "lbSoyad";
            this.lbSoyad.Size = new System.Drawing.Size(56, 17);
            this.lbSoyad.TabIndex = 5;
            this.lbSoyad.Text = "null null";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.AutoSize = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(6, 64);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(79, 17);
            this.lblAdSoyad.TabIndex = 4;
            this.lblAdSoyad.Text = "Adı Soyadı:";
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(91, 33);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(30, 17);
            this.lblAdd.TabIndex = 3;
            this.lblAdd.Text = "null";
            // 
            // lbAd
            // 
            this.lbAd.AutoSize = true;
            this.lbAd.Location = new System.Drawing.Point(6, 33);
            this.lbAd.Name = "lbAd";
            this.lbAd.Size = new System.Drawing.Size(85, 17);
            this.lbAd.TabIndex = 1;
            this.lbAd.Text = "Personel ID:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCyan;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(642, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(180, 70);
            this.button1.TabIndex = 10;
            this.button1.Text = "RANDEVULARI GÖRÜNTÜLE";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // StokHepsi
            // 
            this.StokHepsi.BackColor = System.Drawing.Color.LightCyan;
            this.StokHepsi.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.StokHepsi.ForeColor = System.Drawing.SystemColors.ControlText;
            this.StokHepsi.Location = new System.Drawing.Point(642, 178);
            this.StokHepsi.Name = "StokHepsi";
            this.StokHepsi.Size = new System.Drawing.Size(180, 70);
            this.StokHepsi.TabIndex = 11;
            this.StokHepsi.Text = "BÜTÜN STOKLAR";
            this.StokHepsi.UseVisualStyleBackColor = false;
            this.StokHepsi.Click += new System.EventHandler(this.StokHepsi_Click);
            // 
            // bilgiduzenle
            // 
            this.bilgiduzenle.AutoSize = true;
            this.bilgiduzenle.BackColor = System.Drawing.Color.LightCyan;
            this.bilgiduzenle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.bilgiduzenle.LinkColor = System.Drawing.Color.Black;
            this.bilgiduzenle.Location = new System.Drawing.Point(33, 230);
            this.bilgiduzenle.Name = "bilgiduzenle";
            this.bilgiduzenle.Size = new System.Drawing.Size(120, 17);
            this.bilgiduzenle.TabIndex = 12;
            this.bilgiduzenle.TabStop = true;
            this.bilgiduzenle.Text = "Bilgilerini Düzenle";
            this.bilgiduzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.bilgiduzenle_LinkClicked_1);
            // 
            // PerEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Orange;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(844, 435);
            this.Controls.Add(this.bilgiduzenle);
            this.Controls.Add(this.StokHepsi);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnToptanci);
            this.Controls.Add(this.btnOzelDikim);
            this.Controls.Add(this.btnStok);
            this.Controls.Add(this.label1);
            this.Name = "PerEkran";
            this.Text = "PerEkran";
            this.Load += new System.EventHandler(this.PerEkran_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStok;
        private System.Windows.Forms.Button btnOzelDikim;
        private System.Windows.Forms.Button btnToptanci;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.Label lbAd;
        private System.Windows.Forms.Label lblAdSoyad;
        private System.Windows.Forms.Label lbSoyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button StokHepsi;
        private System.Windows.Forms.LinkLabel bilgiduzenle;
    }
}