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
    public partial class YetkiliGirisi : Form
    {
        public YetkiliGirisi()
        {
            InitializeComponent();
        }
        sqlBaglanti bgl = new sqlBaglanti();


        private void button3_Click(object sender, EventArgs e)
        {
            Satis s = new Satis();
            s.Show();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PersonelGiris p = new PersonelGiris();
            p.Show();
            this.Hide();
        }

        private void btnstok_Click(object sender, EventArgs e)
        {
            StokData s = new StokData();
            s.Show();
        }

        private void btnsatislistele_Click(object sender, EventArgs e)
        {
            SatisTamami s = new SatisTamami();
            s.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PersonelBilgileri pb = new PersonelBilgileri();
            pb.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            RandevuGoruntule r = new RandevuGoruntule();
            r.Show();
        }
    }
}
