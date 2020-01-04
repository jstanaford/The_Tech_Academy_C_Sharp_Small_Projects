using System;
using System.Collections.Generic;


	class Program
	{
		static void Main()
		{
		Console.WriteLine("Let's play a game with some choices. \nPress enter to begin! ");
		Console.ReadLine();


		string[] stringArray = { "Tyrion", "Jon", "Robert", "Jamie", "Bronn" };
		foreach (string i in stringArray)
		{
			Console.WriteLine(i);
		}
		try
		{
			Console.WriteLine("Please pick one of these characters by typing its index(0-4).");
			int selection = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You have picked " + stringArray[selection] + "\n");
			Console.WriteLine("Nice. Press Enter to continue.");
			Console.ReadLine();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}


		
		int[] intArray = { 3, 4, 5, 6, 9 };
		foreach (int i in intArray)
		{
			Console.WriteLine(i);
		}
		try
		{
			Console.WriteLine("Please pick one of these numbers by typing its index of 0-4.");
			int selection1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You have picked " + intArray[selection1] + "\n");
			Console.WriteLine("Nicely done. Press Enter to continue.");
			Console.ReadLine();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}




		List<string> myList = new List<string>();
		myList.Add("Stan");
		myList.Add("Steve");
		myList.Add("Francine");
		myList.Add("Haley");
		myList.Add("Jeff");
		myList.Add("Roger");
		myList.Add("Klaus");
		foreach (string i in myList)
		{
			Console.WriteLine(i);
		}
		try
		{
			Console.WriteLine("Please pick one of these characters by typing its index of 0-6.");
			int selection2 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("You have picked " + (myList[selection2]) + "\n");
			Console.WriteLine("Wunderbar. All answers have been saved. \n Thanks for playing.\n Press enter to exit!");
			Console.ReadLine();
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
			Console.WriteLine("You have finished with our questions.\n Have a good one my dude!\n Press enter to close.");
			Console.ReadLine();
		}

	}
	}

