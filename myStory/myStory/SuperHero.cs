﻿using System;
using System.Collections.Generic;
using System.Text;

namespace myStory
{
    class SuperHero
    {
        private string _name;
        private int _hits;
        private double _superpower;

        public double _strength { get; set; }

        public SuperHero(String name, int hits, double superpower, double strength) : base (hits, name, superpower)
        {
            _name = name;
            _hits = hits;
            _superpower = superpower;
            _strength = strength;


        }
    }
}
