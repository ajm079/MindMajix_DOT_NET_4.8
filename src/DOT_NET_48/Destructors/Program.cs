using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
	internal class Program
	{
		static void Main(string[] args)
		{
			CreateAndRelease();

			Console.WriteLine("Forcing garbage collection...");
			GC.Collect();
			GC.WaitForPendingFinalizers();

			Console.WriteLine("End of Main.");
		}

		static void CreateAndRelease()
		{
			ResourceHolder holder = new ResourceHolder("MyFile.txt");
			// The object goes out of scope when this method ends.
		}
	}
}
