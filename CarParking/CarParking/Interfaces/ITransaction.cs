using System;

namespace CarParking.Interfaces
{
    interface ITransaction
    {
        DateTime Time { get; }
        int CarId { get; }
        double WrittenOffAmount { get; }
    }
}
