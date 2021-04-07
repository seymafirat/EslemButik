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

namespace EslemButik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void PersonelBtn_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.Show();
            this.Hide();
        }

        private void YetkiliBtn_Click(object sender, EventArgs e)
        {
            /* Personel p = new Personel();
             p.Show();
             this.Hide();*/
            YetkiliGirisi y = new YetkiliGirisi();
            y.Show();
            this.Hide();


        }
    }
}
