using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace TxtFileLogPRactice
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Hello,user!\nPlease enter whatever text you would like saved to a txt file on your desktop!");
			string userInput = Console.ReadLine();
			Console.WriteLine("\n\t\tSaving...");
			File.WriteAllText(@"C:\Users\Student\Desktop\userInput.txt", userInput);
			string text = File.ReadAllText(@"C:\Users\Student\Desktop\userInput.txt");
			Console.WriteLine("\n\n\nYou saved: " + text + " \n\tto a txt file on your desktop!");
			Console.WriteLine("\n\nThanks for playing; press enter to exit!");
			Console.ReadLine();


		}
	}
}
