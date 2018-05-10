using System;

namespace CarParking
{
	class Menu
	{
		private string greeting = "\t\tWelcome to our car park!";
		private string menuItems = "Choose an action that you'd like to do and \n press the necessary key button:\n Press \"A\" - to park a car\n Press \"B\" - to take a car back";

		public void ShowMenu()
		{
			do
			{
				Console.Clear();
				Console.WriteLine(greeting);
				Console.WriteLine(menuItems);
				ConsoleKey pressedKey = Console.ReadKey().Key;

				switch (pressedKey)
				{
					case ConsoleKey.A:
						Console.Clear();
						Console.Write("You want to add a car");
						Console.ReadLine();
						break;
					case ConsoleKey.B:
						Console.Clear();
						Console.Write("You want to remove a car");
						Console.ReadLine();
						break;
					case ConsoleKey.C:
						Console.Clear();
						Console.Write("You want to replenish a balance");
						Console.ReadLine();
						break;
					case ConsoleKey.D:
						Console.Clear();
						Console.Write("You want to see transactions for the last minute");
						Console.ReadLine();
						break;
					case ConsoleKey.E:
						Console.Clear();
						Console.Write("You want to see income");
						Console.ReadLine();
						break;
					case ConsoleKey.Escape:
						return;
					case ConsoleKey.F:
						Console.Clear();
						Console.Write("You want to see free places in our park");
						Console.ReadLine();
						break;
					case ConsoleKey.G:
						Console.Clear();
						Console.Write("You want to see transactions.log");
						Console.ReadLine();
						break;
					case ConsoleKey.H:
						break;
					case ConsoleKey.I:
						break;
				}
			} while (true);
		}


	}
}
