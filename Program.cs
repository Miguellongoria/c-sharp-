using System;

namespace methods
{
    class Program
    {
        static void Main(string[] args)
        {

            Create("juanito", "manzana");
            Sub(109, 40);
            String result = Names("juanito", "manzana");
            Console.WriteLine(result);
            Console.ReadKey();

        }

        // Using public
        public static void Create(String a, String b)
        {

            Console.WriteLine(a + b);

        }

        //using return
        public static String Names(String c, String d)
        {
            return c + d;
        }

        //using private
        private static void Sub(int x, int y)
        {
            Console.WriteLine(x - y);
        }

        private static void hiddenmethod()
        {
            Console.WriteLine("YOULL never see it");
        }
    }
}