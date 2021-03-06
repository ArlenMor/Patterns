using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Strategy.Interface.Movement;
using Strategy.Interface.Weapons;

namespace Strategy.Hero.Heroes
{
    class Archers : BaseHero
    {
        public Archers()
        {
            m_movement = new Walk();
            m_weapon = new Bow();
        }
        public override void Fight()
        {
            m_weapon.useWeapon();
        }

        public override void Move()
        {
            m_movement.move();
        }
    }
}
