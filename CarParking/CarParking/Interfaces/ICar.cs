
namespace CarParking.Interfaces
{
	enum CarType : byte { PASSANGER, TRUCK, BUS, MOTOCYCLE }
	interface ICar
	{
		int CarId { get; set; }
		double CarBalance { get; set; }
		CarType CarType { get; set; }
		void PayRent(decimal rent);
		void AddToBalance(decimal money);

	}
}
