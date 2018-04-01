using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Layer;
using System.Data.SqlClient;
using System.Data;
using Data_Layer;
namespace Bussiness_Layer
{
    public class UserADO
    {
        DBConnection ob = new DBConnection();
        public int RegisterUser(User u)
        {
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "Insert into Ar_User values(@userid,@name,@pass,@ccno,@cctype,@ccmonth,@ccyear,@age)";
            cmd.Parameters.AddWithValue("@userid", u.USERID);
            cmd.Parameters.AddWithValue("@name", u.NAME);
            cmd.Parameters.AddWithValue("@pass", u.PWD);
            cmd.Parameters.AddWithValue("@ccno", u.CCNo);
            cmd.Parameters.AddWithValue("@cctype", u.CCT);
            cmd.Parameters.AddWithValue("@ccmonth", u.CCEM);
            cmd.Parameters.AddWithValue("@ccyear", u.CCEY);
            cmd.Parameters.AddWithValue("@age", u.AGE);
            cmd.Connection = con;
            int res = cmd.ExecuteNonQuery();
            ob.CloseConnection();
            return res;
        }
        public bool ValidateUser(string userId,string pwd)
        {
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select User_Id from AR_User where User_Id=@userid and Passwd=@pwd";
            cmd.Parameters.AddWithValue("@userid", userId);
            cmd.Parameters.AddWithValue("@pwd", pwd);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                if (userId == dr[0].ToString())
                {
                    ob.CloseConnection();
                    return true;  
                }
            }
            ob.CloseConnection();
            return false;
        }
    }
}
