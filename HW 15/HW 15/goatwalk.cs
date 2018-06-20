using System;
using System.Collections.Generic;
using System.Text;

namespace HW15
{
    class goatwalk
    {
        private string name;
        private int age;
        private string animaltype;

        public string _animaltype { get; set; }
        public string _Lname { get; set; }
        public int _age { get; set; }

        public goatwalk(string animaltype, string name ,int age)
        {
            _Lname = name;
            _age = age;
            _animaltype = animaltype;
        }

        public goatwalk(string name, int age, string animaltype)
        {
            this.name = name;
            this.age = age;
            this.animaltype = animaltype;
        }
    }
}
