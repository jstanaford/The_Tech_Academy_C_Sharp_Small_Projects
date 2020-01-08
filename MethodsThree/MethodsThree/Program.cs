using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsThree
{
	class Program
	{
		static void Main(string[] args)
		{
			Class1 constant = new Class1();
			constant.MyMath = 100;


			Console.WriteLine("Hello, User!\nThis is my exercise for step 111 of the Tech Academy.\n");
			Console.WriteLine("In this program, I will ask you for a number.\nThen I will add, subtract, and multiply that number by 100.");



			Console.WriteLine("Please enter a number you would like added by 100 then press enter.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");
			userInput = constant.MyMethod1(userInput);
			Console.WriteLine("Your number is: " + userInput);
			Console.ReadLine();



			Console.WriteLine("Please enter a number you would like subtracted by 100 then press enter.");
			int userInput2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");
			userInput2 = constant.MyMethod2(userInput2);
			Console.WriteLine("Your number is: " + userInput2);
			Console.ReadLine();

			Console.WriteLine("Please enter a number you would like multiplied by 100 then press enter.");
			int userInput3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");
			userInput3 = constant.MyMethod3(userInput3);
			Console.WriteLine("Your number is: " + userInput3);
			Console.ReadLine();

			Console.WriteLine("\n\nThank you for playing! Press enter to close.");
			Console.WriteLine();
		}
	}
}
