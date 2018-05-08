using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace Data_Layer
{
   public class DBConnection
    {
        SqlConnection con = new SqlConnection(@"Data Source=(localdb)\man;Initial Catalog=AirlinesReservationSystem;Integrated Security=True");
        public SqlConnection GetConnection()
        {
            con.Open();
            return con;
        }
        public void CloseConnection()
        {
            con.Close();
        }
    }
}
