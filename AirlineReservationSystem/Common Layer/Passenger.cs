using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Layer
{
  public class Passenger
    {
        private int age;
        private string name;
        private string status;
        private int ticketNo;
        public int Age
        {
            get
            {
                return age;
            }
            set
            {

                age = value;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {

                name = value;
            }
        }
        public string Status
        {
            get
            {
                return status;
            }
            set
            {

                status = value;
            }
        }
        public int TicketNo
        {
            get
            {
                return ticketNo;
            }
            set
            {

                ticketNo = value;
            }
        }
        public Passenger(int ticketNo, string name, int age, string status)
        {
            TicketNo = ticketNo;
            Name = name;
            Age = age;
            Status = status;

        }
        public Passenger(string name, int age)
        {
            TicketNo = -1;
            Status = "B";
            Name = name;
            Age = age;

        }
        void cancelTicket(int ticketNo)
        {
            Status = "C";      
        }

    }
}
