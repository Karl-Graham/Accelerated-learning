using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoints
{
    class Multiplication
    {
        public static void MultiplicationTable(int v)
        {
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;


            for (int i = 1; i <= v; i++)
            {
                Console.WriteLine("┎──────────────────────────┒");
                Console.WriteLine($"│Multiplication table for {i}│");
                Console.WriteLine("└──────────────────────────┙");

                for (int j = 1; j <= 10; j++)
                {
                    Console.WriteLine($"{i} * {j} = {i * j}");
                }

                Console.WriteLine();
            }
        }
    }
}
