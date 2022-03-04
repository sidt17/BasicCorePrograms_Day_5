using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicfuctionalprograms
{
    public class Primefactorization
    {
        public static void Factors()
        {
            int n;

            Console.WriteLine("Please enter the value of n :");
            n = Convert.ToInt32(Console.ReadLine());

            double fact = 1;

            for (int i = 1; i <= n; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("factorial of {0}={1}", n, fact);
            Console.ReadLine();

        }

    }

}