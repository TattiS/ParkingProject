
namespace CarParking.Interfaces
{
	enum CarType : byte { PASSANGER, TRUCK, BUS, MOTOCYCLE }
	interface ICar
	{
		int CarId { get; }
		double CarBalance { get; }
		CarType CarType { get; }
		void PayRent(double rent);
		void AddToBalance(double money);

	}
}
