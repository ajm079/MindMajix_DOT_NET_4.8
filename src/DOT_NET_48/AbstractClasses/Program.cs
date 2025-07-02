using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{// Animal myAnimal = new Animal("Generic"); // Error! Cannot create instance of abstract class

			Dog dog = new Dog("Buddy");
			dog.Speak(); // Buddy says: Woof!
			dog.Eat();   // Buddy is eating.

			Cat cat = new Cat("Whiskers");
			cat.Speak(); // Whiskers says: Meow!
			cat.Eat();   // Whiskers is eating.

			// Polymorphism with abstract class reference
			Animal pet = new Dog("Charlie");
			pet.Speak(); // Charlie says: Woof!
			pet.Eat();   // Charlie is eating.
		}
	}
}
