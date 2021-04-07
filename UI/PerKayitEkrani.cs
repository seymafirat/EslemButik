using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using EslemButik;
using UI;

namespace UI
{
    public partial class PerKayitEkrani : Form
    {
        public PerKayitEkrani()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();

        private void BtnKayit_Click(object sender, EventArgs e)
        {

            if (this.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).Count() > 0)
            {
                this.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => { MessageBox.Show(f.Name + " boş bırakılamaz"); });
            }
            else
            {

                SqlCommand komut = new SqlCommand("insert into Personel(PersonelAdi,PersonelSoyadi,Parola,Tel,Personel_id) values(@p1,@p2,@p3,@p4,@p5)", bgl.baglanti());
                komut.Parameters.AddWithValue("@p1", Ad.Text);
                komut.Parameters.AddWithValue("@p2", Soyad.Text);
                komut.Parameters.AddWithValue("@p3", Parola.Text);
                komut.Parameters.AddWithValue("@p4", TelefonNo.Text);
                komut.Parameters.AddWithValue("@p5", Id.Text);
                komut.ExecuteNonQuery();
                bgl.baglanti().Close();
                MessageBox.Show("Kaydınız Gerçekleşmiştir.Şifreniz:" + Parola.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

         


        }
        private void button2_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }
    }
}
