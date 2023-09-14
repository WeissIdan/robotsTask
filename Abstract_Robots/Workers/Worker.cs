using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public abstract class Worker
    {
        private string fullName;
        private string idNumber;
        private DateTime birthDate;
        private string password;


        public Worker(string name, string id, DateTime bDate, string pass)
        {
            this.fullName = name;
            this.idNumber = id;
            this.birthDate = bDate;
            this.password = pass;
        }
        public string GetFullName()
        {
            return fullName;
        }
        public string GetIdNumber()
        {
            return idNumber;
        }
        public DateTime GetBirthDate()
        {
            return birthDate;
        }
        public string GetPassword()
        {
            return password;
        }

        //משימה 3
        public void SetPassword(string pass)
        {
            this.password = pass;
        }        
        public void SetFullName(string name)
        {
            this.fullName = name;
        }
        //משימה 4
        public abstract double CalcIncome();

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
