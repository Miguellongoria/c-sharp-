using System;

namespace HW_15
{
    class Program
    {
        public static object _going { get; private set; }
        public static object _age { get; private set; }

        static void Main(string[] args)
        {
            Console.WriteLine("you know how most stories start :)");
            Console.ReadKey();

            Console.WriteLine("once apon a time...");
            Console.ReadKey();

            Console.Write("just kidding this story wont be like that,this story is about a goat whos name is....what should we call him?  ");
            string goatname = Console.ReadLine();

            HW15.goatwalk mainguy = new HW15.otheranymal("goat", goatname, 15 ,"trap house");

            int age = mainguy._age;

            mainguy._age = 15;

            Console.WriteLine("{0}.....well if thats the name you wanna go with i guess its fine", mainguy._Lname);
            Console.ReadKey();

            Console.WriteLine("so {0} the goat is walking down the street on his way to climb a tree to scream", mainguy._Lname);
            Console.ReadKey();

            Console.WriteLine("as {0} was screaming from the top of the tree he saw another animal approaching", mainguy._Lname);
            Console.ReadKey();

            Console.Write("{0} was suspecious about the animal approaching and asked for his name and the animal said....", mainguy._Lname);
            string theotheranimal = Console.ReadLine();

            HW15.otheranymal bobby = new HW15.otheranymal("llama", theotheranimal, 16, "the trap house");
            string going = bobby._going;
            bobby._going = "the trap house";

            Console.WriteLine("{0} asked {1} where he was heading ", mainguy._Lname, bobby._Lname);
            Console.ReadKey();

            Console.WriteLine("{0} told {1} he was going to the {2} to turn up", bobby._Lname, mainguy._Lname,bobby._going);
            Console.ReadKey();

            Console.WriteLine("{0} wanted to go but {1} said since he was only {2} he was too little", mainguy._Lname, bobby._Lname,mainguy._age);
            Console.ReadKey();





        }
    }
}
