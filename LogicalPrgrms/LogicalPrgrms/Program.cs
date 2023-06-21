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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Logical Programming");
                Console.WriteLine("1:Fibonacci Series");
                Console.WriteLine("2:Prime Number");
                Console.WriteLine("3:Reverse Number");
                Console.WriteLine("4:Perfect Number");
                {
                    Console.WriteLine("Enter the choice ");
                    int choice = Convert.ToInt32(Console.ReadLine());
                    {
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

                            case 4:
                                Console.WriteLine("Perfect Number");
                                PerfectNumber perfectNumber = new PerfectNumber();
                                perfectNumber.CheckPerfectNumber();

                                break;

                            default:
                                Console.WriteLine("enter a valid choice");
                                flag = false;
                                break;
                        }

                        Console.ReadLine();

                    }

                }
            }
        }
    }
}

