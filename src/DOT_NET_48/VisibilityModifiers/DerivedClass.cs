using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilityModifiers
{
	public class DerivedClass : BaseClass
	{
		public void ShowAccessInDerived()
		{
			Console.WriteLine($"Inside DerivedClass:");
			Console.WriteLine(PublicField);
			// Console.WriteLine(PrivateField); // Not accessible
			Console.WriteLine(ProtectedField); // Accessible
			Console.WriteLine(InternalField);  // Accessible (same assembly)
			Console.WriteLine(ProtectedInternalField); // Accessible
			Console.WriteLine(PrivateProtectedField);  // Accessible (same assembly + derived)
		}
	}
}
