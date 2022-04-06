using System;

namespace ConsoleApp1
{
	class Program
	{
		static void Main(string[] args)
		{
			int i, j;

			//post-increment example
			i = 0;
			j = i++;
			Console.WriteLine("Post-Increment");
			Console.WriteLine("The valuie of j (i++): " + j);
			Console.WriteLine("The valuie of i (i++): " + i);

			//pre-increment example
			i = 0;
			j = ++i;
			Console.WriteLine("Pre-Increment");
			Console.WriteLine("The valuie of j (++i): " + j);
			Console.WriteLine("The valuie of i (++i): " + i);
		}
	}
}