namespace Delegates_And_Events
{
	public class EventExample
	{
		public delegate void MyEventDelegate(string eventDescr);
		public event MyEventDelegate OnPrinting;

		public void Print(string s)
		{
			if (OnPrinting != null)
			{
				OnPrinting(s);
			}

			Console.WriteLine(s);
		}
	}
}
