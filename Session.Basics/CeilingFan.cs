using System;

namespace Session.Basics
{
	public class CeilingFan : IFan
	{
		public string Color { get; set; }
		public void TurnOn()
		{
			Console.WriteLine("Ceiling fan is turned on.");
		}
		public void TurnOff()
		{
			Console.WriteLine("Ceiling fan is turned off.");
		}
	}
}
