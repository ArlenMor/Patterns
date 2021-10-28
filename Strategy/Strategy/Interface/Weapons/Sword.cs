﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy.Interface.Weapons
{
    class Sword : IWeaponBehavior
    {
        public void useWeapon()
        {
            Console.WriteLine("Я использую меч");
        }
    }
}
