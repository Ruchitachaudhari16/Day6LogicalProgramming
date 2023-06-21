using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LogicalPrgrms
{
    public class PrimeNumber
    {
        //Check Weather the Number is Prime Or Not 


        public  void primeCheck()
        {
            Console.WriteLine("Enter the number weather it is prime or not");
            int number = Convert.ToInt32(Console.ReadLine());
            int count = 0;
            for (int i = 1; i <=number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count==2)
            {
                Console.WriteLine("Number is a Prime");
            }
            else 
            {
                Console.WriteLine("Number is not a Prime");
            }
        }
    }
}
