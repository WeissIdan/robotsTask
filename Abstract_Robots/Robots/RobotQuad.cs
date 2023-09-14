using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        protected int[] legPower;
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("Roboquad", DateTime.Now, 100)
        {
            legPower = new int[] { 0, 0, 0, 0 }; //indexes 0,1- right side indexes 2,3- left side
        }

        public override void MoveForward()
        {
            if (this.GetBatteryStatus() > 12)
            {
                for (int i = 0; i < 4; i++)
                    this.MoveLeg(i, 1);
            }
        }        
        public override void MoveBackward()
        {
           if (this.GetBatteryStatus() > 12)
           {
                for (int i = 0; i < 4; i++)
                    this.MoveLeg(i, -1);
           }
        }

        public override void TurnLeft()
        {
            if (this.GetBatteryStatus() > 12)
            {
                MoveLeg(0, -1);
                MoveLeg(1, -1);
                MoveLeg(2, 1);
                MoveLeg(3, 1);
            }
        }        
        public override void TurnRight()
        {
            if (this.GetBatteryStatus() > 12)
            {
                MoveLeg(0, 1);
                MoveLeg(1, 1);
                MoveLeg(2, -1);
                MoveLeg(3, -1);
            }
        }

        private void MoveLeg(int legId, int dir)
        {
            legPower[legId] = dir;
            this.SetBatteryStatus(this.GetBatteryStatus() - 3);
        }
    }

}
