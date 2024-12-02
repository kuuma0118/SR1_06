using SR1_04;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Robot robot = new Robot("ロボット");
            Console.WriteLine("名前:{0}", robot.GetName());
            robot.Attack();

            FlyingRobot flyingRobot = new FlyingRobot("空飛ぶロボット");
            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            flyingRobot.Attack();

            TankRobot tankRobot = new TankRobot("タンクロボ");
            Console.WriteLine("名前:{0}", flyingRobot.GetName());
            tankRobot.Attack();

            Console.ReadLine();
        }
    }
}