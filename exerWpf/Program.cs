using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game
{
    class Program
    {
        //static void Ass()
        //{
        //    Random random = new Random();
        //    Robotfactory fact = new Robotfactory();
        //    Robot robot = fact.GetRobot(random);
        //    History GameHistory = new History();
        //    GameHistory.Save(robot.State());
        //    Proxy proxy;
        //    Earth earth = new Earth();
        //    RobotCommand command = new RobotCommand(robot);
        //    robot.Go();
        //    Console.WriteLine("Робот сделал первый шаг");
        //    while (true)
        //    {
        //        if (random.Next(1, 100) < 30)
        //        {
        //            Console.WriteLine("Лежит коробка");
        //            proxy = new Proxy(robot);
        //            proxy.box = earth.getBox();
        //            Console.WriteLine("Берем коробку ли идем дальше ? ");
        //            string ask = Console.ReadLine();
        //            if (ask == "1")
        //            {
        //                GameHistory.Save(robot.State());
        //                robot.GetGrooz(proxy);
        //                Console.WriteLine(robot.ToString());
        //            }
        //            Console.WriteLine("Хотите отменить ход ?");
        //            string b = Console.ReadLine();
        //            if (b == "y")
        //            {
        //                command.Undo(GameHistory);
        //                Console.WriteLine(robot.ToString());
        //            }
        //            robot.Go();
        //        }
        //        else
        //        {
        //            Console.WriteLine("Коробки нет идем дальше");
        //            robot.Go();
        //        }


        //    }
            
        //    Console.WriteLine();



        //}
    }
}
