using System;
namespace ConsoleApp2
{
	class Program
	{
		static void Main(string[] args)
		{
			whileLoop1 myLoop1 = new whileLoop1();
			myLoop1.tryWhileLoop();
			Console.WriteLine("##################################");
			Console.WriteLine();
			doWhileLoop1 myLoop2 = new doWhileLoop1();
			myLoop2.tryDoWhileLoop();
		}
	}
}
