using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
	internal class Program
	{
		// Basic enum
		enum Day
		{
			Sunday,
			Monday,
			Tuesday,
			Wednesday,
			Thursday,
			Friday,
			Saturday
		}

		// Enum with explicit values
		enum StatusCode
		{
			OK = 200,
			NotFound = 404,
			InternalServerError = 500
		}

		// Enum with Flags for bitwise operations
		[Flags]
		enum FileAccess
		{
			None = 0,
			Read = 1,
			Write = 2,
			Execute = 4
		}

		static void Main(string[] args)
		{
			// 1Basic enum usage
			Day today = Day.Wednesday;
			Console.WriteLine($"Today is: {today}");

			// Enum with explicit values
			StatusCode code = StatusCode.NotFound;
			Console.WriteLine($"Status code: {(int)code} - {code}");

			// Casting enum to int
			int codeValue = (int)StatusCode.OK;
			Console.WriteLine($"OK as int: {codeValue}");

			// Casting int to enum
			StatusCode parsedCode = (StatusCode)500;
			Console.WriteLine($"Parsed code: {parsedCode}");

			// Enum in switch statement
			switch (today)
			{
				case Day.Saturday:
				case Day.Sunday:
					Console.WriteLine("Weekend!");
					break;
				default:
					Console.WriteLine("Weekday!");
					break;
			}

			// Using Flags
			FileAccess myAccess = FileAccess.Read | FileAccess.Write;
			Console.WriteLine($"My access: {myAccess}");

			// Check if Write permission is included
			bool canWrite = myAccess.HasFlag(FileAccess.Write);
			Console.WriteLine($"Can write: {canWrite}");

			// Iterate over enum values
			Console.WriteLine("Days of the week:");
			foreach (Day day in Enum.GetValues(typeof(Day)))
			{
				Console.WriteLine(day);
			}

			// Parse enum from string
			string input = "Friday";
			if (Enum.TryParse(input, out Day inputDay))
			{
				Console.WriteLine($"Parsed day: {inputDay}");
			}

			// Check if value is defined
			bool isDefined = Enum.IsDefined(typeof(StatusCode), 404);
			Console.WriteLine($"Is 404 defined in StatusCode? {isDefined}");
		}
	}
}
