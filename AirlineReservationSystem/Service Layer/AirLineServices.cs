using System;
using System.Collections.Generic;
using Bussiness_Layer;
using Common_Layer;
namespace Service_Layer
{
   public class AirLineServices
    {
        public int RegisterUser(User u)
        {
            return new UserADO().RegisterUser(u);
        }
        public bool ValidateUser(string userId, string passwd)
        {
            return new UserADO().ValidateUser(userId, passwd);
        }
        public List<City> GetAllCities()
        {
            return new FlightADO().GetAllCities();
        }
        public List<FlightSchedule> GetFlightsInRoute(string origin, string destination)
        {
            return new FlightADO().GetFlightByRoute(origin, destination);
        }
        public List<FlightSchedule> GetFlightSchedule(string flightId, DateTime travelDate) 
        {
            return new FlightADO().GetFlightScheduleByDate(flightId, travelDate);
        }
        public List<Booking> GetALLBookings(string userId)
        {
            return new BookingADO().GetALLBookings(userId);
        }
        public List<Booking> GetBookingsForCancel(string userId)
        {
            return new BookingADO().GetALLBookings(userId);
        }
        public Booking GetBookingDetails(int bookingref)
        {
            return new BookingADO().GetBookingPassengers(bookingref);
     
        }
        public int saveBooking(Booking booking)
        {
            return new BookingADO().SaveBooking(booking);
        }


    }
}
