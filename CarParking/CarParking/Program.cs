
using CarParking.Classes;
using CarParking.Interfaces;
using System;
namespace CarParking
{
	class Program
	{
		private static Menu menu = new Menu();
		static void Main(string[] args)
		{
			//Parking carParking = Parking.Instance;
			Car car = new Car(12, 12.3, CarType.BUS);
			Console.WriteLine(car.CarId + car.CarBalance + car.CarType.ToString());

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
