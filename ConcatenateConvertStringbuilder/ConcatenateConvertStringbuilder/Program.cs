using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConcatenateConvertStringbuilder
{
	class Program
	{
		static void Main(string[] args)
		{

			// Concatenate three strings
			Console.WriteLine("Hello user. What is your name?");
			string name = Console.ReadLine();


			string greeting = "Hello, ";
			string welcome = "Welcome to this console application! :)";

			Console.WriteLine(greeting + name + "! " + welcome + "\n What is your favorite color?");
			string favColor = Console.ReadLine();

			// Convert a string to uppercase
			favColor = favColor.ToUpper();

			Console.WriteLine(favColor + "?!??? NO WAY! " + favColor + " IS MY FAVORITE COLOR!!!!");
			Console.WriteLine("Here's a poem for ya: \n");
			StringBuilder myBuild = new StringBuilder();

			myBuild.Append("Once ");
			myBuild.Append("upon ");
			myBuild.Append("a ");
			myBuild.Append("midnight ");
			myBuild.Append("dreary, ");
			myBuild.Append("while ");
			myBuild.Append("I ");
			myBuild.Append("pondered, ");
			myBuild.Append("weak ");
			myBuild.Append("and ");
			myBuild.Append("weary,\n");
			myBuild.Append("Over ");
			myBuild.Append("many ");
			myBuild.Append("a ");
			myBuild.Append("quaint ");
			myBuild.Append("and ");
			myBuild.Append("curious ");
			myBuild.Append("volume");
			myBuild.Append("of ");
			myBuild.Append("forgotten ");
			myBuild.Append("lore-- ");

			Console.WriteLine(myBuild);
			Console.WriteLine("\n");
			Console.WriteLine("Press Enter to close.");
			Console.ReadLine();
	
			


		}
	}
}
