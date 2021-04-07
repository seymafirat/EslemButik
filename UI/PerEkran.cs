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

namespace UI
{
    public partial class PerEkran : Form
    {
        public PerEkran()
        {
            InitializeComponent();
        }
        public string PerId;
        sqlBaglanti bgl = new sqlBaglanti();


        private void PerEkran_Load(object sender, EventArgs e)
        {
            lblAdd.Text = PerId;
            SqlCommand komut = new SqlCommand("Select PersonelAdi,PersonelSoyadi from Personel where Personel_id=@p1", bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", lblAdd.Text); //lblIdde yazan değere eşit olan adı soyadı getirsin
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lbSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1 a = new Form1();
            a.Show();
        }

        private void btnStok_Click(object sender, EventArgs e)
        {
            StokDurumu sd = new StokDurumu();
            sd.Show();
            this.Hide();
        }

        private void btnToptanci_Click(object sender, EventArgs e)
        {
            Toptanci t = new Toptanci();
            t.Show();
            this.Hide();
        }

        private void btnOzelDikim_Click(object sender, EventArgs e)
        {
            OzelDikimRandevu od = new OzelDikimRandevu();
            od.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Randevu rg = new Randevu();
            rg.Show();
        }

        private void StokHepsi_Click(object sender, EventArgs e)
        {
            StokData u = new StokData();
            u.Show();
        }

        private void bilgiduzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void bilgiduzenle_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BilgiDuzenle bd = new BilgiDuzenle();
            bd.id = lblAdd.Text;
            bd.Show();
            this.Hide();

        }
    }
}
