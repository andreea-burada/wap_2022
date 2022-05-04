using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_delegates
{
	// This delegate can point to any method, taking two integers and returning an integer.
	public delegate int BinaryOp(int x, int y);

	// 
	public class SimpleMath
	{
		public static int Add(int x, int y)
		{ return x + y; }
		public static int Subtract(int x, int y)
		{ return x - y; }
	}

	internal class Program
	{
		private static void Main()
		{
			Console.WriteLine("***** Delegate Example *****\n");

			//Definition and instantiating the delegate
			BinaryOp b = new BinaryOp(SimpleMath.Add);
			//BinaryOp b = new BinaryOp(SimpleMath.Subtract);
			b += new BinaryOp(SimpleMath.Subtract);

			//Call through the delegate
			Console.WriteLine("10 + 10 is {0}", b(10, 10));
			//Console.ReadLine();
		}
	}
}
