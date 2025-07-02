using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	// Base class
	public class Animal
	{
		public string Name { get; set; }

		public Animal(string name)
		{
			Name = name;
		}

		public virtual void Speak()
		{
			Console.WriteLine($"{Name} makes a sound.");
		}
	}
}
