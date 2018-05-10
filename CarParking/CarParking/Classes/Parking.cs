using CarParking.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;

namespace CarParking.Classes
{
	class Parking : IPark
	{
		private static readonly Lazy<Parking> instance = new Lazy<Parking>(() => new Parking());
		private Parking()
		{
			Settings.SetSettings(this);
		}
		public static Parking Instance { get { return instance.Value; } }


		#region IPark Members

		public int TimeOut
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public Dictionary<CarType, double> Prices
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public float Fine
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public int ParkingSpace
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<ICar> Cars
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		public List<ITransaction> Transactions
		{
			get
			{
				throw new NotImplementedException();
			}
			set
			{
				throw new NotImplementedException();
			}
		}

		private void WriteToLog(string message)
		{
			string folderpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
			string filepath = Path.Combine(folderpath, "Transactions.log");

			if (File.Exists(filepath))
			{
				using (StreamWriter outputFile = new StreamWriter(filepath, true))
				{
					outputFile.WriteLine(message);
				}
			}
			else
			{
				using (StreamWriter outputFile = new StreamWriter(filepath))
				{
					outputFile.WriteLine(message);
				}
			}


		}

		public bool AddCar(ICar car)
		{
			throw new NotImplementedException();
		}

		public bool RemoveCar(ICar car)
		{
			throw new NotImplementedException();
		}

		public bool AddToBalance(ICar car, double amount)
		{
			throw new NotImplementedException();
		}

		public string ShowTransactionsFor(int minute = 1)
		{
			throw new NotImplementedException();
		}

		public string ShowIncome()
		{
			throw new NotImplementedException();
		}

		public string ShowFreePlaces()
		{
			throw new NotImplementedException();
		}

		public string ShowLog()
		{
			throw new NotImplementedException();
		}

		#endregion
	}
}
