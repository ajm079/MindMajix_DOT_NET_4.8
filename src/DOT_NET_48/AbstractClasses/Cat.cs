using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
	// Another derived class
	public class Cat : Animal
	{
		public Cat(string name) : base(name) { }

		public override void Speak()
		{
			Console.WriteLine($"{Name} says: Meow!");
		}
	}
}
