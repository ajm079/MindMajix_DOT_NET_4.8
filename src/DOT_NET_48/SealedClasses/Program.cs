using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClasses
{
	
	/*
    // This will cause a compile-time error:
    class CustomLogger : FinalLogger
    {
    }
    */

	internal class Program
	{
		static void Main(string[] args)
		{
			FinalLogger logger = new FinalLogger();
			logger.Log("This is a sealed class example.");

			Console.ReadLine(); // Keeps console window open
		}
	}
}
