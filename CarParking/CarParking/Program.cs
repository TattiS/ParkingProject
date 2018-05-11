
using CarParking.Classes;
using CarParking.Interfaces;
using System;
namespace CarParking
{
    class Program
    {
        private static ParkManager manager = new ParkManager();
        static void Main(string[] args)
        {
            Parking carParking = Parking.Instance;
            if (carParking != null)
            {
                manager.CarParking = carParking;
            }
            carParking.AddCar(new Car(CarType.BUS, 1234, 1.0));
            carParking.AddCar(new Car(CarType.MOTOCYCLE, 1326, 1245));
            carParking.AddCar(new Car(CarType.PASSANGER, 1356, 1220));
            carParking.AddCar(new Car(CarType.TRUCK, 5633, 1220));

            try
            {
                manager.ShowMenu();

            }
            catch (Exception ex)
            {
                //throw;
                PushMessage(ex.Message);
            }



        }

        private static void PushMessage(string message)
        {
            Console.Clear();
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
