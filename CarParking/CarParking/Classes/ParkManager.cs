using CarParking.Classes;
using CarParking.Interfaces;
using System;
using System.Globalization;

namespace CarParking
{
    class ParkManager
    {
        private string greeting;
        private string menuItems;

        private Parking carParking;
        public ParkManager()
        {
            greeting = "\t\tWelcome to our car park!";
            menuItems = "Choose an action that you'd like to do and \n press the necessary key button:\n\n Press \"A\" - PARK YOUR CAR\n Press \"B\" - REMOVE YOUR CAR\n Press \"C\" - REPLENISH YOUR BALANCE\n Press \"D\" - SHOW TRANSACTIONS FOR LAST MINUTES\n Press \"E\" - SHOW INCOME\n Press \"F\" - SHOW FREE PLACES\n Press \"G\" - SHOW LOG\n Press \"H\" - SHOW ALL CARS\n Press \"Esc\" - EXIT";

            carParking = Parking.Instance;

            carParking.AddCar(new Car(CarType.BUS, 1234, 1.0));
            carParking.AddCar(new Car(CarType.MOTOCYCLE, 1326, 1245));
            carParking.AddCar(new Car(CarType.PASSANGER, 1356, 1220));
            carParking.AddCar(new Car(CarType.TRUCK, 5633, 1220));
        }
        public void ShowMenu()
        {
            do
            {
                Console.Clear();
                Console.WriteLine(greeting);
                Console.WriteLine(menuItems);
                ConsoleKey pressedKey = Console.ReadKey().Key;

                switch (pressedKey)
                {
                    case ConsoleKey.A:
                        Console.Clear();
                        ShowAddMenu();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.B:
                        Console.Clear();
                        RemoveCar();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        ReplenishBalance();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.D:
                        Console.Clear();
                        ShowTransactions();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        ShowIncome();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.Escape:
                        return;
                    case ConsoleKey.F:
                        Console.Clear();
                        ShowFreePlaces();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.G:
                        Console.Clear();
                        ShowLog();
                        Console.ReadKey();
                        break;
                    case ConsoleKey.H:
                        ShowAllCars();
                        Console.ReadKey();
                        break;
                }
            } while (true);
        }

        private void ShowFreePlaces()
        {
            int numberOfPlaces = carParking.ShowFreePlaces();
            int engagedPlaces = carParking.Cars.Count;
            Console.WriteLine("\n\t We have {0} free places and {1} engaged places", numberOfPlaces, engagedPlaces);
        }

        private void ShowIncome()
        {
            string message = String.Empty;
            message = carParking.ShowIncome();
            Console.WriteLine(message);
        }

        private void ShowTransactions()
        {
            string message = String.Empty;
            message = carParking.ShowTransactionsFor();
            Console.WriteLine(message);
        }

        private void ShowAllCars()
        {
            if (carParking.Cars != null && carParking.Cars.Count > 0)
            {
                Console.Clear();
                Console.WriteLine(String.Format("{0,12}  {1,-12} {2,-50}", "Car Id", "Car type", "Balance"));
                foreach (ICar car in carParking.Cars)
                {
                    Console.WriteLine(String.Format(new CultureInfo("en-US"), "{0,12}  {1,-12} {2,-50:C2}", car.CarId, car.CarType.ToString(), car.CarBalance));
                }
            }
        }

        private void ShowAddMenu()
        {
            if (carParking.ShowFreePlaces() > 0)
            {
                int id;
                id = EnterID(true);

                do
                {
                    Console.Clear();
                    Console.WriteLine("Choose the type of your car:\n\n\n Press \"T\" - FOR TRUCK\n Press \"B\" - FOR BUS\n Press \"M\" - FOR MOTOCYCLE\n Press \"P\" - PASSENGER");
                    ConsoleKey pressedKey = Console.ReadKey().Key;
                    Car newCar;
                    switch (pressedKey)
                    {
                        case ConsoleKey.T:
                            newCar = MakeCar(CarType.TRUCK, id);
                            if (newCar != null)
                            {
                                carParking.AddCar(newCar);
                                Console.WriteLine("Your car was parked successfully!");
                                return;
                            }
                            else
                            {
                                break;
                            }

                        case ConsoleKey.B:
                            newCar = MakeCar(CarType.BUS, id);
                            if (newCar != null)
                            {
                                carParking.AddCar(newCar);
                                Console.WriteLine("Your car was parked successfully!");
                                return;
                            }
                            else
                            {
                                break;
                            }
                        case ConsoleKey.M:
                            newCar = MakeCar(CarType.MOTOCYCLE, id);
                            if (newCar != null)
                            {
                                carParking.AddCar(newCar);
                                Console.WriteLine("Your car was parked successfully!");
                                return;
                            }
                            else
                            {
                                break;
                            }
                        case ConsoleKey.P:
                            newCar = MakeCar(CarType.PASSANGER, id);
                            if (newCar != null)
                            {
                                carParking.AddCar(newCar);
                                Console.WriteLine("Your car was parked successfully!");
                                return;
                            }
                            else
                            {
                                break;
                            }
                    }


                } while (true);

            }
            else
            {
                Console.Clear();
                Console.WriteLine("We're sorry, but there isn't any free parking place now :(");
            }


        }

