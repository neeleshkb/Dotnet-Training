namespace Session.Basics
{
	/*
	 * What is a Struct?
	 * A struct is a value type that can encapsulate data and related functionality.
	 * Structs are typically used for small data structures that contain primarily
	 * data that is not intended to be modified after the struct is created.
	 * 
	 * Key Characteristics of Structs:
	 * 1. Value Type: Structs are value types, which means they are stored on the stack.
	 * 2. **No Inheritance: Structs do not support inheritance, but they can implement interfaces.
	 * 3. **Default Constructor: Structs cannot have a default (parameterless) constructor.
	 * 4. Memory Efficiency: Structs can be more memory efficient for small data structures.
	 * 
	 * When to Use Structs:
	 * - When you need a small, lightweight object.
	 * - When the object represents a single value or a small group of related values.
	 * - When you want to avoid the overhead of heap allocation and garbage collection.
	 */

	/*
	 * What are the members of a struct?
	 * 1. Fields
	 * 2. Properties
	 * 3. Constructors
	 * 4. Methods
	 * 5. Operators
	 * 6. Nested Types
	 * 7. Static Members
	 */

	public struct Point
	{
		/*
		 * What are fields in a struct?
		 * Fields are variables that hold data for the struct.
		 */
		private int x;
		private int y;

		/*
		 * What are properties in a struct?
		 * Properties are members that provide a flexible mechanism
		 * to read, write, or compute the values of private fields.
		 * Properties can have get and set accessors.
		 */
		public int Y { get => y; set => y = value; }
		public int X { get => x; set => x = value; }

		/*
		 * What are constructors in a struct?
		 * Constructors are special methods that are called when a struct is created.
		 * They are used to initialize the fields and properties of the struct.
		 */
		public Point(int x, int y)
		{
			X = x;
			Y = y;
		}

		/*
		 * What are methods in a struct?
		 * Methods are functions that define the behavior of the struct.
		 */

		public int GetX()
		{
			return x;
		}

		public int GetY()
		{
			return y;
		}

		/*
		 * What are mutator methods in a struct?
		 * Mutator methods are methods that modify the state of the struct.
		 */

		public void SetX(int x)
		{
			this.x = x;
		}

		public void SetY(int y)
		{
			this.y = y;
		}
	}
}
