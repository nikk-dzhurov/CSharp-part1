using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLongSequence
{
    /*
     * Problem 16.* Print Long Sequence

        Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
        You might need to learn how to use loops in C# (search in Internet).
     */
    class PrintLongSequence
    {
        static void Main(string[] args)
        {
            int number = 2;
            for (int i = 0; i < 1000; i++)
            {
                Console.Write(number);
                number *= -1;
                if(i<999)
                {
                    Console.Write(", ");
                }
                else
                {
                    Console.WriteLine();
                }
                if (number < 0)
                {
                    number--;
                }
                else
                {
                    number++;
                }
            }
        }
    }
}
