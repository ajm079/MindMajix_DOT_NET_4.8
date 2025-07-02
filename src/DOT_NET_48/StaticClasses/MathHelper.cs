using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClasses
{
	public static class MathHelper
	{
		// Static field
		public static double Pi = 3.14159;

		// Static method
		public static double Square(double number)
		{
			return number * number;
		}

		public static double CircleArea(double radius)
		{
			return Pi * Square(radius);
		}

		// Static constructor
		static MathHelper()
		{
			Console.WriteLine("Static constructor called. MathHelper is ready!");
		}
	}
}
