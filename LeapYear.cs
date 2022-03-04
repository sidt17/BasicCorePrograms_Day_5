using System;

namespace Basicfunctionalprograms
{
    public class LeapYear
    {
        public static void Calculateleapyear() 
        {

            Console.WriteLine("Enter the year :");
            int year = Convert.ToInt32(Console.ReadLine());


            if (year % 400 == 0)
            {
                Console.WriteLine("It is a leap year");

            }
            else if (year % 100 == 0)
            {
                Console.WriteLine(" It is not a leap year");
            }
            else if (year % 4 == 0)
            {
                Console.WriteLine("It is a leap year");
            }
            else
            {
                Console.WriteLine("It is not a leap year");
            }




















        }

    }
}

