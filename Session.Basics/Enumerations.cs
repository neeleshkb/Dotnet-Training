using System;

namespace Session.Basics
{
	public class Enumerations : ITopic
	{
		public void Run()
		{
			/*
			 * What are Enumerations?
			 * Enumerations (enums) are a special data type that allows you to define a set of named constants.
			 * 
			 * Why use Enumerations?
			 * Enums improve code readability and maintainability by providing meaningful names for constant values.
			 * 
			 * What is default underlying type of an Enumeration?
			 * It is int.
			 * 
			 * Can you change the underlying type of an Enumeration?
			 * Yes, you can specify a different integral type (byte, sbyte, short, ushort, int, uint, long, ulong) by using a colon after the enum name.
			 * 
			 * What is the default value of an Enumeration?
			 * Default value is the value associated with the first enumerator, which is 0 unless explicitly specified otherwise.
			 */

			DaysOfTheWeek today = DaysOfTheWeek.Monday;
			if (today == DaysOfTheWeek.Monday)
			{
				Console.WriteLine("Today is Monday!");
			}
			else
			{
				Console.WriteLine("Today is not Monday.");
			}
		}
	}

	//public class DaysOfTheWeek
	//{
	//	public const int Sunday = 0;
	//	public const int Monday = 1;
	//}

	public enum DaysOfTheWeek
	{
		Sunday,
		Monday
	}
}
