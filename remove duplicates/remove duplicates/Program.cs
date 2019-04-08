using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace remove_duplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1,2,3,4,3,4,3,4,5,7,6,5,6};
            int[] arrayRemove = array.Distinct().ToArray();
            foreach (int count in arrayRemove)
                Console.Write(" {0} " , count);
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
