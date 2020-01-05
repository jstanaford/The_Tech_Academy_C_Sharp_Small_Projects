using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{
		List<int> intList = new List<int>();
		intList.Add(40);
		intList.Add(12);
		intList.Add(110);

		Console.WriteLine("Let's have some fun with math. Please enter a number.");
		int yourNumber = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine("Now dividing a list of numbers by your number...\n 40, 12, 110 divided by your number is: \n");
		try
		{
			for (int i = 0; i < intList.Count; i++)
			{
				Console.WriteLine(intList[i] / yourNumber);
			}
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Please type a whole number");
			return;
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Please don't divide by zero");
		}
		catch (Exception ex)
		{
			Console.WriteLine(ex.Message);
		}
		finally
		{
			Console.ReadLine();
		}

		Console.WriteLine("\nThe program has emerged from its try/catch block.");
		Console.WriteLine("\nThank you for answers! Have a great Day! \n\nPress Enter to Exit");
		Console.ReadLine();
	}
}

