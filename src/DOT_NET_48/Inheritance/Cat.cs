using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	// Sealed class - no further inheritance allowed
	sealed class Cat : Animal
	{
		public Cat(string name) : base(name) { }

		public override void Speak()
		{
			Console.WriteLine($"{Name} meows.");
		}
	}
}
