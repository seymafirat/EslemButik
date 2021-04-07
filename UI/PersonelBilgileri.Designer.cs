namespace UI
{
    partial class PersonelBilgileri
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Id = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TelefonNo = new System.Windows.Forms.MaskedTextBox();
            this.Parola = new System.Windows.Forms.TextBox();
            this.Soyad = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.Ad = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(478, 99);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(712, 573);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(397, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(347, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "PERSONELLER";
            // 
            // Id
            // 
            this.Id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Id.Location = new System.Drawing.Point(171, 315);
            this.Id.Multiline = true;
            this.Id.Name = "Id";
            this.Id.Size = new System.Drawing.Size(195, 34);
            this.Id.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(33, 322);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 27);
            this.label6.TabIndex = 24;
            this.label6.Text = "Personel ID:";
            // 
            // TelefonNo
            // 
            this.TelefonNo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TelefonNo.Location = new System.Drawing.Point(174, 270);
            this.TelefonNo.Mask = "(999) 000-0000";
            this.TelefonNo.Name = "TelefonNo";
            this.TelefonNo.Size = new System.Drawing.Size(192, 30);
            this.TelefonNo.TabIndex = 18;
            // 
            // Parola
            // 
            this.Parola.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Parola.Location = new System.Drawing.Point(171, 364);
            this.Parola.Multiline = true;
            this.Parola.Name = "Parola";
            this.Parola.PasswordChar = '*';
            this.Parola.Size = new System.Drawing.Size(195, 34);
            this.Parola.TabIndex = 22;
            // 
            // Soyad
            // 
            this.Soyad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Soyad.Location = new System.Drawing.Point(171, 210);
            this.Soyad.Multiline = true;
            this.Soyad.Name = "Soyad";
            this.Soyad.Size = new System.Drawing.Size(195, 34);
            this.Soyad.TabIndex = 16;
            // 
            // BtnEkle
            // 
            this.BtnEkle.BackColor = System.Drawing.Color.Gold;
            this.BtnEkle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnEkle.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BtnEkle.Location = new System.Drawing.Point(193, 425);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(118, 54);
            this.BtnEkle.TabIndex = 23;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = false;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // Ad
            // 
            this.Ad.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Ad.Location = new System.Drawing.Point(174, 155);
            this.Ad.Multiline = true;
            this.Ad.Name = "Ad";
            this.Ad.Size = new System.Drawing.Size(195, 34);
            this.Ad.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(85, 364);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 27);
            this.label5.TabIndex = 21;
            this.label5.Text = "Parola:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(43, 270);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 27);
            this.label4.TabIndex = 19;
            this.label4.Text = "Telefon No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(85, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 27);
            this.label3.TabIndex = 17;
            this.label3.Text = "Soyadı:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(112, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 27);
            this.label2.TabIndex = 15;
            this.label2.Text = "Adı:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Gold;
            this.button1.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Location = new System.Drawing.Point(193, 496);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 54);
            this.button1.TabIndex = 25;
            this.button1.Text = "Sil";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // PersonelBilgileri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(1202, 738);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Id);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.TelefonNo);
            this.Controls.Add(this.Parola);
            this.Controls.Add(this.Soyad);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.Ad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "PersonelBilgileri";
            this.Text = "PersonelBilgileri";
            this.Load += new System.EventHandler(this.PersonelBilgileri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Id;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox TelefonNo;
        private System.Windows.Forms.TextBox Parola;
        private System.Windows.Forms.TextBox Soyad;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox Ad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}