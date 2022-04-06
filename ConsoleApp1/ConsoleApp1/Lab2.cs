using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter the number to test = ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the number you want to multiply " + numA + " with: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nUsing Multiplication Assignment operator...");
			Console.WriteLine("Updated Value of your test number = " + (numA *= numB));
		}
	}
}