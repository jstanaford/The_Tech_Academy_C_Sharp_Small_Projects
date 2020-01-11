using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimePractice
{
	class Program
	{
		static void Main(string[] args)
		{
			DateTime currentTime = DateTime.Now;
			Console.WriteLine("Hello, world! :) \n\nThe current time is: " + currentTime);


			Console.WriteLine("\n\n Please enter a number");
			int userInput = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nThe time " + userInput + " hours from " + currentTime+ " is: ");
			TimeSpan duration = new TimeSpan(0, userInput, 0, 0);
			DateTime answer = currentTime.Add(duration);
			Console.Write(answer);


			Console.WriteLine("\n\n\nThank you for playing.\nPress Enter to exit");
			Console.ReadLine();
		}
	}
}
