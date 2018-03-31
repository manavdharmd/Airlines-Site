using System;
using System.Collections.Generic;
using Bussiness_Layer;
using Common_Layer;
namespace Service_Layer
{
    class AirLineServices
    {
        UserADO u_ob = new UserADO();
        FlightADO f_ob = new FlightADO();
        BookingADO b_ob = new BookingADO();
        public int RegisterUser(User u)
        {
            return u_ob.RegisterUser(u);
        }
        public bool ValidateUser(string userId, string passwd)
        {
            return u_ob.ValidateUser(userId, passwd);
        }
        public List<City> GetAllCities()
        {
            return f_ob.GetAllCities();
        }
        public List<FlightSchedule> GetFlightsInRoute(string origin, string destination)
        {
            return f_ob.GetFlightsByRoute(origin, destination);
        }
        public List<FlightSchedule> GetFlightSchedule(string flightId, DateTime travelDate)
        {
            return f_ob.GetFlightScheduleBydate(flightId, travelDate);
        }
        public List<Booking> GetALLBookings(string userId)
        {
            return b_ob.GetALLBookings(userId);
        }
        public List<Booking> GetBookingsForCancel(string userId)
        {
            return b_ob.GetALLBookings(userId);
        }
        public Booking GetBookingDetails(int bookingref)
        {
            Booking b = b_ob.GetBookingPassengers(bookingref);
            GetFlightSchedule(b.FlightId, b.Travelon);
            return b;
        }
        public int saveBooking(Booking booking)
        {
            return b_ob.SaveBooking(booking);
        }


    }
}
