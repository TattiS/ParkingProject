
using CarParking.Classes;
using System;
namespace CarParking
{
	class Program
	{
		private static Menu menu = new Menu();
		static void Main(string[] args)
		{
			//Action<string> PushMessageAction = new Action<string>(PushMessage);

			//menu.ShowMenu(PushMessageAction);
			Parking carParking = Parking.Instance;
			Console.ReadLine();

		}

		private static void PushMessage(string message)
		{
			Console.Clear();
			Console.WriteLine("It's a message from the function Show menu {0}", message);
			Console.ReadKey();
		}
	}
}
