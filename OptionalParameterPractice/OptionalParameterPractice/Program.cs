using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OptionalParameterPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			MyMath constant = new MyMath();
			Console.WriteLine("Hello user! Welcome to this program.\nWe're going to add 100 to two numbers or just one. \nPlease input the first number:");
			int firstInput = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nPlease input the second number only if you wish. Can be left blank by pressing enter.");
			string secondInput = Console.ReadLine();
		
			Console.WriteLine("\nProcessing your request...");
			Console.WriteLine("...\n...\n\n\nPress enter to view results.");
			Console.ReadLine();
			if (secondInput == "")
			{
				Console.WriteLine(constant.MyFunMethod(firstInput));
			}
			else
			{

				Console.WriteLine(constant.MyFunMethod(firstInput, Convert.ToInt32(secondInput)));
			}
			
			Console.WriteLine("\nThank you for you inputs! Have a great day and press enter to quit.");
			Console.ReadLine();



		}
	}


	public class MyMath
	{
		//My Property
		public int MyProperty { get; set; }

		//My Method
		public int MyFunMethod(int numOne, int numTwo = 0)
		{
			int numThree = 100 + numTwo + numOne;
			return (numThree);
		}


	}
}
