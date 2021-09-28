using System;
using System.Collections.Generic;

namespace Fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the maximum number: ");
            int limit = Convert.ToInt32(Console.ReadLine());
            List<string> print = new List<string>();
            
            
            
            for (int i = 1; i <= limit; i++)
            {
                if (i % 3 == 0)
                {
                    print.Add("Fizz");
                }

                if (i % 13 == 0)
                {
                    print.Add("Fezz");
                }

                if (i % 5 == 0)
                {
                    print.Add("Buzz");
                }

                if (i % 7 == 0)
                {
                    print.Add("Bang");
                }

                if (i % 11 == 0)
                {
                    print.Clear();
                    print.Add("Bong");
                    continue;
                }

                if (i % 17 == 0)
                {
                    print.Reverse();
                }

                if (print.Count == 0)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine(String.Join("", print));
                    print.Clear();
                }
            }
        }
    }
}