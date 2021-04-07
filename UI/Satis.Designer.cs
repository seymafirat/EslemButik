namespace UI
{
    partial class Satis
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
            this.txtadsoyad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txturunkod = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.kaydet = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.cmbodeme = new System.Windows.Forms.ComboBox();
            this.Tutar = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbperid = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtadsoyad
            // 
            this.txtadsoyad.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtadsoyad.Location = new System.Drawing.Point(305, 65);
            this.txtadsoyad.Multiline = true;
            this.txtadsoyad.Name = "txtadsoyad";
            this.txtadsoyad.Size = new System.Drawing.Size(180, 37);
            this.txtadsoyad.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(81, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Müşteri Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(159, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ürün Kodu:";
            // 
            // txturunkod
            // 
            this.txturunkod.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txturunkod.Location = new System.Drawing.Point(302, 126);
            this.txturunkod.Multiline = true;
            this.txturunkod.Name = "txturunkod";
            this.txturunkod.Size = new System.Drawing.Size(180, 37);
            this.txturunkod.TabIndex = 2;
            this.txturunkod.TextChanged += new System.EventHandler(this.txturunkod_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(155, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "Personel ID:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(145, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 26);
            this.label4.TabIndex = 7;
            this.label4.Text = "Ödeme Türü:";
            // 
            // kaydet
            // 
            this.kaydet.BackColor = System.Drawing.Color.MistyRose;
            this.kaydet.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.kaydet.Location = new System.Drawing.Point(322, 384);
            this.kaydet.Name = "kaydet";
            this.kaydet.Size = new System.Drawing.Size(120, 52);
            this.kaydet.TabIndex = 11;
            this.kaydet.Text = "Kaydet";
            this.kaydet.UseVisualStyleBackColor = false;
            this.kaydet.Click += new System.EventHandler(this.kaydet_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.MistyRose;
            this.button2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.Location = new System.Drawing.Point(105, 384);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(68, 52);
            this.button2.TabIndex = 12;
            this.button2.Text = "Geri";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbodeme
            // 
            this.cmbodeme.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbodeme.FormattingEnabled = true;
            this.cmbodeme.Location = new System.Drawing.Point(302, 262);
            this.cmbodeme.Name = "cmbodeme";
            this.cmbodeme.Size = new System.Drawing.Size(179, 34);
            this.cmbodeme.TabIndex = 4;
            // 
            // Tutar
            // 
            this.Tutar.AutoSize = true;
            this.Tutar.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Tutar.Location = new System.Drawing.Point(296, 320);
            this.Tutar.Name = "Tutar";
            this.Tutar.Size = new System.Drawing.Size(0, 32);
            this.Tutar.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(101, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(185, 26);
            this.label5.TabIndex = 9;
            this.label5.Text = "Ödenecek Tutar:";
            // 
            // cmbperid
            // 
            this.cmbperid.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbperid.FormattingEnabled = true;
            this.cmbperid.Location = new System.Drawing.Point(302, 198);
            this.cmbperid.Name = "cmbperid";
            this.cmbperid.Size = new System.Drawing.Size(179, 34);
            this.cmbperid.TabIndex = 3;
            // 
            // Satis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MistyRose;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.cmbperid);
            this.Controls.Add(this.Tutar);
            this.Controls.Add(this.cmbodeme);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.kaydet);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txturunkod);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtadsoyad);
            this.Name = "Satis";
            this.Text = "Satis";
            this.Load += new System.EventHandler(this.Satis_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtadsoyad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txturunkod;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button kaydet;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbodeme;
        private System.Windows.Forms.Label Tutar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbperid;
    }
}