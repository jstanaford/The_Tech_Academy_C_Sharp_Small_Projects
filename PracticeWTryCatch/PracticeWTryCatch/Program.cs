using System;
using System.Collections.Generic;

class Program
{
	static void Main(string[] args)
	{

		try
		{
			List<int> intList = new List<int> { 33, 71, 99, 100, 23, 900 };
			Console.WriteLine("Let's have some fun with math. Please enter a number.");
			int yourNumber = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("Now dividing a list of numbers by your number rounded down...\n \n");
			foreach (int num in intList)
			{
				int yourDivide = num / yourNumber;
				Console.WriteLine(num + " divded by your number of " + yourNumber + " equals " + yourDivide);
			}
		}
		catch (FormatException ex)
		{
			Console.WriteLine("Please type a non-zero number");
			return;
		}
		catch (DivideByZeroException ex)
		{
			Console.WriteLine("Please don't divide by zero");
		}
		catch (Exception ex)
		{
			Console.WriteLine("Please read the instructions and try again");
		}
		finally
		{
			Console.ReadLine();
			Console.WriteLine("\nThe program has emerged from its try/catch block.");
			
		}

		
		Console.WriteLine("\nThank you for answers! Have a great day! \n\nPress Enter to Exit");
		Console.ReadLine();
	}
}

