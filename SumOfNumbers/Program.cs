using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
           
            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Enter a number to be averaged\nEnter 0 if no more numbers:   ");
             
                int number = int.Parse(Console.ReadLine());

                if (number == 0)
                {
                    i = 10;
                }
                sum = sum + number;

                Console.WriteLine($"\nSubtotal: {sum}\n\n");  
            }
            Console.WriteLine($"The sum of these numbers is {sum}");
            Console.ReadLine();
        }
    }
}
