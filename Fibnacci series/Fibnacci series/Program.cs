using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibnacci_series
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOne = 0, numberTwo = 1, numberThree, number;
            Console.WriteLine("Enter the number of elements ");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine(numberOne+" " +numberTwo+ "  ");
            Console.ReadKey();
            for (int count=2;count< number;++ count) {
                numberThree = numberOne + numberTwo;
                Console.WriteLine(numberThree+ " ");
                Console.ReadKey();
                numberOne = numberTwo;
                numberTwo = numberThree;
                Console.ReadKey();
            }
        }
    }
}
