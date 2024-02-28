using System;

namespace Metoder2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tal = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("Skriv in ett tal");
                tal[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine(störst(tal[0], tal[1]));
        }

        static int störst(int tal1, int tal2)
        {
            if (tal1 > tal2)
            {
                return tal1;
            }
            else
            {
                return tal2;
            }
        }
    }
}