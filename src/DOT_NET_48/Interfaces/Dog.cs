using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	// Implement the interface in a class
	public class Dog : IAnimal
	{
		public void Speak()
		{
			Console.WriteLine("The dog barks: Woof! Woof!");
		}

		public void Eat(string food)
		{
			Console.WriteLine("The dog eats: " + food);
		}
	}
}
