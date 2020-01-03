using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");
			Console.WriteLine("Please enter the package weight");
			int packageWeight = Convert.ToInt32(Console.ReadLine());

			if (packageWeight > 50)
			{
				Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
				Console.WriteLine("Close window by pressing enter");
				Console.ReadLine();
			}
			else if (packageWeight <= 50)
			{
				Console.WriteLine("What is the package width?");
				int packageWidth = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("What is the package height?");
				int packageHeight = Convert.ToInt32(Console.ReadLine());
				Console.WriteLine("What is the package length?");
				int packageLength = Convert.ToInt32(Console.ReadLine());

				int basicDimensions = packageWidth + packageLength + packageHeight;

				if (basicDimensions > 50)
				{
					Console.WriteLine("Package too big to be shipped via Package Express");
					Console.WriteLine("Close window by pressing enter");
					Console.ReadLine();
				}
				else if (basicDimensions <= 50)
				{
					float totalDimensions = ((basicDimensions * packageWeight) / 100);
					Console.WriteLine("Your estimated total for shipping this package is: $" + totalDimensions);
					Console.WriteLine("Thank you for shopping with us today. Please press enter to exit.");
					Console.ReadLine();
				}

			}
		}
	}
}
