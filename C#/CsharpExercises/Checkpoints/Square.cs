using System;
using System.Collections.Generic;
using System.Text;

namespace Checkpoints
{
    class Square
    {
        public static void DrawSquare(int l, int s)
        {


            for (int i = 0; i < l; i++)
            {
                for (int k = 0; k < s; k++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < l; j++)
                {
                    Console.Write("0");
                }

                Console.WriteLine();
            }

            Console.WriteLine();
        }
    }
}
