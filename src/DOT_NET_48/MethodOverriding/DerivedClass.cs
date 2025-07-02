using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverriding
{
	public class DerivedClass : BaseClass
	{
		public override void Show()
		{
			Console.WriteLine("DerivedClass Show()");
		}
	}
}
