using System;


namespace Basicfunctionalprograms
{
    public class powerof2
    {
        public static void Printpower()
        {
            Console.WriteLine("Please enter the value of n: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int power = 1;
            if (n <= 31)
            {
                for (int i = 1; i <= n; i++)
                {
                    power = power * 2;
                }

                Console.WriteLine("The power of 2= " + power);





            }
        }
    }


}

