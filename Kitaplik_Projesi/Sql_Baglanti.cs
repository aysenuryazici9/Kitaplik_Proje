using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Kitaplik_Projesi
{
    public  class Sql_Baglanti
    {
        public SqlConnection baglan()
        {
            SqlConnection baglan = new SqlConnection("Data Source=LAPTOP-CVNIP36M\\MSSQL;Initial Catalog=Kitaplik_Proje_Udemy;Integrated Security=True");
            baglan.Open();
            return baglan;
        }


    }
}

