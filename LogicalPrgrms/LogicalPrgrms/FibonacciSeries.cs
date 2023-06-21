using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrgrms
{
    public class FibonacciSeries
    {
        //FibonacciSeries.
        public void getFibonacciSeries()
        {
            int a = 0;
            int b = 1;
            int c;
            Console.WriteLine("Enter the number to print fibonacci Series");
             int number=Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine(a);
            Console.WriteLine(b);
            for (int i = 0; i <number; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                a = b;
                b=c;

            }
            

            
        }
    }
}
