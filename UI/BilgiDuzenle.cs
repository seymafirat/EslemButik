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
    public partial class BilgiDuzenle : Form
    {
        public BilgiDuzenle()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        public string id;

        private void BilgiDuzenle_Load(object sender, EventArgs e)
        {
            txtId.Text= id;
            SqlCommand komut = new SqlCommand("Select * From Personel where Personel_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtId.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while(dr.Read())
            {
                txtAd.Text = dr[0].ToString();
                txtSoyad.Text = dr[1].ToString();
                txtNumara.Text = dr[3].ToString();
                txtParola.Text = dr[2].ToString();
            }
            bgl.baglanti().Close();
        }

        private void BtnKayit_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Update Personel set PersonelAdi=@p1,PersonelSoyadi=@p2,Parola=@p3,Tel=@p4 where personel_id=@p5", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtAd.Text);
            komut2.Parameters.AddWithValue("@p2", txtSoyad.Text);
            komut2.Parameters.AddWithValue("@p3", txtParola.Text);
            komut2.Parameters.AddWithValue("@p4", txtNumara.Text);
            komut2.Parameters.AddWithValue("@p5", txtId.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
