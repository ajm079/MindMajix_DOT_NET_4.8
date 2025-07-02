using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
	// Generic Class
	public class Box<T>
	{
		private T content;

		public void Pack(T item)
		{
			content = item;
			Console.WriteLine("Packed: " + content);
		}

		public T Unpack()
		{
			Console.WriteLine("Unpacked: " + content);
			return content;
		}
	}
}
