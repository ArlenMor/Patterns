using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface.Movement
{
    class Walk : IMovementBehavior
    {
        public void move()
        {
            Console.WriteLine("Я просто хожу");
        }
    }
}
