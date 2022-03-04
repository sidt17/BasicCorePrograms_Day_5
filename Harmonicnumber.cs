using System;


namespace Basicfunctionalprograms
{
    public class Harmonicnumber
    {

        public static void CalculateHarmonicno()
        {
            Console.WriteLine(" Please enter the value of n");
            int n = Convert.ToInt32(Console.ReadLine());
            int i;
            double s = 0;
            for (i = 1; i <= n; i++)
            {
                Console.WriteLine("1/" + i);
                s += 1 / (float)i;
            }

            Console.WriteLine("harmonic mean upto " + n + " = " + s);

        }
    }



}

