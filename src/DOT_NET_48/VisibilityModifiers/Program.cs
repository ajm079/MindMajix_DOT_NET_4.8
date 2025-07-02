using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilityModifiers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			BaseClass b = new BaseClass();
			Console.WriteLine("From Program:");
			Console.WriteLine(b.PublicField);    
			// Console.WriteLine(b.PrivateField); 
			// Console.WriteLine(b.ProtectedField); 
			Console.WriteLine(b.InternalField);  // (same assembly)
			Console.WriteLine(b.ProtectedInternalField); 
			// Console.WriteLine(b.PrivateProtectedField); 

			Console.WriteLine();

			b.ShowAccess();
			Console.WriteLine();

			DerivedClass d = new DerivedClass();
			d.ShowAccessInDerived();
		}
	}
}
