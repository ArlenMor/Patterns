using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interface;

namespace Strategy.Hero
{
    abstract class BaseHero
    {
        protected IMovementBehavior m_movement;
        protected IWeaponBehavior m_weapon;
        abstract public void Fight();
        abstract public void Move();
    }
}
