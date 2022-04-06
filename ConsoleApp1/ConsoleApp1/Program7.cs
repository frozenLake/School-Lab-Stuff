using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("INCREMENT AND DECREMENT OPERATIONS");
			Console.WriteLine("````````````````````````````````````\nINPUT");

			Console.Write("Enter the number for increment operation: ");
			int incrNum = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter the number for decrement operation: ");
			int decrNum = Convert.ToInt32(Console.ReadLine());

			Console.WriteLine("\nOUTPUT");
			Console.WriteLine(incrNum + " increment = " + ++incrNum);
			Console.WriteLine(decrNum + " decrement = " + --decrNum);
		}
	}
}