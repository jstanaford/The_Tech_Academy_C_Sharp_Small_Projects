using System;



namespace CarInsurance
{
	class Program
	{
		static void Main(string[] args)
		{

			Console.WriteLine("This is the basic approval program for car insurance.");
			Console.WriteLine("Please press enter and we will start with some basic questions");
			Console.ReadLine();


			Console.WriteLine("What is your age?");
			string age = Console.ReadLine();
			int actualAge = Convert.ToInt32(age);

			Console.WriteLine("Have you ever had a DUI? Please answer true or false.");
			string DUI = Console.ReadLine();
			bool actualDUI = Convert.ToBoolean(DUI);

			Console.WriteLine("how many speeding tickes have you had?");
			string tickets = Console.ReadLine();
			int actualTickets = Convert.ToInt32(tickets);


			Console.WriteLine("Here are your results:");
			Console.WriteLine("What is your age?");
			Console.WriteLine(actualAge);
			Console.WriteLine("Have you ever had a DUI?");
			Console.WriteLine(actualDUI);
			Console.WriteLine("Qualified?");
			bool result = ((actualAge > 15) && (actualDUI == false) && (actualTickets < 4));
			Console.WriteLine(result);

			Console.WriteLine("Thank you for taking the time to fill this out.");
			Console.WriteLine("Please press enter to close this window &");
			Console.WriteLine("Have a great day!");
			Console.ReadLine();
		}
	}
}