        private Car MakeCar(CarType carType, int id)
        {
            Car resultCar = new Car(carType, id);
            if (resultCar != null)
            {
                double amount = 0.0;
                bool result = false;
                string line = String.Empty;
                Console.Clear();
                Console.Write("Now you need to replenish your car balance.\n");
                do
                {
                    Console.Write("Enter amount of money > ");
                    line = Console.ReadLine();
                    if (!line.Contains("") && !line.Contains(""))
                        String.Concat(line, ".0");
                    result = Double.TryParse(line, NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
                } while (String.IsNullOrEmpty(line) || !result || amount <= 0);
                resultCar.AddToBalance(amount);
                Console.WriteLine("Your balance was replenished successfully.");
            }
            return resultCar;


        }

        private bool ReplenishBalance()
        {
            int id = EnterID(false);
            double amount = 0.0;
            bool result = false;
            string line = String.Empty;
            ICar currentCar = carParking.Cars.Find(c => c.CarId == id);
            if (currentCar != null)
            {
                do
                {
                    Console.Write("Enter amount of money > ");
                    line = Console.ReadLine();

                    if (!line.Contains(".") && !line.Contains(","))
                        line = String.Concat(line, ".0");
                    result = Double.TryParse(line, NumberStyles.Number, CultureInfo.InvariantCulture, out amount);
                } while (String.IsNullOrEmpty(line) || !result || amount <= 0);

                currentCar.AddToBalance(amount);
                Console.WriteLine("Your balance was replenished successfully.");
                return true;
            }
            else
            {
                Console.WriteLine("There is no such car");
                return false;
            }

        }

        private int EnterID(bool isNewId)
        {
            string line = String.Empty;
            int result = 0;
            if (isNewId)
            {
                do
                {
                    Console.Clear();
                    if (result != 0)
                    {
                        Console.WriteLine("Check your id (we have a car with such id)");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }

                    do
                    {
                        Console.Write("\n\tTo add your car, enter its ID {4 number} > ");
                        line = Console.ReadLine();

                    } while (String.IsNullOrEmpty(line) || line.Length != 4 || !Int32.TryParse(line, out result));
                } while (carParking.HasCar(result));
            }
            else
            {
                do
                {
                    Console.Clear();
                    if (result != 0)
                    {
                        Console.WriteLine("Check your id (we haven't a car with such id)");
                        Console.WriteLine("Press any key to continue.");
                        Console.ReadKey();
                    }

                    do
                    {
                        Console.Clear();
                        Console.Write("\n\tEnter your car ID {4 number} > ");
                        line = Console.ReadLine();

                    } while (String.IsNullOrEmpty(line) || line.Length != 4 || !Int32.TryParse(line, out result));
                } while (!carParking.HasCar(result));
            }

            return result;
        }

        private void ShowLog()
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t\ttransactions.log\n");
            Console.ResetColor();
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
                    output += String.Format("{0}\n", log[index]);
                }

                Console.WriteLine(output);
            }

        }

        private void RemoveCar()
        {
            int id = EnterID(false);

            if (carParking.RemoveCar(id))
            {
                Console.WriteLine("The car was removed.");
            }
            else
            {
                ICar currentCar = carParking.Cars.Find(c => c.CarId == id);
                if (currentCar != null)
                {
                    Console.WriteLine(String.Format(new CultureInfo("en-US"), "The car wasn't removed. You need to replenish your car balance. Your debt: {0:C2}.  You must pay not less than that!", currentCar.CarBalance));
                }
                else
                {
                    Console.WriteLine("Your car disappeared!");
                }
            }

        }

    }
}
