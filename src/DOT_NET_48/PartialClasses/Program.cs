using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Person p = new Person
			{
				FirstName = "Rahbar",
				LastName = "Ahmed",
				Age = 30
			};

			p.ShowFullName();
			p.ShowAge();
		}
	}
}
