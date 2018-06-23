using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHuman
    {
        public string _name { get; set; }
        public int _hits { get; set; }
        public int _hp { get; set; }
        public double _superpower { get; set; }


        public SuperHuman(int hp,int hits, String name, double superpower)
        {
            _hits = hits;
            _hp = hp;
            _name = name;
            _superpower = superpower;

        }

    }
}
