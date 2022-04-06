using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("The 'If' Statement");
			Console.WriteLine("```````````````````");

			Console.Write("Enter 1st number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter 2nd number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			Boolean conditionResult = numA > numB;
			Console.WriteLine("\nCondition Result = " + conditionResult);
			Console.WriteLine();

			if (conditionResult == true) {
				Console.WriteLine("1st number is greater than 2nd number.");
				Console.WriteLine(numA + " is greater than " + numB + ".");
			}
			else {
				Console.WriteLine("1st number is not greater than 2nd number.");
				Console.WriteLine(numA + " is not greater than " + numB + ".");
			}

			Console.WriteLine("\n.....Thank you!.....");
		}
	}
}