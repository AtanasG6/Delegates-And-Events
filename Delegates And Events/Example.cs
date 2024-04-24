namespace Delegates_And_Events
{
	public class Example
	{
		public delegate void MyDelegate(string s);

		public void Print(string s)
		{
			Console.Write(s);
		}

		public void PrintLine(string s)
		{
			Console.WriteLine(s);
		}

		public void TestDelegate()
		{
			MyDelegate d = new MyDelegate(Print);
			d("Hello, ");
			d("world!");
		}
	}
}
