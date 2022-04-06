using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int myNum = 10;
			Console.WriteLine("Initial value of myNum - " + myNum);

			Console.WriteLine("Using Addition Assignment operator to add 5 to myNum...");
			myNum += 5;

			Console.WriteLine("Updated Value of myNum = " + myNum);

		}
	}
}