using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	// Another class implementing same interface
	public class Cat : IAnimal
	{
		public void Speak()
		{
			Console.WriteLine("The cat meows: Meow! Meow!");
		}

		public void Eat(string food)
		{
			Console.WriteLine("The cat eats: " + food);
		}
	}

}
