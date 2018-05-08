using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Layer
{
   public class Booking
    {
        private float cost;
        private string flightid;
        private List<Passenger> passengers;
        private int refrenceId;
        private int seat;
        private string status;
        private DateTime travelon;
        private string userid;

        public float COST
        {
            get { return cost;}
            set {cost=value; }
        }
        public string FLIGHTID
        {
            get { return flightid; }
            set { flightid = value; }
        }
        public List<Passenger> PASSENGERS
        {
            get { return passengers; }
            set { passengers = value; }
        }
        public int REFERNCEID
        {
            get { return refrenceId; }
            set { refrenceId = value; }
        }
        public int SEAT
        {
            get { return seat; }
            set { seat = value; }
        }
        public String STATUS
        {
            get { return status; }
            set { status = value; }
        }
        public DateTime TRAVELON
        {
            get { return travelon; }
            set { travelon = value; }
        }
        public string USERID
        {
            get { return userid; }
            set { userid = value; }
        }
        public Booking(int refernceId, string userId, DateTime travelon, string flightId, string status, int seats, float cost)
        {
            REFERNCEID = refernceId;
            USERID = userId;
            TRAVELON = travelon;
            FLIGHTID = flightId;
            STATUS = status;
            SEAT = seats;
            COST = cost;
        }
        public Booking(string userId, DateTime travelon, string flightId, string status, int seats, float cost)
        {
            REFERNCEID = -1;
            USERID = userId;
            TRAVELON = travelon;
            FLIGHTID = flightId;
            STATUS = status;
            SEAT =seats;
            COST = cost;
        }
        List<Passenger> lp = new List<Passenger>();
        public void AddPassenger(string name, int age)
        {
            lp.Add(new Passenger(name, age));
        }
        public void Cancel()
        {

        }
        public bool Cancel(int refrenceId,int ticket)
        {
            return false;
        }
       
    }
}
