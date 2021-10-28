using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface.Weapons
{
    class Bow : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Я стреляю из лука");
        }
    }
}
