using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Common_Layer;
namespace Bussiness_Layer
{
  public class BookingADO
    {
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
            return 0;
        }
        private int CreateBooking(Booking booking)
        {
            return 0;
        }
        private int UpdateBooking(Booking booking)
        {
            return 0;
        }
    }
}
