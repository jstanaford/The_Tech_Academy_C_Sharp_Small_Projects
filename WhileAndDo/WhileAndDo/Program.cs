using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhileAndDo
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Guess a number? ");
			Console.WriteLine("Hint: the number is between 1 and 20");
			int number = Convert.ToInt32(Console.ReadLine());
			bool isGuessed = number == 13;

			do
			{
				switch (number)
				{
					case 13:
						Console.WriteLine("You guessed the number 13! That is correct!");
						Console.WriteLine("Thank you for playing! Have a good day!");
						Console.WriteLine("Press esc to exit");
						isGuessed = true;
						break;
					default:
						Console.WriteLine("Sorry, that is wrong.");
						Console.WriteLine("Guess again?");
						number = Convert.ToInt32(Console.ReadLine());
						break;

				}
			}
			while (!isGuessed);


			Console.ReadLine();
		}
	}
}
