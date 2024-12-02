using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SR1_04
{
    internal class TankRobot : Robot
    {

        public TankRobot(string name) : base(name)
        {
        }

        public void Attack()
        {
                Console.WriteLine("{0}はキャノン砲を撃った！", name);
        }
    }
}
