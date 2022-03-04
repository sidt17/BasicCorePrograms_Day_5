using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Basicfunctionalprograms
{
    public class QuotientandRemainder
    {

        public static void CalculateQuotientAndRemainder()
        {
            int dividend;
            int divisor;
            Console.WriteLine("Enter the Dividend value :");
            dividend = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the Divisor value :");
            divisor = Convert.ToInt32(Console.ReadLine());

            int quotient = dividend / divisor;
            int remainder = dividend % divisor;


            Console.WriteLine("Quotient : {0}", quotient);
            Console.WriteLine("Remainder : {0}", remainder);
        }
    }


}      

