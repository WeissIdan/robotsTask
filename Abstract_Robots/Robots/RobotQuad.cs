using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Robots_inc
{
    public class RobotQuad : RobotSpy
    {
        //1. עדכנו את הפעולה הבונה כך שתתאים לפעולת במחלקת העל
        public RobotQuad() : base("Roboquad")
        { }

        public override void MoveForward()
        {
            for (int i = 0; i < 4; i++)
                this.MoveLeg(i, 1);
        }

        //2. השלימו את התנועות החסרות מתוך המצגת או על הבנתכם

        private void MoveLeg(int legId, int dir) 
        {
            //3. הוסיפו התייחסות לסוללה
        }
    }

}
