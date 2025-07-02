using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destructors
{
	public class ResourceHolder
	{
		public string ResourceName { get; set; }

		public ResourceHolder(string name)
		{
			ResourceName = name;
			Console.WriteLine($"Constructor: Acquired resource {ResourceName}");
		}

		// Destructor
		~ResourceHolder()
		{
			Console.WriteLine($"Destructor: Releasing resource {ResourceName}");
		}
	}
}
