using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array_sorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int count, counter;
            int[] array = new int[15];
            Console.WriteLine("Enter the number of elemen" +
                "ts for sorting");
            int number = Convert.ToInt16(Console.ReadLine());
            for( count=1; count<=number; count++)
            {
                Console.Write("Enter the number "+ count + " element:");
                array[count] = Convert.ToInt16(Console.ReadLine());
            }
            for ( count = 1; count <= number; count++) {
                for ( counter =1; counter <= number-1; counter++)
            {
                if (array[counter] > array[counter + 1]) {
                   int  temp = array[counter];
                    array[counter] = array[counter + 1];
                    array[counter + 1] = temp;
                }
            }
            }Console.WriteLine(" Sort in ascending oder :");
            for (count = 1; count <= number; count++) {
                Console.Write(array[count]+ " ");

            }
            Console.ReadKey();

        }
    }
}
