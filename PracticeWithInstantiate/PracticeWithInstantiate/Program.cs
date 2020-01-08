using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeWithInstantiate
{
	class Program
	{
		
		static void Main(string[] args)
		{
			Console.WriteLine("\n\t\tHere is my program. \n\t\tGet ready for some random math. \n\t\tPress enter to begin.");
			Console.ReadLine();
			MathNStuff constant = new MathNStuff();
			Console.WriteLine(constant.MyMethod(12));
			Console.ReadLine();

			MathNStuff constant2 = new MathNStuff();
			Console.WriteLine(constant2.MyMethod(.43m));
			Console.ReadLine();

			MathNStuff constant3 = new MathNStuff();
			Console.WriteLine(constant3.MyMethod("five"));
			Console.ReadLine();
		}
	}



	public class MathNStuff
	{
		//My Property
		public int MyProperty { get; set; }

		//My Method
		public int MyMethod(int numOne)
		{
			int answerOne = numOne * 10;
			return (answerOne);

		}

		public int MyMethod(decimal numTwo)
		{
			decimal answerTwo = numTwo * 100;
			return Convert.ToInt32(answerTwo);
		}

		public int MyMethod(string numThree)
		{
			int AnswerThree = (Convert.ToInt32(numThree) % 2);
			return (AnswerThree);
			
		}
	}
}
