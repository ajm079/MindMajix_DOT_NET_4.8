using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisibilityModifiers
{
	public class BaseClass
	{
		public string PublicField = "Public Field";
		private string PrivateField = "Private Field";
		protected string ProtectedField = "Protected Field";
		internal string InternalField = "Internal Field";
		protected internal string ProtectedInternalField = "Protected Internal Field";
		private protected string PrivateProtectedField = "Private Protected Field";

		public void ShowAccess()
		{
			Console.WriteLine($"Inside BaseClass:");
			Console.WriteLine(PublicField);
			Console.WriteLine(PrivateField);
			Console.WriteLine(ProtectedField);
			Console.WriteLine(InternalField);
			Console.WriteLine(ProtectedInternalField);
			Console.WriteLine(PrivateProtectedField);
		}
	}
}
