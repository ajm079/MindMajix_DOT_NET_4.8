using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Calls static constructor automatically once before any instance is created
			Car car1 = new Car();
			Console.WriteLine($"{car1.Make} {car1.Model} {car1.Year}");
			Console.WriteLine();

			Car car2 = new Car("Toyota", "Corolla");
			Console.WriteLine($"{car2.Make} {car2.Model} {car2.Year}");
			Console.WriteLine();

			Car car3 = new Car("Ford", "Mustang", 2022);
			Console.WriteLine($"{car3.Make} {car3.Model} {car3.Year}");
			Console.WriteLine();

			// Singleton usage
			Singleton s1 = Singleton.GetInstance();
			Singleton s2 = Singleton.GetInstance();
			Console.WriteLine($"Singleton Data: {s1.Data}");

			s2.Data = "Changed!";
			Console.WriteLine($"Are s1 and s2 same instance? {object.ReferenceEquals(s1, s2)}");
			Console.WriteLine($"Singleton Data after change: {s1.Data}");
		}
	}
}
