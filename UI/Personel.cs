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
using UI;

namespace UI
{
    public partial class Personel : Form
    {
        public Personel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f = new Form1();
            f.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PersonelGiris per = new PersonelGiris();
            per.Show();
            this.Hide();
        }

        private void KayitBtn_Click(object sender, EventArgs e)
        {
            PerKayitEkrani perKayit = new PerKayitEkrani();
            perKayit.Show();
          
        }
    }
}
