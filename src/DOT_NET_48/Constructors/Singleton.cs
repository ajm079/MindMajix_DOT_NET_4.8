using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
	// Private constructor example (Singleton)
	public class Singleton
	{
		private static Singleton _instance;

		public string Data { get; set; }

		// Private constructor prevents outside instantiation
		private Singleton()
		{
			Data = "Hello Singleton";
		}

		public static Singleton GetInstance()
		{
			if (_instance == null)
				_instance = new Singleton();
			return _instance;
		}
	}
}
