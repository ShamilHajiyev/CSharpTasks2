using System;

namespace Comparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");

            int number = Convert.ToInt32(Console.ReadLine());

            if (number % 2 == 0)
            {

                Console.WriteLine("Daxil etdiyiniz eded cüt ededdir.");

            }

            else
            {

                Console.WriteLine("Daxil etdiyiniz eded tek ededdir.");

            }
        }
    }
}
