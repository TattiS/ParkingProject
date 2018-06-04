
using System;
namespace CarParking
{
    class Program
    {
        private static ParkManager manager = new ParkManager();
        static void Main(string[] args)
        {
            try
            {
                manager.ShowMenu();

            }
            catch (Exception ex)
            {
                PushMessage(ex.Message);
            }
            finally
            {
                manager.Dispose();
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
