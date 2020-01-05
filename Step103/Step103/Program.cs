using System;
using System.Collections.Generic;




class Program
{
	static void Main(string[] args)
	{
		// 1 - 4
		string[] textArray = { "Cat", "Dog", "Turtle", "Fox" };
		Console.WriteLine("Write an adjective to describe an animal.");
		string userInput = Console.ReadLine();

		for (int i = 0; i < textArray.Length; i++)
		{
			Console.WriteLine(userInput + " " + textArray[i]);
		}

		Console.WriteLine("Please press enter to continue");
		Console.ReadLine();

		// 5 creating a number array

		int[] numArray = new int[3];
		for (int i = 0; i <= 2; i++)
		{
			Console.WriteLine("Create an array by typing in a number.\n We will need 3 different numbers.");
			numArray[i] = Convert.ToInt32(Console.ReadLine());
		}

		Console.WriteLine("\nHere is the array you just created! :)");
		foreach (int num in numArray)
		{
			Console.WriteLine(num);
		}

		Console.WriteLine("\nNicely done! Press Enter to continue.");
		Console.ReadLine();

		//Loop for 6-8

		List<string> gotCharacters = new List<string> { "Tyrion", "Bronn", "Jamie", "Robb", "Theon", };
		Console.WriteLine("I've created a list of Game of Thrones Characters.\nThis list includes: Tyrion, Bronn, Jamie, Robb, and Theon.\n\tPlease pick your favorite by typing it their name.");
		string chosenCharacter = Console.ReadLine();
		int actualCharacter = 0;
		bool myIteration = true;
		while (myIteration == true)
		{
			for (int i = 0; i < gotCharacters.Count; i++)
			{
				if (chosenCharacter == gotCharacters[i])
				{
					Console.WriteLine("Here is the matching character you have chosen from the list: " + gotCharacters[i]);
					string myIndex = gotCharacters[i];
					int index = gotCharacters.IndexOf(myIndex);
					Console.WriteLine("The index placement of the character you've chosen in the list is: " + index);
					actualCharacter = 0;
				}

				else
				{
					actualCharacter = actualCharacter + 1;
				}
			}


			if (actualCharacter == gotCharacters.Count)
			{
				Console.WriteLine("That is not one of the options.");
				myIteration = true;
				Console.WriteLine("Please select a character from below:\nTyrion, Bronn, Jamie, Robb, and Theon.");
				chosenCharacter = Console.ReadLine();
				actualCharacter = 0;
			}
			else
			{
				myIteration = false;
			}
		}
		Console.WriteLine("Thank you for your input!\nPlease press enter to continue.");
		Console.ReadLine();

		//Loop for 9-10

		List<string> pokemon = new List<string> { "Pikachu", "Squirtle", "Charmander", "Bulbasaur", "Pikachu", };
		Console.WriteLine("\n\n Pick a pokemon from this list: Pikachu, Squirtle, Charmander, Bulbasaur, Pikachu.");
		Console.WriteLine("Yes, Pikachu is there twice.");
		string chosenPokemon = Console.ReadLine();
		int validPokemon = 0;
		bool pokeIteration = true;
		while (pokeIteration == true)
		{
			for (int i = 0; i < pokemon.Count; i++)
			{
				if (chosenPokemon == pokemon[i])
				{
					Console.WriteLine("Here is the matching character found in this list: " + pokemon[i]);
					int index = i;
					Console.WriteLine("The indexplacement of that pokemon in the list is: " + index);
					validPokemon = 0;
				}
				else
				{
					validPokemon = validPokemon + 1;
				}
			}


			if (validPokemon == pokemon.Count)
			{
				Console.WriteLine("Sorry, that's not right");
				pokeIteration = true;
				Console.WriteLine("Try again but choose from the list already presented.\nBe sure to check your spelling.");
				chosenPokemon = Console.ReadLine();
				validPokemon = 0;
			}
			else
			{
				pokeIteration = false;
			}
		}
		Console.WriteLine("Fantastic! Press Enter to continue to the last part of the program.");
		Console.ReadLine();


		//Loop for 11. It doesn't say to add a user interface aspect to this one so in the interest of time I didn't
		// But if I did I would just write a message saying pick from this list and add a string variable saving the results as done above. 
		List<string> names = new List<string> { "Jacob", "Sam", "Henry", "Jacob" };
		int jacob = 0;
		int sam = 0;
		int henry = 0;
		foreach (string name in names)
		{
			switch (name)
			{
				case "Jacob":
					Console.WriteLine(name);
					jacob += 1;
					break;
				case "Sam":
					Console.WriteLine(name);
					sam += 1;
					break;
				case "Henry":
					Console.WriteLine(name);
					henry += 1;
					break;
			}

			if (jacob > 1)
			{
				Console.WriteLine("\nJacob is Duplicated");
			}
			if (sam > 1)
			{
				Console.WriteLine("\nSam is Duplicated");
			}
			if (henry > 1)
			{
				Console.WriteLine("\nHenry is Duplicated");
			}

			Console.WriteLine("That is all! Thank you for your answers. Press enter to exit. ");

		}


	}
}

