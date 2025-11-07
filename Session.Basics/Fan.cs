namespace Session.Basics
{
	/*
	 * What is a Class?
	 * Classes are blueprints for creating objects.
	 * 
	 * What are Objects?
	 * Objects are instances of classes.
	 * 
	 * What are members of a class?
	 * 1. Fields
	 * 2. Properties
	 * 3. Constructors
	 * 4. Methods
	 * 5. Destructors
	 * 6. Events
	 * 7. Indexers
	 * 8. Operators
	 * 9. Nested Types
	 * 10. Static Members
	 */

	/*
	 * Different Access Modifiers in C#:
	 * 1. public
	 * 2. private
	 * 3. protected
	 * 4. internal
	 * 5. protected internal
	 * 6. private protected
	 */

	/*
	 * What are the default access modifiers for class and its members?
	 * 
	 * For top-level classes, the default access modifier is internal.
	 * 
	 * For class members, the default access modifier is private.
	 */

	public class Fan
	{
		/*
		 * What are Fields?
		 * Fields are variables that hold data for an object.
		 * Fields are declared inside a class but outside
		 * Fields are used to store the state of an object.
		 */
		// Fields like color, speed, isOn
		private string color;
		private int speed;
		private bool isOn;

		/*
		 * What are Properties?
		 * Properties are members that provide a flexible mechanism
		 * to read, write, or compute the values of private fields.
		 * Properties can have get and set accessors.
		 */
		// Properties to get the values of the fields
		public string Color { get => color; }
		public int Speed { get => speed; }
		public bool IsOn { get => isOn; }

		/*
		 * What are Constructors?
		 * Constructors are special methods that are called when an object is created.
		 * They are used to initialize the fields and properties of the object.
		 */

		/*
		 * What is a Default Constructor?
		 * Default constructors are constructors that do not take any parameters.
		 */
		public Fan()
		{
			this.color = "White";
			this.speed = 0;
			this.isOn = false;
		}

		/*
		 * What is a Parameterized Constructor?
		 * Parameterized constructors are constructors that take parameters.
		 */
		public Fan(string color)
		{
			this.color = color;
			this.speed = 0;
			this.isOn = false;
		}

		/*
		 * What are Methods?
		 * Methods are functions that define the behavior of an object.
		 * Methods can perform actions, manipulate data, and return values.
		 */

		/*
		 * Different Types of Methods:
		 * 
		 * Methods without parameters and without return type
		 * Methods with parameters and without return type
		 * Methods without parameters and with return type
		 * Methods with parameters and with return type 
		 */

		// Method without parameters and without return type
		public void TurnOn()
		{
			isOn = true;
			speed = 1; // Default speed
		}

		// Method with parameters and without return type
		public void SetColor(string newColor)
		{
			color = newColor;
		}

		// Method without parameters and with return type
		public string GetColor()
		{
			return color;
		}

		// Method with parameters and with return type
		public int IncreaseSpeed(int increment)
		{
			if (isOn)
			{
				speed += increment;
				if (speed > 5)
				{
					speed = 5; // Max speed
				}
			}
			return speed;
		}

		public void TurnOff()
		{
			isOn = false;
			speed = 0;
		}

		public void SetSpeed(int newSpeed)
		{
			if (isOn && newSpeed >= 0 && newSpeed <= 5)
			{
				speed = newSpeed;
			}
		}

		public string GetStatus()
		{
			return $"Fan Color: {color}, Is On: {isOn}, Speed: {speed}";
		}

		/*
		 * What is a Destructor?
		 * Destructors are special methods that are called when an object is destroyed.
		 * Used to clean up resources before the object is removed from memory.
		 */
		~Fan()
		{
			// Cleanup code if needed
		}
	}
}