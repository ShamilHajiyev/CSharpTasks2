using System;

namespace Overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");
            int input = Convert.ToInt32(Console.ReadLine());
            convert(input);
        }
        public static void convert(int input)
        {
            int number = input;
            int counter = 0;
            while (number != 0)
            {
                number = number / 10;
                counter++;
            }
            int coeff = 1;
            int i;
            for (i = 0; i < counter; i++)
            {
                coeff *= 10;
            }
            int newNumber = input + 3 * coeff;
            Console.WriteLine(newNumber);
        }
    }
}
