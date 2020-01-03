using System;



	class Program
	{
		static void Main(string[] args)
		{
		Console.WriteLine("Anonymous Incom Comparison Program");


		Console.WriteLine("Person 1");

		Console.WriteLine("Hourly Rate?");
		string hourlyOne = Console.ReadLine();
		int hourlyOneRate = Convert.ToInt32(hourlyOne);
	
		Console.WriteLine("Hours worked per week?");
		string oneWeek = Console.ReadLine();
		int oneWeekHours = Convert.ToInt32(oneWeek);


		Console.WriteLine("Person 2");

		Console.WriteLine("Hourly Rate?");
		string hourlyTwo = Console.ReadLine();
		int hourlyTwoRate = Convert.ToInt32(hourlyTwo);

		Console.WriteLine("Hours worked per week?");
		string twoWeek = Console.ReadLine();
		int twoWeekHours = Convert.ToInt32(twoWeek);


		Console.WriteLine("Annual salary of Person 1:");
		double annualOne = hourlyOneRate * oneWeekHours;
		double actualAnnualOne = annualOne * 52.143;
		Console.WriteLine(actualAnnualOne);

		Console.WriteLine("Annual salary of Person 2:");
		double annualTwo = hourlyTwoRate * twoWeekHours;
		double actualAnnualTwo = annualTwo * 52.143;
		Console.WriteLine(actualAnnualTwo);

		Console.WriteLine("Does Person 1 make more than Person 2? ");
		bool boolComparison = actualAnnualOne > actualAnnualTwo;
		Console.WriteLine(boolComparison);


		Console.WriteLine("Thank you for your answers. Press enter to exit.");
		Console.ReadLine();
	}
}

