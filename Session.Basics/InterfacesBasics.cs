namespace Session.Basics
{
	public interface ILogin
	{
		void Login(string username, string password);
		void Logout();
	}

	public class GoogleLogin : ILogin
	{
		public void Login(string username, string password)
		{
			System.Console.WriteLine($"Logging in to Google with username: {username}");
		}
		public void Logout()
		{
			System.Console.WriteLine("Logging out from Google");
		}
	}

	public class LinkedinLogin : ILogin
	{
		public void Login(string username, string password)
		{
			System.Console.WriteLine($"Logging in to LinkedIn with username: {username}");
		}
		public void Logout()
		{
			System.Console.WriteLine("Logging out from LinkedIn");
		}
	}

	public class InterfacesBasics : ITopic
	{
		public void Login(ILogin login, string username, string password)
		{
			login.Login(username, password);
		}

		public void Run()
		{
			bool useGoogle = true;
			bool useLinkedIn = false;
			if (useGoogle)
			{
				GoogleLogin googleLogin = new GoogleLogin();
				Login(googleLogin, "user", "password");
			}
			else if (useLinkedIn)
			{
				ILogin linkedinLogin = new LinkedinLogin();
				Login(linkedinLogin, "user", "password");
			}


			/*
			 * What is an Interface?
			 * An interface is a contract that defines a set of methods,
			 * properties, events, or indexers that a class or struct
			 * must implement.
			 * 
			 * Interfaces are defined using the interface keyword.
			 * 
			 * Interfaces can contain:
			 * 1. Methods
			 * 2. Properties
			 * 3. Events
			 * 4. Indexers
			 * 
			 * Interfaces cannot contain fields, constructors, destructors, or static members.
			 * 
			 * A class or struct can implement multiple interfaces.
			 * 
			 * Why use Interfaces?
			 * 1. Interfaces are used to achieve abstraction and multiple inheritance
			 * 2. Interfaces allow for loose coupling between classes
			 * 3. Interfaces are used to define capabilities that can be shared
			 */

			IFan ceilingFan = new CeilingFan();
			ceilingFan.Color = "White";
			ceilingFan.TurnOn();
			System.Console.WriteLine($"Ceiling Fan Color: {ceilingFan.Color}");

			IFan tableFan = new TableFan();
			tableFan.Color = "Black";
			tableFan.TurnOn();
			System.Console.WriteLine($"Table Fan Color: {tableFan.Color}");

			// Note: We cannot create an instance of an interface

			// Two classes implementing the same interface can be used interchangeably

			TurnOn(ceilingFan);
			TurnOn(tableFan);

			// Classes implementing the same interface can not be assigned to each other, even though they share the same contract

			// ceilingFan = tableFan; // This will cause a compile-time error

			IFan variable = new CeilingFan();
			variable = new TableFan(); // This is valid

		}

		void TurnOn(IFan fan)
		{
			fan.TurnOn();
		}
	}
}
