using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, remainder, sum=0,flag = 0;
            Console.WriteLine("Enter the the number ");
            number = int.Parse(Console.ReadLine());
            flag = number;
            while (number>0) {
                remainder = number % 10;
                sum = (sum * 10) + remainder;
                number = number / 10;
            }
            if (flag == sum)
                Console.WriteLine("The number is palindrome");
            else
            {
                Console.WriteLine("The number is not palindrome");
            }
            Console.ReadKey();

        }
        
   
    }
}
