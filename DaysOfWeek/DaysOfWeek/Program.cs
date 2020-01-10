using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DaysOfWeek
{
	class Program
	{
		static void Main(string[] args)
		{
			try
			{
				Console.WriteLine("Welcome to the days of the Week Program.\nPlease enter below the current day of the week: ");
				string userInput = Console.ReadLine();

				Console.WriteLine("You entered {0}", userInput, Enum.Parse(typeof(DaysOfTheWeek), userInput));
				Console.WriteLine("Please press enter.");
				Console.ReadLine();
			}
			catch (Exception e)
			{
				Console.WriteLine("Please enter an actual day of the week: ");
				string userInput = Console.ReadLine();

				Console.WriteLine("You entered {0}", userInput, Enum.Parse(typeof(DaysOfTheWeek), userInput));
				Console.WriteLine("\nPlease press enter.");
				Console.ReadLine();

			}
		

			Console.WriteLine("Thank you for playing! Have a merry, merry day dude!");
			Console.ReadLine();


		}
		public enum DaysOfTheWeek
		{
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday,
			Sunday
		}
	}
}
