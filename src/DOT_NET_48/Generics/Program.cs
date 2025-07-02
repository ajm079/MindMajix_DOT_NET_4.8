using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Using Generic Class with int
			Box<int> intBox = new Box<int>();
			intBox.Pack(123);
			intBox.Unpack();

			// Using Generic Class with string
			Box<string> strBox = new Box<string>();
			strBox.Pack("Rahbar");
			strBox.Unpack();

			// Using Generic Method
			Utilities util = new Utilities();
			util.Show<int>(42);
			util.Show<string>("Hello Generics!");

			// Using Generic Interface
			IRepository<string> repo = new StringRepository();
			repo.Add("Hello Repo!");

			Console.ReadLine(); // Keeps console window open
		}
	}
}
