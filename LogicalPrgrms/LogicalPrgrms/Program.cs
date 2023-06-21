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
            Console.WriteLine("1:Fibonacci Series");
            Console.WriteLine("2:Prime Number");
            Console.WriteLine("3:Reverse Number");
            int choice=Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("Fibonacci Series");
                    FibonacciSeries series = new FibonacciSeries();
                    series.getFibonacciSeries();
                    break;

                    case 2:
                    Console.WriteLine("Prime Number");
                    PrimeNumber primeNumber = new PrimeNumber();
                    primeNumber.primeCheck();
                    break;

                    case 3:
                    Console.WriteLine("Reverse Number");
                    Reverse reverse = new Reverse();
                    reverse.checkReverse();
                    break;
            }
            Console.ReadLine();
        }
    }
}
