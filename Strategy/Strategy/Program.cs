using System;
using Strategy.Hero;
using Strategy.Hero.Heroes;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            BaseHero Arlen = new Assasin();

            Arlen.Move();
            Arlen.Fight();

            BaseHero Legolas = new Archers();

            Legolas.Move();
            Legolas.Fight();
        }
    }
}
