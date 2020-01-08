using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_N_Stuff
{
	public class Class1
	{
		public MyMath(int constant = 100)
		{
			int Total1 = userInput + constant;
			Console.WriteLine("Your number of " + userInput + " plus 100 equals " + Total1);
		
			int Total2 = userInput2 - constant;
			Console.WriteLine("Your second number of " + userInput2 + " minus 100 equals " + Total2);

			int Total3 = userInput3 * constant;
			Console.WriteLine("Your third number of " + userInput3 + " mulitplied by 100 equals " + Total3);
		}
		public string MyMath { get; set; }
	
	
	}
	
}
