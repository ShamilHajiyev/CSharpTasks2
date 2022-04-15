using System;

namespace Mod7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir eded daxil edin: ");
            int input = Convert.ToInt32(Console.ReadLine());
            int mod = input % 7;
            int result;
            if (mod > 3)
            {
                result = input + 7 - mod;
                Console.WriteLine(result);
            }
            else if (mod == 0)
            {
                Console.WriteLine("Eded yeddiye qaliqsiz bolunur.");
            }
            else
            {
                result = input - mod;
                Console.WriteLine(result);
            }
        }
    }
}
