using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        protected int[] wheelsPower; //מערך של גלגלים (הכוחות שכל גלגל מקבל)
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotWheels() : base("Spyke", DateTime.Now, 100)
        { 
            wheelsPower = new int[] { 0, 0, 0, 0, 0, 0 }; 
        }

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void MoveBackward()
        {
            this.TurnWheels(-1, -1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }     
        public override void TurnLeft()
        {
            this.TurnWheels(0, -1);
        }

        private void TurnWheels(int rightDir, int leftDir)
        {
            if (this.GetBatteryStatus() > 4.5)
            {
                wheelsPower[0] = rightDir;
                wheelsPower[1] = rightDir;
                wheelsPower[2] = rightDir;
                wheelsPower[3] = leftDir;
                wheelsPower[4] = leftDir;
                wheelsPower[5] = leftDir;
                this.SetBatteryStatus(this.GetBatteryStatus() - 4.5);
            }
        }

        public void WaveHands()
        {
            if (this.GetBatteryStatus() > 2)
            {
                Console.WriteLine("robot waving");
                this.SetBatteryStatus(this.GetBatteryStatus() - 2);
            }

        }

    }
}
