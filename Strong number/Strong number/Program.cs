using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strong_number
{
    class Program
    {
        static void Main(string[] args)
        {
            int flag = 0, sum = 0,fact=1;
            Console.WriteLine("check whether the number is strong number or not");
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            flag = number;
            for (int counter = number; counter > 0; counter = counter / 10) {
                fact = 1;
                for (int count=1; count <= counter%10; count++) {
                    fact = fact * count;
                }
                sum = sum + fact;
            }
            if (sum == flag)
            {
                Console.WriteLine("The number is strong number");
                Console.ReadKey();
            }
            else {
                Console.WriteLine("The number is not strong number");
                Console.ReadKey();
            }
        }
    }
}
