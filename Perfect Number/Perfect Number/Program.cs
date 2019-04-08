using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perfect_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0,sum=0;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            flag = number;
            for (int count = 1; count < number; count++) {
                if (number % count == 0) {
                    sum = sum + count;
                }
            }
            if (sum == flag)
                Console.WriteLine("The number is perfect number");
            else
                Console.WriteLine("The number is not perfect number");
            Console.ReadLine();
        }
    }
}
