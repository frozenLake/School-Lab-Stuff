using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			var conditionResult = 0;
			Console.WriteLine("The 'If' Statement");
			Console.WriteLine("```````````````````");

			Console.Write("Enter 1st number: ");
			int numA = Convert.ToInt32(Console.ReadLine());

			Console.Write("Enter 2nd number: ");
			int numB = Convert.ToInt32(Console.ReadLine());

			if (numA > numB) {
				conditionResult = 1;
			}
			else if (numA < numB) {
				conditionResult = 2;
			}
			else if (numA == numB){
				conditionResult = 3;
			}
			Console.WriteLine();

			if (conditionResult == 1) {
				Console.WriteLine("1st number is greater than 2nd number.");
				Console.WriteLine(numA + " is greater than " + numB + ".");
			}
			else if(conditionResult == 2) {
				Console.WriteLine("1st number is less than 2nd number.");
				Console.WriteLine(numA + " is less than " + numB + ".");
			}
			else if(conditionResult == 3) {
				Console.WriteLine("1st number is equal to 2nd number.");
				Console.WriteLine(numA + " and" + numB + "are equal.");
			}
			else {
				Console.WriteLine("WHAT DID YOU DO. YOU BROKE MATH.");
			}

			Console.WriteLine("\n.....Thank you!.....");
		}
	}
}