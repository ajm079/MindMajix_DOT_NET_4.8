using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
	internal class Program
	{
		static void Main(string[] args)
		{
			IAnimal myDog = new Dog();
			myDog.Speak();
			myDog.Eat("bone");

			IAnimal myCat = new Cat();
			myCat.Speak();
			myCat.Eat("fish");

			Console.ReadLine(); // Keeps console window open
		}
	}
}
