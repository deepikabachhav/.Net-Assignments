using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int Factorial = 1;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            for (int count = 1; count <= number; count++) {
                Factorial = Factorial * count;
            }
            Console.WriteLine("Factorial of the "+number + " is " +Factorial);
            Console.ReadKey();
        }
        
    }
}
