using System;

namespace Session.Basics
{
	public class ConstantsAndStaticMembers : ITopic
	{
		public void Run()
		{
			/*
			 * What is a Constants?
			 * Constants are immutable values which are known at compile time and do not change for the life of the program.
			 * 
			 * When to use Constants?
			 * Constants are used to define values that should not change throughout the execution of a program.
			 *
			 * Constant Declaration Syntax:
			 * const data_type constant_name = value;
			 * 
			 * Constants can be of any built-in data type like int, float, double, char, string, etc.
			 * Constants must be initialized at the time of declaration.
			 * Constants are implicitly static, so they belong to the type itself rather than to any specific instance.
			 * Constants cannot be modified after their declaration.
			 * Constants are defined using the 'const' keyword and can be declared at class level or within methods.
			 * Constants are typically named using uppercase letters with underscores to separate words (e.g., MAX_VALUE).
			 * Constants can be accessed directly using the class name without creating an instance of the class.
			 * Constants are used in classes, structs.
			 */

			Console.WriteLine($"Value of PI: {MathConstants.PI}");
			Console.WriteLine($"Value of E: {MathConstants.E}");

			/*
			 * Static Members
			 * What are Static Members?
			 * 
			 * Static members belong to the type itself rather than to any specific instance of the type.
			 * Static members are shared across all instances of the type.
			 * Static members can be fields, methods, properties, or constructors.
			 * Static members are declared using the 'static' keyword.
			 * Static members can be accessed directly using the class name without creating an instance of the class.
			 * Static members are typically used for utility functions or shared data that is common to all instances of a class.
			 * Static members can be initialized in a static constructor, which is called automatically before the first instance is created or any static members are accessed.
			 * Static members can be accessed using the class name followed by the member name (e.g., ClassName.StaticMember).
			 * Static members are used in classes and structs.
			 * 
			 * When to use Static Members?
			 * Static members are used when you want to share data or behavior across all instances of a class
			 * Also , when you want to define utility functions that do not depend on instance data.
			 */

			double number = 3.0;
			Console.WriteLine($"Square of {number} is: {MathUtilities.Square(number)}");
			Console.WriteLine($"Cube of {number} is: {MathUtilities.Cube(number)}");

			double value = 5.0;
			Console.WriteLine($"Multiplying {value} by Golden Ratio: {MathStruct.MultiplyByGoldenRatio(value)}");
		}

		// Classes with Constants
		// These are nested classes for demonstration purposes

		public class MathConstants
		{
			public const double PI = 3.14159;
			public const double E = 2.71828;
		}

		public class MathUtilities
		{
			public static double Square(double number)
			{
				return number * number;
			}
			public static double Cube(double number)
			{
				return number * number * number;
			}
		}

		public struct MathStruct
		{
			public const double GOLDEN_RATIO = 1.61803;
			public static double MultiplyByGoldenRatio(double number)
			{
				return number * GOLDEN_RATIO;
			}
		}

	}
}
