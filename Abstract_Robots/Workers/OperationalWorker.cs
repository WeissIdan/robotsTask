using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationalWorker : Worker//1. כתבו את המחלקה המתאימה להורשה 
    {
        double hourlyPay;
        double hours;
        public override double CalcIncome()
        {
            return hours * hourlyPay;
        }
        public OperationalWorker(string name, string id, DateTime bDate, string pass, double hourlyPay, double hours)
            : base(name, id, bDate, pass)
        {
            this.hourlyPay = hourlyPay;
            this.hours = hours;
        }

        //4. כתבו פעולה דורסת לחישוב שכר

    }
}
