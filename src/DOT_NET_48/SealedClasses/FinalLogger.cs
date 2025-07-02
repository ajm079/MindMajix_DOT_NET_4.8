using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
	// Sealed Class
	public sealed class FinalLogger
	{
		public void Log(string message)
		{
			Console.WriteLine("Log: " + message);
		}
	}
}
