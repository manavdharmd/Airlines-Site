using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Layer;
using System.Data;
using System.Data.SqlClient;
using Data_Layer;
namespace Bussiness_Layer
{
  public class BookingADO
    {
        DBConnection ob = new DBConnection();
        public List<Booking> GetALLBookings(string userid)
        {
            return null;
        }
        public List<Booking> GetBookingForCancel(string userId)
        {
            return null;
        }
        public Booking GetBookingPassengers(int bookingref)
        {
            SqlConnection con1 = ob.GetConnection();
            SqlCommand cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "Get_Pass";
            cmd1.Parameters.AddWithValue("@ref", bookingref);
            cmd1.Connection = con1;
            SqlDataReader dr = cmd1.ExecuteReader();
            Booking b=null;
            while (dr.Read())
            {
                b = new Booking(dr[1].ToString(),Convert.ToDateTime(dr[6]),dr[2].ToString(),dr[3].ToString(),Convert.ToInt32(dr[4]),float.Parse(dr[5].ToString()));
            }
            ob.CloseConnection();
            con1 = ob.GetConnection();
            cmd1 = new SqlCommand();
            cmd1.CommandType = CommandType.StoredProcedure;
            cmd1.CommandText = "pr_Passenger_Ret";
            cmd1.Parameters.AddWithValue("@ref", bookingref);
            cmd1.Connection = con1;
            dr = cmd1.ExecuteReader();
            while (dr.Read())
            {
                b.PASSENGERS.Add(new Passenger(Convert.ToInt32(dr[1]),dr[2].ToString(),Convert.ToInt32(dr[3]),dr[4].ToString()));
              }
            return b;
        }
        public int SaveBooking(Booking booking)
        {
            if (booking.REFERNCEID == -1)
              return CreateBooking(booking);
              return  UpdateBooking(booking);
        
        }
        private int CreateBooking(Booking booking)
        {
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_Booking_Save";
            cmd.Parameters.AddWithValue("@user_Id", booking.USERID);
            cmd.Parameters.AddWithValue("@flight_Id", booking.FLIGHTID);
            cmd.Parameters.AddWithValue("@flight_Date", booking.TRAVELON);
            cmd.Parameters.AddWithValue("@seats", booking.SEAT);
            cmd.Parameters.AddWithValue("@cost", booking.COST);
            cmd.Parameters.AddWithValue("@sta", booking.STATUS);
            cmd.Connection = con;
            booking.REFERNCEID = Convert.ToInt32(cmd.ExecuteScalar());
            ob.CloseConnection();
                List<Passenger> p = booking.PASSENGERS;
                foreach (Passenger item in p)
                {
                    SqlConnection con1 = ob.GetConnection();
                    SqlCommand cmd1 = new SqlCommand();
                    cmd1.CommandType = CommandType.StoredProcedure;
                    cmd1.CommandText = "pr_Passenger_Save";
                    cmd1.Parameters.AddWithValue("@referenceID", booking.REFERNCEID);
                    cmd1.Parameters.AddWithValue("@name", item.Name);
                    cmd1.Parameters.AddWithValue("@age", item.Age);
                    cmd1.Parameters.AddWithValue("@sta", item.Status);
                    cmd1.Connection = con1;
                    int ticketno = Convert.ToInt32(cmd1.ExecuteScalar());
                    ob.CloseConnection();
            }
            return booking.REFERNCEID;
        }
        private int UpdateBooking(Booking booking)
        {
            SqlConnection con = ob.GetConnection();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "pr_Booking_Up";
            cmd.Parameters.AddWithValue("@user_Id", booking.USERID);
            cmd.Parameters.AddWithValue("@flight_Id", booking.FLIGHTID);
            cmd.Parameters.AddWithValue("@flight_Date", booking.TRAVELON);
            cmd.Parameters.AddWithValue("@seats", booking.SEAT);
            cmd.Parameters.AddWithValue("@cost", booking.COST);
            cmd.Parameters.AddWithValue("@sta", booking.STATUS);
            cmd.Connection = con;
            booking.REFERNCEID = Convert.ToInt32(cmd.ExecuteScalar());
            ob.CloseConnection();
            List<Passenger> p = booking.PASSENGERS;
            foreach (Passenger item in p)
            {
                SqlConnection con1 = ob.GetConnection();
                SqlCommand cmd1 = new SqlCommand();
                cmd1.CommandType = CommandType.StoredProcedure;
                cmd1.CommandText = "pr_Passenger_Up";
                cmd1.Parameters.AddWithValue("@referenceID", booking.REFERNCEID);
                cmd1.Parameters.AddWithValue("@name", item.Name);
                cmd1.Parameters.AddWithValue("@age", item.Age);
                cmd1.Parameters.AddWithValue("@sta", item.Status);
                cmd1.Connection = con1;
                int ticketno = Convert.ToInt32(cmd1.ExecuteScalar());
                ob.CloseConnection();
            }
            return booking.REFERNCEID;
        }
    }
}
