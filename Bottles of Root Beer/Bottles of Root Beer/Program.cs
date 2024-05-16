using System;

namespace Bottles_of_Root_Beer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How many bottles of Root Beer do you want to take off the wall. Please put a number in that is above 0.");
            int result = int.Parse(Console.ReadLine());
            int counter = -1;
            while (counter < result)
            {
                Console.WriteLine("{0} bottles of root beer on the wall {0} bottles of root beer. Take one down and pass it around {1} bottles of root beer on the wall.",
                    result, result - 1);
                result--;
            }

            Console.ReadLine();
        }

        public static void print(string x)
        {
            Console.WriteLine(x);
        }

        public static string input(string x)
        {
            x = Console.ReadLine();

            return x;

        }
        public static int input(int y)
        {
            y = int.Parse(Console.ReadLine());

            return y;
        }
    }

}
