using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticOutputPractice
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Welcome to my program.  Enter a number you want divided by two pls thanks.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			VoidClass myDivision = new VoidClass();
			myDivision.VoidMethod(userInput);


		}
	}


	class VoidClass
	{
		//Property 
		public int MyProperty { get; set; }

		public void VoidMethod(int numTwo)
		{
			int numOne = numTwo / 2;
			Console.WriteLine(numOne);
		}


		//output paramter method
		public static void OutPutMethod()
		{ 
			int i;
			OutPutMethod2(out i);
			Console.WriteLine("The addition of this value is {0}", i);
		}

		public static void OutPutMethod2(out int i)
		{
			i = 30;
			i += i;
		}

		//overloading:

		static int MyPlus(int x, int y)
		{
			return x + y;
		}
		static double MyPlus(double x, double y)
		{
			return x + y;
		}

	}
}
