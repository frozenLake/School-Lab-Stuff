using System;

namespace ConsoleApp2
{
	class whileLoop1
	{
		public void tryWhileLoop()
		{
			Console.WriteLine("WHILE LOOP");
			Console.WriteLine("`````````````");
			Console.WriteLine("INPUT:");
			Console.Write("Enter a number to start: ");
			int start = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a number to end: ");
			int end = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("``````````````````````````````````````````");
			Console.WriteLine("OUTPUT:");
			while (start <= end)
			{
				Console.WriteLine("WHILE LOOP BLOCK STARTS with value: " + start);
				start++;
				Console.WriteLine("value after increment: " + start);
				Console.WriteLine("..WHILE LOOP ENDS");
				Console.WriteLine();
			}

			Console.WriteLine("``````````````````````````````````````````");
			Console.WriteLine("***ThankYou***");
		}
	}
}
