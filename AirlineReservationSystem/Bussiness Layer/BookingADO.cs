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
            return null;
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
            cmd.Parameters.AddWithValue("@userId", booking.USERID);
            cmd.Parameters.AddWithValue("@flightId", booking.FLIGHTID);
            cmd.Parameters.AddWithValue("@flightDate", booking.TRAVELON);
            cmd.Parameters.AddWithValue("@seats", booking.SEAT);
            cmd.Parameters.AddWithValue("@cost", booking.COST);
            cmd.Connection = con;
            booking.REFERNCEID = Convert.ToInt32(cmd.ExecuteScalar());
            ob.CloseConnection();
            if (booking.REFERNCEID < 0)
            {
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
                    cmd1.Connection = con1;
                    int ticketno = Convert.ToInt32(cmd1.ExecuteScalar());
                    ob.CloseConnection();
                }
            }
            return booking.REFERNCEID;
        }
        private int UpdateBooking(Booking booking)
        {
            return 0;
        }
    }
}
