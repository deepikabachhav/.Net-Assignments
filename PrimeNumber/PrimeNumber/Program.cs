using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0;
            Console.WriteLine("Enter the number to check whether it is prime or not");
            int number = int.Parse(Console.ReadLine());
            for (int count = 2; count <= (number / 2); count++) {
                if (number % count == 0)
                {
                    Console.WriteLine("Number is not prime");
                    flag = 1;
                    break;
                }
            }
            if (flag == 0) {
                Console.WriteLine("Number is a prime");
            }
            Console.ReadKey();

        }

    }
}
