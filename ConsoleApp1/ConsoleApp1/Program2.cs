using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int englishScore_I = 34;
			int frenchScore_I = 28;

			double englishScore_D = englishScore_I;
			double frenchScore_D = frenchScore_I;

			Console.WriteLine("IMPLICIT CONVERSION\n```````````````````");
			Console.WriteLine("INTEGER TYPE VALUES: ");
			Console.WriteLine("English Score: " + englishScore_I);
			Console.WriteLine(" French Score: " + frenchScore_I);
			Console.WriteLine();
			Console.WriteLine("DOUBLE TYPE VALUES: ");
			Console.WriteLine("English Score: " + englishScore_D);
			Console.WriteLine(" French Score: " + frenchScore_D);
			Console.WriteLine("\n#####################\n");

			double mathsScore_D = 8.2;
			double scienceScore_D = 7.6;

			int mathsScore_I = Convert.ToInt32(mathsScore_D);
			int scienceScore_I = Convert.ToInt32(scienceScore_D);

			Console.WriteLine("IMPLICIT CONVERSION\n```````````````````");
			Console.WriteLine("DOUBLE TYPE VALUES: ");
			Console.WriteLine("  Maths Score: " + mathsScore_D);
			Console.WriteLine("Science Score: " + scienceScore_D);
			Console.WriteLine();
			Console.WriteLine("INTEGER TYPE VALUES: ");
			Console.WriteLine("  Maths Score: " + mathsScore_I);
			Console.WriteLine("Science Score: " + scienceScore_I);
			Console.WriteLine();
		}
	}
}