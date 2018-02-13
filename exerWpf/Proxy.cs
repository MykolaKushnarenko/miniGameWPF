using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using robots;

namespace Game
{
    class Proxy:ABox
    {
        public Box box;
        private Robot robot;
        public Proxy(Robot robot)
        {
            this.robot = robot;
        }
        public override int Open()
        {
            if (box.NeedDecoding && robot.DecodResult())
            {
                if (box.Toxic)
                {
                    robot.chargeOfRobot -= 50;
                    return box.Open();
                }
                else
                {
                    robot.chargeOfRobot -= 25;
                    return box.Open();
                }
            }
            else if (box.NeedDecoding == false)
            {
                robot.chargeOfRobot -= 25;
                return box.Open();
            }
            else
            {
                robot.chargeOfRobot -= 25;
                return 0;
            }
        }

    }
}
