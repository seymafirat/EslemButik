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
    public partial class OzelDikimRandevu : Form
    {
        public OzelDikimRandevu()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void OzelDikimRandevu_Load(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Select distinct RezervasyonTarihi from MusaitZamanlar", bgl.baglanti());
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                cmbTarih.Items.Add(dr[0]);

            }
            SqlCommand komut2 = new SqlCommand("Select distinct RezervasyonSaati from MusaitZamanlar", bgl.baglanti());
            SqlDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                cmbSaat.Items.Add(dr2[0]);

            }
            bgl.baglanti().Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).Count() > 0)
            {
                this.Controls.OfType<TextBox>().Where(f => string.IsNullOrWhiteSpace(f.Text)).ToList().ForEach(f => { MessageBox.Show(f.Name + " boş bırakılamaz"); });
            }
            else
            {
                MessageBox.Show("Randevunuz Alınmıştır.Randevu Tarihi ve Saati:" + cmbTarih.Text + " " + cmbSaat.Text);
                SqlCommand komut3 = new SqlCommand("Insert into OzelRezervasyon (MusteriAdSoyad,MusteriTelNo,RezervasyonTarihi,RezervasyonSaati) values(@p1, @p2, @p3, @p4)", bgl.baglanti());
                komut3.Parameters.AddWithValue("@p1", txtadsoyad.Text);
                komut3.Parameters.AddWithValue("@p2", txttel.Text);

                komut3.Parameters.AddWithValue("@p3", cmbTarih.Text);
                komut3.Parameters.AddWithValue("@p4", cmbSaat.Text);

                komut3.ExecuteNonQuery();
                bgl.baglanti().Close();
            }
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbSaat.Items.Clear();
            SqlCommand komut3 = new SqlCommand("Select RezervasyonSaati From MusaitZamanlar where RezervasyonTarihi=@p1", bgl.baglanti());
            komut3.Parameters.AddWithValue("@p1", cmbTarih.Text);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                cmbSaat.Items.Add(dr3[0]);

            }
            bgl.baglanti().Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PerEkran p = new PerEkran();
            p.Show();
            this.Hide();
        }
    }
}
