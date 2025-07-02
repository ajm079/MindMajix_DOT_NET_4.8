using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
	// Declare a delegate for the event
	public delegate void NotifyHandler(string message);

	// Publisher class
	public class Publisher
	{
		// Declare an event using the delegate
		public event NotifyHandler OnNotify;

		public void Publish(string message)
		{
			Console.WriteLine("Publishing message: " + message);

			// Raise the event
			OnNotify?.Invoke(message);
		}
	}
}
