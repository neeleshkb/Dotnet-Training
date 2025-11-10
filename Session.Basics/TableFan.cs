using System;

namespace Session.Basics
{
	public class TableFan : IFan
	{
		public string Color { get; set; }
		public void TurnOn()
		{
			Console.WriteLine("Table fan is turned on.");
		}
		public void TurnOff()
		{
			Console.WriteLine("Table fan is turned off.");
		}
	}
}
