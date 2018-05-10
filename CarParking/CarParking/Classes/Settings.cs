using CarParking.Interfaces;
using System.Collections.Generic;

namespace CarParking.Classes
{
	static class Settings
	{
		public static int TimeOut { get; private set; }
		public static Dictionary<CarType, double> Prices { get; private set; }
		public static float Fine { get; private set; }
		public static int ParkingSpace { get; private set; }


		static Settings()
		{
			TimeOut = 3;
			Fine = 0.3f;
			ParkingSpace = 100;
			Prices = new Dictionary<CarType, double>();
			Prices.Add(CarType.PASSANGER, 3);
			Prices.Add(CarType.MOTOCYCLE, 1);
			Prices.Add(CarType.BUS, 2);
			Prices.Add(CarType.TRUCK, 5);

		}
		//public Settings(int parkingSpace, Dictionary<CarType, double> prices, int timeOut, float fine)
		//{
		//	TimeOut = timeOut;
		//	Prices = prices;
		//	ParkingSpace = parkingSpace;
		//	Fine = fine;
		//}
		public static void SetSettings(IPark parking)
		{
			parking.TimeOut = TimeOut;
			parking.Fine = Fine;
			parking.ParkingSpace = ParkingSpace;
			parking.Prices = Prices;
		}
	}

}
