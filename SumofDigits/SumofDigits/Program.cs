using System;

namespace SumofDigits
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin:");
            int n = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            while (n != 0)
            {
                sum = n % 10 + sum;
                n = n / 10;
            }
            Console.WriteLine("\nEdedin reqemlerinin cemi:\n" + sum);
        }
    }
}
