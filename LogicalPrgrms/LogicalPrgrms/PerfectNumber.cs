using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrgrms
{
    public class PerfectNumber
    {
        public void CheckPerfectNumber()

        {
            //Perfect Number
            Console.WriteLine("Enter the number to check");
            int input = Convert.ToInt32(Console.ReadLine());

            int sum = 0;
          
            for (int i = 1; i < input; i++)
            {
                if (input % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (sum == input)
            {
                Console.WriteLine("\n Entered number is a perfect number");
                
            }
            else
            {
                Console.WriteLine("The number is a not perfect number");
            }
        }
    }
}
