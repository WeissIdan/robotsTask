using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class OperationManager : Worker
    {
        double hourlyPay;
        double hours;
        int tasksCompleted;

        public OperationManager(string name, string id, DateTime bDate, string pass, double hourlyPay, double hours, int tasksCompleted)
            : base(name, id, bDate, pass)
        {
            this.hourlyPay = hourlyPay;
            this.hours = hours;
            this.tasksCompleted = tasksCompleted;
        }

        public override double CalcIncome()
        {
            return (hourlyPay * hours) + ((3 / 100) * hourlyPay * tasksCompleted);
        }
    }
}
