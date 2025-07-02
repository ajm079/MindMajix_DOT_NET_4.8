using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BaseClass baseObj = new BaseClass();
			baseObj.Show();  // BaseClass Show()

			DerivedClass derivedObj = new DerivedClass();
			derivedObj.Show();  // DerivedClass Show()

			// Base reference to derived object — runtime polymorphism!
			BaseClass polyObj = new DerivedClass();
			polyObj.Show();  // DerivedClass Show()
		}
	}
}
