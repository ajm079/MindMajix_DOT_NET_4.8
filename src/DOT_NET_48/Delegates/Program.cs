using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
	internal class Program
	{ 
		// Declare a delegate type
		delegate void GreetDelegate(string name);

		static void Main(string[] args)
		{
			Greeter greeter = new Greeter();

			// Create a delegate instance pointing to SayHello
			GreetDelegate greet = greeter.SayHello;
			greet("Rahbar");

			// Reassign to SayGoodbye
			greet = greeter.SayGoodbye;
			greet("Rahbar");

			// Multicast Delegate: Combine multiple methods
			GreetDelegate multiGreet = greeter.SayHello;
			multiGreet += greeter.SayGoodbye;

			Console.WriteLine("Calling multicast delegate:");
			multiGreet("Rahbar");

			Console.ReadLine(); // Keeps console window open
		}
	}
}
