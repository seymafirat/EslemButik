using EslemButik;
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


namespace UI
{
    public partial class PersonelGiris : Form
    {
        public PersonelGiris()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void btnGiris_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select * from Personel where Personel_id=@p5 and Parola=@p3", bgl.baglanti());
            komut.Parameters.AddWithValue("@p5", txtId.Text);
            komut.Parameters.AddWithValue("@p3", txtParola.Text);
            SqlDataReader dr = komut.ExecuteReader(); //komuttan gelen değerleri oku
            if (dr.Read())
            {
                txtId.ToString();
                if (txtId.Text=="44")
                {
                    YetkiliGirisi y = new YetkiliGirisi();
                    y.Show();
                    this.Hide();
                }
                else
                {
                    PerEkran p = new PerEkran();
                    p.PerId = txtId.Text;
                    p.Show();
                    this.Hide();
                }
             

            }
            else
            {
                MessageBox.Show("Hatalı ID veya şifre");
            }

            bgl.baglanti().Close();
           
        }
        private void button2_Click(object sender, EventArgs e)
        {
            Personel a = new Personel();
            a.Show();
            this.Hide();
        }
    }
}
