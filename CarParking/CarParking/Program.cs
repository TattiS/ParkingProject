
using CarParking.Classes;
using System;
namespace CarParking
{
    class Program
    {
        private static Menu menu = new Menu();
        static void Main(string[] args)
        {
            Parking carParking = Parking.Instance;
            if (carParking.ShowLog() == null)
                Console.WriteLine("There is no such file.");

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
