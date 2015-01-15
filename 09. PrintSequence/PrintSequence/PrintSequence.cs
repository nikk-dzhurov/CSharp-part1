using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintSequence
{
    /*
     * Problem 9. Print a Sequence

        Write a program that prints the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...
     */
    class PrintSequence
    {
        static void Main(string[] args)
        {
            int a = 2;
            for (int i = 0; i < 10; i++)
            {
                Console.Write(a);
                if (i < 9)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
                if (a < 0)
                {
                    a -= 1;
                }
                else
                {
                    a += 1;
                }
                a *= -1;
            }
        }
    }
}
