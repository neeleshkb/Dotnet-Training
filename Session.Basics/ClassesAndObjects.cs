namespace Session.Basics
{
	public class ClassesAndObjects : ITopic
	{
		public void Run()
		{
			/*
			 * Objects are created using the new keyword followed by the class name
			 * 
			 */

			Fan ceilingFan = new Fan();

			/*
			 * Members of a class can be accessed using the dot (.) operator.
			 */

			ceilingFan.SetColor("White");
			ceilingFan.TurnOn();
			ceilingFan.SetSpeed(3);

			System.Console.WriteLine($"Ceiling Fan Status: {ceilingFan.GetStatus()}");

			Fan tableFan = new Fan();
			tableFan.SetColor("Black");
			tableFan.TurnOn();
			tableFan.IncreaseSpeed(2);
			System.Console.WriteLine($"Table Fan Status: {tableFan.GetStatus()}");
			tableFan.TurnOff();
			System.Console.WriteLine($"Table Fan Status after turning off: {tableFan.GetStatus()}");
		}
	}
}