using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int num1, num2, result;
			Console.WriteLine("Enter first number");
			num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Enter second number");
			num2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("1.ADD");
			Console.WriteLine("2.SUBTRACT"); 
			Console.WriteLine("3.MULTIPLY"); 
			Console.WriteLine("4.DIVIDE");
			Console.WriteLine("enter choice(1-4)");
            int ch = Int16.Parse(Console.ReadLine());
            switch (ch)
            {
                case 1:
                    result = num1 + num2;
                    Console.WriteLine("Sum = {0}", result);
                    break;
                case 2:
                    result = num1 - num2;
                    Console.WriteLine("Difference = {0}", result);
                    break;
                case 3:
                    result = num1 * num2;
                    Console.WriteLine("Product = {0}", result);
                    break;
                case 4:
                    result = num1 / num2;
                    Console.WriteLine("Quotient = {0}", result);
                    break;
                default:
                    Console.WriteLine("Invalid Choice");
                    break;
            }


            }
	}
}
