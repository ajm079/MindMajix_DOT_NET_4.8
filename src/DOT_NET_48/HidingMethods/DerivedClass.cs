using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HidingMethods
{
	public class DerivedClass : BaseClass
	{
		// Hides BaseClass.Show() — not overriding
		public new void Show()
		{
			Console.WriteLine("DerivedClass Show()");
		}
	}
}
