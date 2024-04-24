namespace Delegates_And_Events
{
	class State
	{
		public delegate void StateDelegate();
		public string InnerState { get; set; }

		public void PrintState()
		{
			Console.WriteLine(InnerState);
		}
	}

	public class Program
	{
		static void PrintingHandler(string s)
		{
			Console.WriteLine("OnPrinting called");
		}

		static void Main()
		{
			//var example = new Example();
			//example.TestDelegate();

			var example2 = new Example2();
			//example2.TestDelegate();
			//example2.TestDelegate2();

			State s1 = new State() {InnerState = "s1"};
			State s2 = new State() { InnerState = "s2" };

			var printState = new State.StateDelegate(s1.PrintState);

			printState();

			var obj = new EventExample();
			obj.OnPrinting += PrintingHandler;
			obj.Print("Hello, world!");

			Console.ReadKey();
		}
	}
}
