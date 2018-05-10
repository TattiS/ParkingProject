using System.Collections.Generic;

namespace CarParking.Interfaces
{
    interface IPark
    {
        int TimeOut { get; set; }
        Dictionary<CarType, double> Prices { get; set; }
        float Fine { get; set; }
        int ParkingSpace { get; set; }
        List<ICar> Cars { get; set; }
        List<ITransaction> Transactions { get; set; }
        bool AddCar(ICar car);
        bool RemoveCar(ICar car);
        bool AddToBalance(ICar car, double amount);
        string ShowTransactionsFor(int minute = 1);
        string ShowIncome();
        string ShowFreePlaces();
        string[] ShowLog();

    }
}
