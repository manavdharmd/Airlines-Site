using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common_Layer
{
   public class User
    {
        private int age;
        private int ccEm;
        private int ccEY;
        private string ccNO;
        private string name;
        private string pwd;
        private string userId;
        private string cct;
        public int AGE
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
        public int CCEM
        {
            get
            {
                return ccEm;
            }
            set
            {
                ccEm = value;
            }
        }
        public int CCEY
        {
            get
            {
                return ccEY;
            }
            set
            {
                ccEY = value;
            }
        }
        public string CCNo
        {
            get
            {
                return ccNO;
            }
            set
            {
                ccNO = value;
            }
        }
        public string NAME
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
        public string PWD
        {
            get
            {
                return pwd;
            }
            set
            {
                pwd = value;
            }
        }
        public string USERID
        {
            get
            {
                return userId;
            }
            set
            {
                userId = value;
            }
        }
        public string CCT
        {
            get
            { return cct;}
            set
            { cct = value; }
        }
        public User(string userId, string name, string password, int age, string ccno, string cct, int ccem, int ccey)
        {
            AGE=age;
            CCEM=ccem;
            CCEY=ccey;
            CCNo=ccno;
            NAME=name;
            PWD=password;
            USERID=userId;
            CCT = cct;
    }
    }
}
