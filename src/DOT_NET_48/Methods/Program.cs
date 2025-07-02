using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods
{
	internal class Program
	{
			// Method with no parameters and no return value
			static void SayHello()
			{
				Console.WriteLine("Hello, World!");
			}

			// Method with a parameter and no return value
			static void Greet(string name)
			{
				Console.WriteLine("Hello, " + name + "!");
			}

			// Method with parameters and a return value
			static int Add(int a, int b)
			{
				return a + b;
			}

			public static void Main(string[] args)
			{
				// Calling SayHello
				SayHello();

				// Calling Greet
				Greet("Rahbar");

				// Calling Add
				int sum = Add(5, 7);
				Console.WriteLine("Sum: " + sum);

				// Using instance method Multiply
				Calculator calc = new Calculator();
				int product = calc.Multiply(3, 4);
				Console.WriteLine("Product: " + product);

				// Using static method Subtract
				int difference = Calculator.Subtract(10, 3);
				Console.WriteLine("Difference: " + difference);

				Console.ReadLine(); // Keeps the console window open
			}
		}
	}

