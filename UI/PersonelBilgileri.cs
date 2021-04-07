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
    public partial class PersonelBilgileri : Form
    {
        public PersonelBilgileri()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();

        private void PersonelBilgileri_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Personel",bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void BtnEkle_Click(object sender, EventArgs e)
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

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            Ad.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            Soyad.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            TelefonNo.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            Id.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            Parola.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Delete from Personel where Personel_id=@p1", bgl.baglanti());
            komut2.Parameters.AddWithValue("@p1", Id.Text);
            komut2.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt silindi", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }
    }
}
