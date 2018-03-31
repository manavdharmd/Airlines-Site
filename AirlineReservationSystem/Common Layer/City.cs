using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Layer
{
    public class City
    {
        private string airport;
        private string name;
        public string AIRPORT
        { get { return airport; }
            set { airport = value; }
        }
        public string NAME
        { get { return name; }
            set { value = name; } }
        public City(string name, string airport)
        {
            this.name = name;
            this.airport = airport;
        }
    }
}
