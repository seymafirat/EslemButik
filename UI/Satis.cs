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
    public partial class Satis : Form
    {
        public Satis()
        {
            InitializeComponent();
        }

        sqlBaglanti bgl = new sqlBaglanti();
        string Fiyat;
        private void kaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * from Stok where UrunKodu=@p2", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p2", txturunkod.Text);
            SqlDataReader dr = komut2.ExecuteReader();
            if (dr.Read())
            {
                Fiyat = dr["Fiyat"].ToString();

                Tutar.Text = Fiyat;

            }


            else
            {
                //MessageBox.Show("Ürün Kodunu yanlış girdiniz.");
            }
         
            SqlCommand komut = new SqlCommand("INSERT into Satis(MusteriAdSoyad,UrunKodu,Personel_id,OdemeTuru,OdenenUcret ) values(@p1, @p2, @p3, @p4 ,@p5)",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txturunkod.Text);
            komut.Parameters.AddWithValue("@p3", cmbperid.Text);
            komut.Parameters.AddWithValue("@p4", cmbodeme.Text);
            komut.Parameters.AddWithValue("@p5", Tutar.Text);

            komut.ExecuteNonQuery();
            bgl.baglanti().Close();

            MessageBox.Show("Satış Gerçekleşmiştir.");


           




        }

        private void Satis_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select OdemeTuru from OdemeTuru ", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbodeme.Items.Add(dr[0]);
            }
            bgl.baglanti().Close();


            SqlCommand komut2 = new SqlCommand("Select Personel_id from Personel ", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbperid.Items.Add(dr2[0]);
            }
            bgl.baglanti().Close();



        }

        private void txturunkod_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txttutar_TextChanged(object sender, EventArgs e)
        {
          
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliGirisi y = new YetkiliGirisi();
            y.Show();
            this.Hide();
        }
    }
}
