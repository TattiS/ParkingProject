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

		//public static readonly int TimeOut { get; set; }
		//public static readonly Dictionary<CarType, double> Prices { get; set; }
		//public static readonly float Fine { get; set; }
		//public static readonly int ParkingSpace { get; set; }
		static Settings()
		{
			TimeOut = 3;
			Fine = 0.3f;
			Prices = new Dictionary<CarType, double>() 
		{
			{CarType.PASSANGER, 3},
			{CarType.MOTOCYCLE, 1},
			{CarType.BUS, 2},
			{CarType.TRUCK,5}
		};
			ParkingSpace = 100;
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
