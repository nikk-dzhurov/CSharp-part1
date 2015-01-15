using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AgeAfter10Years
{
    /*
     * Problem 15.* Age after 10 Years

        Write a program to read your birthday from the console and print how old you 
        are now and how old you will be after 10 years.
     */
    class AgeAfter10Years
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter your birthday in format (dd.MM.yyyy): ");
            string input = Console.ReadLine();
            DateTime birthday = Convert.ToDateTime(input);
            DateTime now = DateTime.Now;
            int currentAge = now.Year - birthday.Year - 
                (now.DayOfYear < birthday.DayOfYear ? 1 : 0);
            int ageAfterTenYears = currentAge + 10;
            Console.WriteLine("You will be : " + ageAfterTenYears + " after 10 years!");
        }
    }
}
