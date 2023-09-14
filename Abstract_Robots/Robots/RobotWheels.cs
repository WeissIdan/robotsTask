using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotWheels : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotWheels() : base("Spyke") { } 

        public override void MoveForward()
        {
            this.TurnWheels(1, 1);
        }
        public override void TurnRight()
        {
            this.TurnWheels(-1, 0);
        }
        //השלימו את הפעולות החסרות מתוך המצגת או על הבנתכם

        private void TurnWheels(int rightDir, int leftDir)
        {
            //2. הוסיפו התייחסות לסוללה
        }

        public void WaveHands()
        { 
            //3. הוסיפו התייחסות לסוללה 
        }

    }
}
