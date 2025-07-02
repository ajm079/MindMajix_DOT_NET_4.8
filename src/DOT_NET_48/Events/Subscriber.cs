using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	// Subscriber class
	public class Subscriber
	{
		public void HandleNotification(string message)
		{
			Console.WriteLine("Subscriber received: " + message);
		}
	}
}
