using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
	// Abstract base class
	public abstract class Animal
	{
		public string Name { get; set; }

		public Animal(string name)
		{
			Name = name;
		}

		// Abstract method — must be implemented by derived classes
		public abstract void Speak();

		// Normal method — can be used as is
		public void Eat()
		{
			Console.WriteLine($"{Name} is eating.");
		}
	}
}
