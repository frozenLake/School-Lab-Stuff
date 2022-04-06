using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("INPUT");

			Console.Write("Enter first number: ");
			int num1 = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter second number: ");
			int num2 = Convert.ToInt32(Console.ReadLine());

			int result = num1 % num2;

			Console.WriteLine("\nOUTPUT");
			Console.WriteLine(num1 + " modulus of " + num2 + " is " + result);
		}
	}
}