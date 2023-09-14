using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    //כתבו את המחלקה על פי המחלקות הקודמות
    //שימו לב שעליכם להתייחס גם לתעופה
    class RobotFly : RobotSpy
    {
        protected int[] legsPower;
        protected double[] wingsPower;

        public RobotFly() : base("RoboFly", DateTime.Now, 100)
        {
            legsPower = new int[] { 0, 0, 0, 0, 0, 0 }; ////indexes 0,1,2- right side indexes 3,4,5- left side
            wingsPower = new double[] { 0, 0, 0, 0 }; //indexes 0,1- right side indexes 2,3- left side
        }

        public override void MoveBackward()
        {
            if (this.GetBatteryStatus() > 12)
            {
                for (int i = 0; i < 6; i++)
                    this.MoveLeg(i, -1);
            }
        }

        public override void MoveForward()
        {
            if (this.GetBatteryStatus() > 12)
            {
                for (int i = 0; i < 6; i++)
                    this.MoveLeg(i, 1);
            }
        }

        public override void TurnLeft()
        {
            if (this.GetBatteryStatus() > 12)
            {
                MoveLeg(0, -1);
                MoveLeg(1, -1);
                MoveLeg(2, -1);
                MoveLeg(3, 1);
                MoveLeg(4, 1);
                MoveLeg(5, 1);
            }
        }

        public override void TurnRight()
        {
            if (this.GetBatteryStatus() > 12)
            {
                MoveLeg(0, -1);
                MoveLeg(1, -1);
                MoveLeg(2, -1);
                MoveLeg(3, 1);
                MoveLeg(4, 1);
                MoveLeg(5, 1);
            }
        }

        public void FlyUp()
        {
            if(this.GetBatteryStatus() > 6)
            {
                MoveWing(0, 1);
                MoveWing(1, 1);
                MoveWing(2, 1);
                MoveWing(3, 1);
            }
        }

        public void FlyDown()
        {
            if (this.GetBatteryStatus() > 6)
            {
                MoveWing(0, -1);
                MoveWing(1, -1);
                MoveWing(2, -1);
                MoveWing(3, -1);
            }
        }        
        public void FlyRight()
        {
            if (this.GetBatteryStatus() > 6)
            {
                MoveWing(0, 1);
                MoveWing(1, 1);
                MoveWing(2, -0.5);
                MoveWing(3, -0.5);
            }
        }        
        public void FlyLeft()
        {
            if (this.GetBatteryStatus() > 6)
            {
                MoveWing(0, -0.5);
                MoveWing(1, -0.5);
                MoveWing(2, 1);
                MoveWing(3, 1);
            }
        }
        private void MoveLeg(int legId, int dir)
        {
            legsPower[legId] = dir;
            this.SetBatteryStatus(this.GetBatteryStatus() - 2);
        }
        private void MoveWing(int wingId, double dir)
        {
            wingsPower[wingId] = dir;
            this.SetBatteryStatus(this.GetBatteryStatus() - 1.5);
        }
    }
}
