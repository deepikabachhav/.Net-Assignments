using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Armstrong_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, remainder,sum=0;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            flag = number;
            while (number > 0) {
                remainder = number % 10;
                sum = sum  + (remainder*remainder*remainder);
                number = number / 10;
            }
            if (flag == sum)
                Console.WriteLine("The number is Armstrong number");
            else
                Console.WriteLine("The number is not armstrong number");
            Console.ReadKey();
        }
        
    }
}
