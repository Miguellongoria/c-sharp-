using System;

namespace hw_14
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome");
            Console.ReadKey();

            string letters = "party";
            Console.WriteLine(letters);

            float ammount = 0.98f;
            double quantity = 0.68;
            bool total = true;
            Console.ReadKey();


            int age = 21;
            int born = 1997;
            int month = 1;
            Console.WriteLine(age);
            Console.WriteLine("i am {0}  and was born in {1} and the month{2}", age ,born, month);
            Console.ReadKey();

            Console.Write("when were you born:  ");
            string birth = Console.ReadLine();
            Console.WriteLine(birth);
            Console.ReadKey();

            Console.WriteLine(21 == 21);
            Console.WriteLine(19 != 21);
            Console.WriteLine("drunk" == "happy");
            Console.WriteLine("sover" == "hype");
            Console.ReadKey();



            Console.ReadKey();




        }
    }
}
