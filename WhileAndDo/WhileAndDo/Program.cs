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
				{

				Console.WriteLine("Guess a number? ");
				Console.WriteLine("Hint: the number is between 1 and 20");
				Console.WriteLine("In case you were curious, here are the numbers one through 20:");
				{
					int i = 0;
					while (i < 21)
					{
						Console.WriteLine(i);
						i++;
					}
				}
				int number = Convert.ToInt32(Console.ReadLine());
				bool isGuessed = number == 13;
					
				do
				{
					switch (number)
					{
						case 13:
							Console.WriteLine("You guessed the number 13! That is correct!");
							Console.WriteLine("Thank you for playing! Have a good day!");
							Console.WriteLine("Press enter to exit");
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
}
