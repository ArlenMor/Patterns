using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface.Weapons
{
    class Knife : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Я использую нож");
        }
    }
}
