using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
	class Program
	{
		
		static void Main(string[] args){
			
			int operation;
            bool flag = false;
			int numberOne = 0, numberTwo = 0;
            do {
                Console.WriteLine("Select the operations you want to perform");
                Console.WriteLine("1.Addition");
                Console.WriteLine("2.Subtarction");
                Console.WriteLine("3.Multiplication");
                Console.WriteLine("4.Division");
                Console.WriteLine("5.Exit");
                operation = int.Parse(Console.ReadLine());
               // Console.WriteLine(operation);
                Console.WriteLine(" Enter the numbers on which we have to perform opereations:");


                switch (operation) {
                    case 1:
                        inputs();
                        Console.WriteLine("The addition of two numbers  is :" + (numberOne + numberTwo));
                        break;
                    case 2:
                        inputs();
                        Console.WriteLine("The subtraction of two numbers is :" + (numberOne - numberTwo));
                        break;
                    case 3:
                        inputs();
                        Console.WriteLine("The multiplication of two numbers is :" + (numberOne * numberTwo));
                        break;
                    case 4:
                        inputs();
                        Console.WriteLine("The division of two numbers is :" + (numberOne / numberTwo));
                        break;
                    case 5:flag = true;
                        
                        break;
                    default:
                        Console.WriteLine("Invalid choice is entered");

                        break;

                }
                Console.ReadKey();
            } while (flag==false);



            int[] inputs()
			{
				Console.WriteLine("Enter the first number");
				numberOne = int.Parse(Console.ReadLine());
				Console.WriteLine("First Number is :" + numberOne);
				Console.WriteLine("Enter second number");
				numberTwo = int.Parse(Console.ReadLine());
				Console.WriteLine("Second Number is :" + numberTwo);
				int[] inputArray = new int[2];
				inputArray[0] = numberOne;
				inputArray[1] = numberTwo;
				return inputArray;
			}

		}

		
	}
}
