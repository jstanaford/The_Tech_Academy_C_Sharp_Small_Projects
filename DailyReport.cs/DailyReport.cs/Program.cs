using System;


	class Program
	{
		static void Main(string[] args)
		{
		Console.WriteLine("The Tech Academy");
		Console.ReadLine();

		Console.WriteLine("Student Daily Report");

		Console.WriteLine("What course are you on?");
		string course = Console.ReadLine();

		Console.WriteLine("What page number?");
		string currentPage = Console.ReadLine();
		int numberPage = Convert.ToInt32(currentPage);

		Console.WriteLine("Do you need help with anything? Please answer \"true\" or \"false\"");
		string needHelp = Console.ReadLine();
		bool myHelp = Convert.ToBoolean(needHelp);

		Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
		string positiveExperiences = Console.ReadLine();

		Console.WriteLine("Is there any other feedback you'd like to provide? Please be specific.");
		string otherFeedback = Console.ReadLine();

		Console.WriteLine("How many hours did you study today?");
		string hours = Console.ReadLine();
		int studyHours = Convert.ToInt32(hours);

		Console.WriteLine("Thank you for your answers. An Instructor will respond to this shortly. Have a great day!");
		Console.ReadLine();

		}
	}

