using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class otheranymal :goatwalk
    {
        public string _going { get; set; }

        public otheranymal(string animaltype, string name, int age, string going) : base (name, age, animaltype)
        {
            _Lname = name;
            _age = age;
            _animaltype = animaltype;
            _going = going;

        }
    }
}
