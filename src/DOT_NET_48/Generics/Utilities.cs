using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	// Generic Method
	public class Utilities
	{
		public void Show<T>(T item)
		{
			Console.WriteLine("Showing: " + item);
		}
	}
}
