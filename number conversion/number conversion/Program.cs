using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace number_conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            int quotient;
            Console.WriteLine("Enter the number");
            int number = int.Parse(Console.ReadLine());
            String remainder = "";
            while (number >= 1) {
                quotient = number / 2;
                remainder+= (number % 2).ToString();
                number = quotient;
            }
            string binary = "";
            for (int count = remainder.Length - 1; count >= 0; count--) {
                binary = binary + remainder[count];
            }
            Console.WriteLine("The binary of number is {0}" , binary);
            Console.ReadKey();
        }
    }
}
