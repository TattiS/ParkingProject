
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
            Parking carParking = Parking.Instance;
            carParking.AddCar(new Car(1234, 1220, CarType.BUS));
            carParking.AddCar(new Car(132, 1245, CarType.MOTOCYCLE));
            carParking.AddCar(new Car(1356, 1220, CarType.PASSANGER));
            carParking.AddCar(new Car(5633, 1220, CarType.TRUCK));
            string[] log = carParking.ShowLog();
            string output = "There is no such file.";
            if (log == null)
            {
                Console.WriteLine(output);
            }
            else
            {
                output = String.Empty;
                for (int index = 0; index < log.Length; index++)
                {
                    output += String.Format("{0}. {1}\n", (index + 1), log[index]);
                }

                Console.WriteLine(output);
            }
            Console.WriteLine(carParking.HasCar(2456));
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
