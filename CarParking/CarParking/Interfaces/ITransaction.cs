using System;

namespace CarParking.Interfaces
{
	interface ITransaction
	{
		DateTime Time { get; set; }
		int CarId { get; set; }
		double WrittenOffAmount { get; set; }
	}
}
