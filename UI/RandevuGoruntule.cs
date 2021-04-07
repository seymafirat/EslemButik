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
    public partial class RandevuGoruntule : Form
    {
        public RandevuGoruntule()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void RandevuGoruntule_Load(object sender, EventArgs e)
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

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from OzelRezervasyon", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

        }

        private void button2_Click(object sender, EventArgs e)
        {
            YetkiliGirisi y = new YetkiliGirisi();
            y.Show();
            this.Hide();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtadsoyad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txttel.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            cmbTarih.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cmbSaat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("Update OzelRezervasyon set MusteriAdSoyad=@p1,MusteriTelNo=@p2,RezervasyonTarihi=@p3,RezervasyonSaati=@p4 where MusteriAdSoyad=@p1",bgl.baglanti());
            komut.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p2", txttel.Text);
            komut.Parameters.AddWithValue("@p3", cmbTarih.Text);
            komut.Parameters.AddWithValue("@p4", cmbSaat.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from OzelRezervasyon where MusteriAdSoyad=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", txtadsoyad.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void cmbTarih_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
