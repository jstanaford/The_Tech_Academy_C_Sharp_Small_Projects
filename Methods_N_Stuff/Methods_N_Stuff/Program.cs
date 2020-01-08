using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_N_Stuff
{
	class Program
	{

		static void Main(string[] args)
		{
			Console.WriteLine("Hello, User!\nThis is my exercise for step 111 of the Tech Academy.\n");
			Console.WriteLine("In this program, I will ask you for a number.\nThen I will add, subtract, and multiply that number by 100.");
			

			Console.WriteLine("Please enter a number you would like added by 100 then press enter.");
			int userInput = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");
			

			Console.WriteLine("Please enter a number you would like subtracted by 100 then press enter.");
			int userInput2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");


			Console.WriteLine("Please enter a number you would like multiplied by 100 then press enter.");
			int userInput3 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("\nCalculating your number...\n\n");

			

		}
		
	}
}
