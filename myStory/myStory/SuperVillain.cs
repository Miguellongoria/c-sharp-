using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperVillain
    {
        private static object hp;
        private int _hits;
        private string _name;

        public int _life { get; set; }

        private double _superpower;

        public int _strength { get; set; }

        public SuperVillain(int hits, string name, int life, double superpower, int strength) : base  (hits, name, superpower)
        {
            _hits = hits;
            _name = name;
            _life = life;
            _superpower = superpower;
            _strength = strength;
        }

        public void damage(int _strength)
        {
            if (_strength == 30)
            {
                Console.WriteLine("you good");

            }
            else if (_strength <= 10)
            {
                Console.WriteLine("you out cold");

            }
            else
            {
                Console.WriteLine("keep going");
            }

        }

    }
}
