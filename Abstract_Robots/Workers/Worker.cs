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
            //משימה 1
            //השלימו את הבנאי המקבל הפרמטרים הנחוצים ליצירת עובד חדש
        }
        //משימה 2
        //get כתבו פעולות מאחזרות 

        //משימה 3
        //רק לתכונות שניתן לשנות - set כתבו פעולות מעדכנות

        //משימה 4
        // כתבו חתימה פעולה אבסטרקטית לחישוב שכר

        public override string ToString()
        {
            string str = "";
            if(birthDate.Equals(DateTime.Today))
                str=" - HappyBirthDay";
            return fullName + " ID." + idNumber + str;

        }
    }
}
