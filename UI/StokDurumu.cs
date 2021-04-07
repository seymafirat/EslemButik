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
    public partial class StokDurumu : Form
    {
        public StokDurumu()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();
        public string Adet;
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * from Stok where UrunKodu=@p1 and Beden=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", cmbkod.Text);
            komut2.Parameters.AddWithValue("@p2", cmbbeden.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                Adet = dr["Adet"].ToString();

               label6.Text = Adet;
                MessageBox.Show("Kalan Adet:"+label6.Text );

            }


            else
            {
                //MessageBox.Show("Ürün Kodunu yanlış girdiniz.");
            }

           
        }

        private void StokDurumu_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select SubeAdi from Subeler", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbSube.Items.Add(dr[0]);

            }
            bgl.baglanti().Close();

            SqlCommand komut2 = new SqlCommand("Select distinct UrunKategorisi from Stok", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbkategori.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();


            SqlCommand komut3 = new SqlCommand("Select distinct UrunKodu from Stok", bgl.baglanti());
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbkod.Items.Add(dr3[0]);

            }
            bgl.baglanti().Close();
        }

        private void cmbkategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbkod.Items.Clear();
            SqlCommand komut = new SqlCommand("Select distinct UrunKodu From Stok where UrunKategorisi=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbkategori.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbkod.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();
        }

       

        private void cmbSube_SelectedIndexChanged(object sender, EventArgs e)
        {
           


        }

        private void cmbkod_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            cmbbeden.Items.Clear();
            SqlCommand komut = new SqlCommand("Select distinct Beden From Stok where UrunKodu=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", cmbkod.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbbeden.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();



        }

        private void btngeri_Click(object sender, EventArgs e)
        {
            PerEkran per = new PerEkran();
            per.Show();
            this.Hide();
        }
    }
}
