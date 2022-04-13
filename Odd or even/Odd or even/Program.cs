using System;

namespace Odd_or_even
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");

            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Başqa bir eded daxil edin:");

            int num2 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {

                Console.WriteLine(num1 + " daha böyükdür.");

            }

            else if (num1 < num2)
            {

                Console.WriteLine(num2 + " daha böyükdür.");

            }

            else
            {
                Console.WriteLine("Daxil etdiyiniz ededler beraberdir.");
            }
        }
    }
}
