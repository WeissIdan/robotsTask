using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class GeneralManager : Worker
    {
        double monthlyPay;
        bool moreThen30Active;

        public GeneralManager(string name, string id, DateTime bDate, string pass, double monthlySalary, bool moreThen30)
            :base (name,id,bDate,pass)
        {
            monthlyPay = monthlySalary;
            moreThen30Active = moreThen30;
        }

        public override double CalcIncome()
        {
            if (moreThen30Active)
                return monthlyPay + 0.15 * monthlyPay;
            return monthlyPay;
        }

    }
}
