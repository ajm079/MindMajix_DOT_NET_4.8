using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	// Derived class with override
	class Dog : Animal
	{
		public string Breed { get; set; }

		// Call base constructor using : base()
		public Dog(string name, string breed) : base(name)
		{
			Breed = breed;
		}

		// Override Speak()
		public override void Speak()
		{
			base.Speak(); // Call base class method
			Console.WriteLine($"{Name} barks. Breed: {Breed}");
		}
	}
}
