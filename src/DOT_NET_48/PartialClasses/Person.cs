using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartialClasses
{
	public partial class Person
	{
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public void ShowFullName()
		{
			Console.WriteLine($"Full Name: {FirstName} {LastName}");
		}
	}
	public partial class Person
	{
		public int Age { get; set; }

		public void ShowAge()
		{
			Console.WriteLine($"Age: {Age}");
		}
	}
}
