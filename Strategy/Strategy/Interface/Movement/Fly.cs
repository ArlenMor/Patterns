using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface.Movement
{
    class Fly : IMovementBehavior
    {
        public void move()
        {
            Console.WriteLine("Я летаю");
        }
    }
}
