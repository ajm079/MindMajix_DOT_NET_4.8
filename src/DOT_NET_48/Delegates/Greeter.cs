using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	public class Greeter
	{
		public void SayHello(string name)
		{
			Console.WriteLine("Hello, " + name + "!");
		}

		public void SayGoodbye(string name)
		{
			Console.WriteLine("Goodbye, " + name + "!");
		}
	}
}
