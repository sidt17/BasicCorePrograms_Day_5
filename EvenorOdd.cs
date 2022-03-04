using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicfunctionalprograms
{

    public class EvenorOdd
    {
        public static void Checknumbers()
        {
            int n;
            Console.WriteLine("Enter the number : ");
            n = Convert.ToInt32(Console.ReadLine());
            if (n % 2 == 0)
            {
                Console.WriteLine("It is a even number.");
            }

            else
            {
                Console.WriteLine("It is a odd number.");
            }
        }

    }

}
