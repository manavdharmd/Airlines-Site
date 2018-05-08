using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Layer;
using Data_Layer;
using System.Data.SqlClient;
using System.Data;
namespace Bussiness_Layer
{
   public class FlightADO
    {
        DBConnection ob = new DBConnection();
        public List<City> GetAllCities()
        {
            List<City> l_city = new List<City>();
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select City_Name,Airport from AR_Cities";
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                l_city.Add(new City(dr[0].ToString(), dr[1].ToString()));
            }
            ob.CloseConnection();
            return l_city;
        }
        public List<FlightSchedule> GetFlightByRoute(string origin, string destination)
        {
            List<FlightSchedule> f_ob = new List<FlightSchedule>();
            if (origin.Equals(destination) != true)
            {

                SqlConnection con = ob.GetConnection();
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "select a.Flight_Id,a.Flight_Date,a.Seats,a.Cost,b.Arr_Time ,b.Dep_Time from AR_FlightAvail as a,AR_Flights as b where b.Flight_Id=a.Flight_Id and b.Origin_City =(select City_Id from AR_Cities where City_Name =@ocity) and b.Dest_City =(select City_Id from AR_Cities where City_Name =@dcity)";
                cmd.Parameters.AddWithValue("@ocity", origin);
                cmd.Parameters.AddWithValue("@dcity", destination);
                cmd.Connection = con;
                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    f_ob.Add(new FlightSchedule(dr[0].ToString(), Convert.ToDateTime(dr[1]), Convert.ToInt32(dr[2]), float.Parse(dr[3].ToString()), dr[4].ToString(), dr[5].ToString()));

                }
                ob.CloseConnection();
            }
                return f_ob;
        }
        public List<FlightSchedule> GetFlightScheduleByDate(string flightId, DateTime travelon)
        {
            List<FlightSchedule> f_ob = new List<FlightSchedule>();
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.CommandText = "select a.Flight_Id,a.Flight_Date,a.Seats,a.Cost,b.Arr_Time ,b.Dep_Time from AR_FlightAvail as a,AR_Flights as b where a.Flight_Id=@flightid and Flight_Date=@flightdt";
            cmd.Parameters.AddWithValue("@flightid", flightId);
            cmd.Parameters.AddWithValue("@flightdt", travelon);
            cmd.Connection = con;
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                f_ob.Add(new FlightSchedule(dr[0].ToString(), Convert.ToDateTime(dr[1]), Convert.ToInt32(dr[2]), float.Parse(dr[3].ToString()), dr[4].ToString(), dr[5].ToString()));

            }
            ob.CloseConnection();
            return f_ob;
        }
    }
}
