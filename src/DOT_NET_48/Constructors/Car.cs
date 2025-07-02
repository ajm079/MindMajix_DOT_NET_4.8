using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	public class Car
	{
		// Fields
		public string Make { get; set; }
		public string Model { get; set; }
		public int Year { get; set; }

		// Default constructor
		public Car()
		{
			Make = "Unknown";
			Model = "Unknown";
			Year = 2000;
			Console.WriteLine("Default constructor called.");
		}

		// Parameterized constructor
		public Car(string make, string model)
		{
			Make = make;
			Model = model;
			Year = 2024;
			Console.WriteLine("Parameterized constructor (2 params) called.");
		}

		// Constructor overloading + 5️⃣ constructor chaining
		public Car(string make, string model, int year) : this(make, model)
		{
			Year = year;
			Console.WriteLine("Parameterized constructor (3 params) called (chained).");
		}

		// Static constructor
		static Car()
		{
			Console.WriteLine("Static constructor called. Runs only once.");
		}
	}
}
