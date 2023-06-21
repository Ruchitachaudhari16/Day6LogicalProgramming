using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrgrms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Logical Programming");
            Console.WriteLine("Enter the choice ");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series");
                    FibonacciSeries series = new FibonacciSeries();
                    series.getFibonacciSeries();
                    break;
            }
            Console.ReadLine();
        }
    }
}
