using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class doWhileLoop1
	{
		public void tryDoWhileLoop()
		{
			Console.WriteLine("DO..WHILE LOOP");
			Console.WriteLine("````````````````");
			Console.WriteLine("INPUT:");
			Console.Write("Enter a number to start: ");
			int start = Convert.ToInt32(Console.ReadLine());
			Console.Write("Enter a number to end: ");
			int end = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("``````````````````````````````````````````");
			Console.WriteLine("OUTPUT:");
			do
			{
				Console.WriteLine("DO-WHILE LOOP BLOCK STARTS with value: " + start);
				start++;
				Console.WriteLine("value after increment: " + start);
				Console.WriteLine("..DO-WHILE LOOP ENDS");
				Console.WriteLine();
			}
			while (start <= end);
			Console.WriteLine("``````````````````````````````````````````");
			Console.WriteLine("***ThankYou***");
		}
	}
}
