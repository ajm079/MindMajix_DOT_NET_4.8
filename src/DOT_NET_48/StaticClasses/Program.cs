using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine($"Value of Pi: {MathHelper.Pi}");

			double radius = 5;
			double area = MathHelper.CircleArea(radius);

			Console.WriteLine($"Circle area with radius {radius}: {area}");

			double number = 4;
			double squared = MathHelper.Square(number);
			Console.WriteLine($"{number} squared: {squared}");

			// Try to create an instance (uncomment to see compiler error)
			// MathHelper helper = new MathHelper(); // Not allowed
		}
	}
}
