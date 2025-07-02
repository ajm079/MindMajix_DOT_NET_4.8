using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Declaring and initializing an array
			int[] numbers = { 10, 20, 30, 40, 50 };
			Console.WriteLine("Original array:");
			PrintArray(numbers);

			// Accessing elements by index
			Console.WriteLine($"First element: {numbers[0]}");
			Console.WriteLine($"Last element: {numbers[numbers.Length - 1]}");

			// Iterating with for and foreach
			Console.WriteLine("Iterating with for:");
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine(numbers[i]);
			}

			Console.WriteLine("Iterating with foreach:");
			foreach (int num in numbers)
			{
				Console.WriteLine(num);
			}

			// Modifying array elements
			numbers[0] = 100;
			Console.WriteLine("After modifying first element:");
			PrintArray(numbers);

			// Multi-dimensional array
			int[,] matrix = {
				{ 1, 2, 3 },
				{ 4, 5, 6 }
			};
			Console.WriteLine("Multi-dimensional array:");
			for (int i = 0; i < matrix.GetLength(0); i++)
			{
				for (int j = 0; j < matrix.GetLength(1); j++)
				{
					Console.Write(matrix[i, j] + " ");
				}
				Console.WriteLine();
			}

			// Jagged array
			int[][] jagged = new int[2][];
			jagged[0] = new int[] { 1, 2 };
			jagged[1] = new int[] { 3, 4, 5 };
			Console.WriteLine("Jagged array:");
			for (int i = 0; i < jagged.Length; i++)
			{
				for (int j = 0; j < jagged[i].Length; j++)
				{
					Console.Write(jagged[i][j] + " ");
				}
				Console.WriteLine();
			}

			// Using Array methods
			Array.Sort(numbers);
			Console.WriteLine("Sorted array:");
			PrintArray(numbers);

			Array.Reverse(numbers);
			Console.WriteLine("Reversed array:");
			PrintArray(numbers);

			int index = Array.IndexOf(numbers, 40);
			Console.WriteLine($"Index of 40: {index}");

			// Copying arrays
			int[] copy = new int[numbers.Length];
			Array.Copy(numbers, copy, numbers.Length);
			Console.WriteLine("Copied array:");
			PrintArray(copy);

			// Passing arrays to methods
			int sum = SumArray(numbers);
			Console.WriteLine($"Sum of elements: {sum}");

			// Returning an array from a method
			int[] generated = GenerateArray(5);
			Console.WriteLine("Generated array:");
			PrintArray(generated);
		}

		static void PrintArray(int[] arr)
		{
			foreach (int num in arr)
			{
				Console.Write(num + " ");
			}
			Console.WriteLine();
		}

		static int SumArray(int[] arr)
		{
			int sum = 0;
			foreach (int num in arr)
			{
				sum += num;
			}
			return sum;
		}

		static int[] GenerateArray(int size)
		{
			int[] result = new int[size];
			for (int i = 0; i < size; i++)
			{
				result[i] = i * 10;
			}
			return result;
		}
	}
}
