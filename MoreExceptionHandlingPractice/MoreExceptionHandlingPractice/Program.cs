using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreExceptionHandlingPractice
{
	class Program
	{
		static void Main(string[] args)
		{
			

			try
			{

				DateTime currentTime = DateTime.Now;
				Console.WriteLine("Hello, person!\nHow old are you?");
				int userInput = Convert.ToInt32(Console.ReadLine());

				if (userInput < 0)
				{
					throw new NonPositiveException();
				}

				int birthYear = 2020 - userInput;
				Console.WriteLine("You were born in the year: " + birthYear );
				Console.ReadLine();

			}
			catch (NonPositiveException)
			{
				Console.WriteLine("Please come back when you want to enter a positive non zero number");
				Console.ReadLine();
				return;
			}
			catch (Exception)
			{
				Console.WriteLine("Something you entered wasn't quite right...");
				Console.ReadLine();
				return;
			}
			Console.WriteLine("Auf Wiedersehen! Have a gute day!");
			Console.ReadLine();


		}
		public class NonPositiveException : Exception
		{
			public NonPositiveException()
			: base() { }

			public NonPositiveException(string message)
				: base(message) { }

		}
	}
}
