﻿namespace Delegates_And_Events
{
	public class Example2
	{
		public delegate int BinaryOperator(int a, int b);

		public int Sum(int a, int b)
		{
			Console.WriteLine("Sum called.");
			return a + b;
		}

		public int Multiply(int a, int b)
		{
			Console.WriteLine("Multiply called.");
			return a * b;
		}

		public void TestDelegate()
		{
			BinaryOperator op = null;

			Console.Write("a = ");
			var a = int.Parse(Console.ReadLine());
			Console.Write("b = ");
			var b = int.Parse(Console.ReadLine());

			Console.WriteLine("Sum (+) or Multiply (*)?");
			var opStr = Console.ReadLine();
			if (opStr == "+")
			{
				op += Sum;
			}
			else if (opStr == "*")
			{
				op += Multiply;
			}

			if (op!=null)
			{
				var result = op(a, b);
				Console.WriteLine("Result: {0}", result);
			}
		}

		public void TestDelegate2()
		{
			BinaryOperator op = null;

			Console.Write("a = ");
			var a = int.Parse(Console.ReadLine());
			Console.Write("b = ");
			var b = int.Parse(Console.ReadLine());

			Console.WriteLine("Sum (+) or Multiply (*)?");
			var opStr = Console.ReadLine();
			if (opStr.Contains("+"))
			{
				op += Sum;
			}
			if (opStr.Contains("*"))
			{
				op += Multiply;
			}

			if (op != null)
			{
				var result = op(a, b);
				Console.WriteLine("Result: {0}", result);
			}
		}
	}
}
