using System;


	class Program
	{
		static void Main(string[] args)
		{

		Console.WriteLine("Hello, user! This is a console application that will take your input and perform simple math operations. Press enter.");
		Console.ReadLine();

		Console.WriteLine("Please enter a number. It will be multiplied by 50");
		string firstInput = Console.ReadLine();
		int timesFifty = Convert.ToInt32(firstInput);
		int firstAnswer = timesFifty * 50;
		Console.WriteLine(firstAnswer);
		
		Console.WriteLine("Please enter a number. It will have the number 25 added to it.");
		string secondInput = Console.ReadLine();
		int addTwentyFive = Convert.ToInt32(secondInput);
		int secondAnswer = addTwentyFive + 25;
		Console.WriteLine(secondAnswer);

		Console.WriteLine("Please enter a number. It will be divided by 12.5.");
		string thirdInput = Console.ReadLine();
		double divideFunction = Convert.ToInt32(thirdInput);
		double thirdAnswer = divideFunction / 12.5;
		Console.WriteLine(thirdAnswer);

		Console.WriteLine("Please enter a number. We will check if it is greater than 50.");
		string fourthInput = Console.ReadLine();
		int boolFunction = Convert.ToInt32(fourthInput);
		bool fourthAnswer = boolFunction > 50;
		Console.WriteLine(fourthAnswer);

		Console.WriteLine("Please enter a number. It will be divided by 7 and the remainder will be shown.");
		string fifthInput = Console.ReadLine();
		double remainderFunction = Convert.ToInt32(fifthInput);
		double fifthAnswer = remainderFunction % 7;
		Console.WriteLine(fifthAnswer);

		Console.WriteLine("Thank you for using this console app! Have a great day and press enter to exit!");
		Console.ReadLine();

	}
	}

