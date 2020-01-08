using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VoidMethodPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			
		
			Console.WriteLine("Hello, welcome to this program. Press enter to see something.");
			Console.ReadLine();

			MyMath constant = new MyMath();
			constant.VoidMethod(12, 73);
			constant.VoidMethod(numTwo: 12, numOne: 73);
			Console.ReadLine();

		}

		
	}

	public class MyMath
	{
		public int MyProperty { get; set; }


		public void VoidMethod(int numOne, int numTwo)
		{
			numOne = numOne * numOne;
			Console.WriteLine(numTwo);

		}
	}
}
