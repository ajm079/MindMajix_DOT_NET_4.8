using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Create a base class instance
			Animal genericAnimal = new Animal("Generic Animal");
			genericAnimal.Speak();
			Console.WriteLine();

			// Create a derived class instance
			Dog dog = new Dog("Buddy", "Golden Retriever");
			dog.Speak();
			Console.WriteLine();

			// Create a sealed class instance
			Cat cat = new Cat("Whiskers");
			cat.Speak();
			Console.WriteLine();

			// 6️⃣ Polymorphism: base class reference to derived class
			Animal polyDog = new Dog("Charlie", "Beagle");
			polyDog.Speak();  // Calls Dog's Speak() due to override
		}
	}
}
