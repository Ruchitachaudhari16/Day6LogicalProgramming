using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrgrms
{
    public class Reverse
    { 
        //Reverse Number
    public void checkReverse()
    {
        int number, reverse = 0, remainder;
        Console.Write("Enter a number: ");
           number = int.Parse(Console.ReadLine());
            while (number != 0)
            {
                remainder = number % 10;
                reverse = reverse*10 + remainder;
                number =number/10;
            }
    Console.Write("Reversed Number: " + reverse);
        }
    }

    }

