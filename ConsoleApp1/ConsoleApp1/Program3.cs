using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.Write("Enter your name: ");
			String name = Console.ReadLine();

			Console.WriteLine("\n*************************");
			Console.WriteLine("Hey " + name + ", Good Morning!");
			Console.WriteLine("*************************\n");
		}
	}
}