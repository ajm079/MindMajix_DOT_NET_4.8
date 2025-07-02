using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	public class StringRepository : IRepository<string>
	{
		public void Add(string item)
		{
			Console.WriteLine("Added string: " + item);
		}
	}
}
