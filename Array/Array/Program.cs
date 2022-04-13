using System;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sozlerin sayini daxil edin:");
            int wordsCount = Convert.ToInt32(Console.ReadLine());
            string[] words = new string [wordsCount];
            Console.WriteLine("Sozleri daxil edin:");
            int i;
            for (i = 0; i < wordsCount; i++)
            {
                words[i] = Console.ReadLine();
            }
            Console.WriteLine("\n");
            foreach (string str in words)
            {
                if (str.Length > 5)
                {
                    Console.WriteLine(str);
                }
            }
        }
    }
}
