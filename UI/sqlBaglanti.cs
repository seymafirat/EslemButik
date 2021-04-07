using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace UI
{
    class sqlBaglanti
    {
        public SqlConnection baglanti()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-KSH5GCSC;Initial Catalog=Proje;Integrated Security=True");
            baglan.Open();
            return baglan;
        }
    }
}
