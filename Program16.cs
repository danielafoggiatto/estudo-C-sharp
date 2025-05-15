﻿namespace ConsoleApp54
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            OddNumbers(numbers);
            ParNumbers(numbers);

            Console.ReadKey();
        }

        static void OddNumbers(int[] numbers)
        {
            Console.WriteLine("Odd numbers");

            IEnumerable<int> oddNumbers = from number in numbers where number %2 != 0 select number;
            Console.WriteLine(oddNumbers);

            foreach (int i in oddNumbers)
            {
                Console.WriteLine(i);
            }
        }

        static void ParNumbers(int[] numbers)
        {
            Console.WriteLine("Par Numbers");

            IEnumerable<int> parNumbers = from number in numbers where number %2 == 0 select number;
            Console.WriteLine(parNumbers);

            foreach(int i in parNumbers)
            {
                Console.WriteLine(i);
            }
        }

    }
}
