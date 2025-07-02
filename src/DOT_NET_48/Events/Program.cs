using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Event example
			Publisher pub = new Publisher();
			Subscriber sub = new Subscriber();

			// Subscribe to event
			pub.OnNotify += sub.HandleNotification;

			pub.Publish("Hello Event!");

			Console.WriteLine();

			// Action example - built-in delegate for void return type
			Action<string> greet = name => Console.WriteLine("Hello, " + name + "!");
			greet("Rahbar");

			Console.WriteLine();

			// Func example - built-in delegate with return type
			Func<int, int, int> add = (a, b) => a + b;
			int sum = add(10, 20);
			Console.WriteLine("Sum using Func: " + sum);

			Console.WriteLine();

			// Predicate example - built-in delegate returning bool
			Predicate<int> isEven = num => num % 2 == 0;
			Console.WriteLine("Is 4 even? " + isEven(4));
			Console.WriteLine("Is 5 even? " + isEven(5));

			Console.ReadLine(); // Keeps console window open
		}
	}
}
