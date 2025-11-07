using System;

namespace Session.Basics
{
	public class ValueAndReferenceTypes : ITopic
	{
		public void Run()
		{
			/*
			 * What are Value Types?
			 * Value types are data types that hold their value directly in memory (stack).
			 * 
			 * Various Value Types in C#:
			 * 1. Primitive Types: int, float, double, char, bool
			 * 2. Structs: Custom data structures defined using the 'struct' keyword.
			 * 3. Enumerations (enums): A distinct value type that consists of a set of named constants.
			 * 4. Nullable Types: Value types that can also represent null values using the '?' syntax (e.g., int?).
			 * 5. Tuples: A data structure that can hold a fixed number of items of different types.
			 * 
			 * Default Values of Value Types:
			 * 1. Numeric Types (int, float, double, etc.): Default to 0.
			 * 2. char: Default to '\0' (the null character).
			 * 3. bool: Default to false.
			 * 4. Structs: Default to a struct with all fields set to their default values.
			 * 5. Enumerations (enums): Default to the value corresponding to 0.
			 * 
			 * Copy Behavior of Value Types:
			 * Value types are copied by value. 
			 * 1. When you assign a value type to another variable, a new copy of the value is created.
			 * 2. When passed to methods, value types are passed by value by default.
			 * 3. Changes made to one variable do not affect the other.
			 * 
			 */

			Point p1 = new Point { X = 10, Y = 20 };
			Point p2 = p1; // p2 is a copy of p1
			p2.X = 30; // Modifying p2 does not affect p1
			Console.WriteLine($"p1.X: {p1.X}, p1.Y: {p1.Y}"); // Output: p1.X: 10, p1.Y: 20
			Console.WriteLine($"p2.X: {p2.X}, p2.Y: {p2.Y}"); // Output: p2.X: 30, p2.Y: 20

			ModifyPoint(p1);
			ModifyPoint(p2);

			Console.WriteLine($"After ModifyPoint - p1.X: {p1.X}, p1.Y: {p1.Y}"); // Output: p1.X: 10, p1.Y: 20
			Console.WriteLine($"After ModifyPoint - p2.X: {p2.X}, p2.Y: {p2.Y}"); // Output: p2.X: 30, p2.Y: 20

			/*
			 * What are Reference Types?
			 * Reference types store references (addresses) to their data (heap).
			 * 
			 * Various Reference Types in C#:
			 * 1. Classes: Custom data structures defined using the 'class' keyword.
			 * 2. Interfaces: Define a contract that classes can implement.
			 * 3. Delegates: Type-safe function pointers.
			 * 4. Arrays: Collections of elements of the same type.
			 * 5. Strings: Immutable sequences of characters.
			 * 6. Dynamic Types: Types that are resolved at runtime using the 'dynamic' keyword.
			 * 7. Objects: The base type from which all other types derive.
			 * 
			 * 	Default Values of Reference Types:
			 * 	1. Classes, Interfaces, Delegates, Arrays, Strings, Dynamic Types, Objects: Default to null.
			 * 
			 * 	Copy Behavior of Reference Types:
			 * 	Reference types are copied by reference.
			 * 	1. When you assign a reference type to another variable, both variables point to the same object in memory.
			 * 	2. When passed to methods, reference types are passed by reference by default.
			 * 	3. Changes made to one variable affect the other since they reference the same object.
			 * 	4. To create a separate copy of an object, you need to implement cloning (shallow or deep copy).
			 * 	
			 */

			Fan ceilingFan = new Fan();
			ceilingFan.SetColor("White");
			Fan tableFan = ceilingFan; // tableFan references the same object as ceilingFan
			tableFan.TurnOn();
			Console.WriteLine($"ceilingFan isOn: {ceilingFan.IsOn}, Color: {ceilingFan.GetColor()}"); // Output: ceilingFan isOn: True, Color: White

			tableFan.SetColor("Blue");
			Console.WriteLine($"ceilingFan Color after anotherFan change: {ceilingFan.GetColor()}"); // Output: ceilingFan Color after anotherFan change: Blue

			ModifyFan(ceilingFan, "Red");
			Console.WriteLine($"After ModifyFan - ceilingFan Color: {ceilingFan.GetColor()}"); // Output: After ModifyFan - ceilingFan Color: Red
			Console.WriteLine($"After ModifyFan - tableFan Color: {tableFan.GetColor()}"); // Output: After ModifyFan - tableFan Color: Red

			ModifyFan(tableFan, "Green");
			Console.WriteLine($"After ModifyFan - ceilingFan Color: {ceilingFan.GetColor()}"); // Output: After ModifyFan - ceilingFan Color: Green
			Console.WriteLine($"After ModifyFan - tableFan Color: {tableFan.GetColor()}"); // Output: After ModifyFan - tableFan Color: Green

			/*
			 * 	Summary:
			 * 	
			 * 	When to Use Value Types vs Reference Types:
			 * 	
			 * 	Value Types:
			 * 	1. Use for small, simple data structures that represent a single value.
			 * 	2. Use when you want to ensure that each variable has its own copy of the data.
			 * 	3. Use for performance-critical applications where memory allocation and deallocation overhead should be minimized.
			 * 	4. Use for immutable data that should not change after creation.
			 * 
			 * Reference Types:
			 * 1. Use for complex data structures that may contain multiple related values or behaviors.
			 * 2. Use when you want to share data between different parts of your application.
			 * 3. Use when you need to implement polymorphism and inheritance.
			 * 4. Use for large data structures where copying the entire structure would be inefficient.
			 * 5. Use when you need to manage the lifetime of an object explicitly (e.g., using IDisposable).
			 * 6. Use when you need to work with collections of objects (e.g., lists, dictionaries).
			 * 
			 * 	Difference between Value Types and Reference Types:
			 * 	1. Storage Location: Value types are stored on the stack, while reference types are stored on the heap.
			 * 	2. Copy Behavior: Value types are copied by value, while reference types are copied by reference.
			 * 	3. Default Values: Value types have default values based on their type, while reference types default to null.
			 * 	4. Mutability: Value types are typically immutable, while reference types can be mutable.
			 * 	5. Inheritance: Value types do not support inheritance, while reference types do.
			 * 	6. Memory Management: Value types are automatically deallocated when they go out of scope, while reference types are managed by the garbage collector.
			 * 
			 */
		}

		void ModifyPoint(Point point)
		{
			point.X = 50; // This modification is on a copy of the original point and does not affect the original
		}

		void ModifyFan(Fan fan, string color)
		{
			fan.SetColor(color); // This modification affects the original fan object
		}
	}
}
