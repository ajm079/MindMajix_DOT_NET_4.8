using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethods
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BaseClass baseObj = new BaseClass();
			baseObj.Show(); // BaseClass Show()

			DerivedClass derivedObj = new DerivedClass();
			derivedObj.Show(); // DerivedClass Show()

			// Base class reference to derived object
			BaseClass polyObj = new DerivedClass();
			polyObj.Show(); // BaseClass Show() — NOT polymorphic, calls base version!
		}
	}
}
