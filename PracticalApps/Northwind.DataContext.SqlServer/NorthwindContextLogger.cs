using System;
using System.Diagnostics;

namespace Northwind.DataContext.SqlServer
{
    public static class NorthwindContextLogger
    {
        public static void WriteLine(string message)
        {
            Debug.WriteLine(message);
            Console.WriteLine(message);
        }
    }
}
