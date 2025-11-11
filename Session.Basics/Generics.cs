using System;
using System.Numerics;

namespace Session.Basics
{
	public class Generics : ITopic
	{
		public void Run()
		{
			Addition operations = new Addition();
			operations.AddIntegers(5, 10);
			operations.AddDoubles(5.5, 10.3);
			operations.AddFloats(2.5f, 4.5f);

			GenericAddition genericAddition = new GenericAddition();
			int addIntegers = genericAddition.Add<int>(1, 2);
			//float addDoubles = genericAddition.Add<double>(1.5D, 2.5D);
			float addFloats = genericAddition.Add<float>(1.5F, 2.5F);

			GenericComparsion<int> genericComparsion = new GenericComparsion<int>();
			int result = genericComparsion.Compare(1, 2);

			GenericComparsion<string> stringComparsion = new GenericComparsion<string>();
			int stringCompare = stringComparsion.Compare("apple", "banana");

			Console.WriteLine($"Generic Addition of Integers: 1 + 2 = {addIntegers}");
			Console.WriteLine($"Generic Addition of Floats: 1.5 + 2.5 = {addFloats}");
			Console.WriteLine($"Generic Comparison of Integers: Compare(1, 2) = {result}");
			Console.WriteLine($"Generic Comparison of Strings: Compare('apple', 'banana') = {stringCompare}");
		}
	}

	public class GenericComparsion<T>
		where T : IComparable<T>
	{
		public int Compare(T value1, T value2)
		{
			return value1.CompareTo(value2);
		}

		public void Print()
		{
			Console.WriteLine($"Generic Comparsion Type: {typeof(T)}");
		}
	}

	public class GenericAddition
	{
		public T Add<T>(T number1, T number2)
			where T : INumber<T>
		{
			return number1 + number2;
		}
	}

	public class Addition
	{
		public void AddIntegers(int a, int b)
		{
			int result = a + b;
			System.Console.WriteLine($"Integer Addition: {a} + {b} = {result}");
		}

		public void AddDoubles(double a, double b)
		{
			double result = a + b;
			System.Console.WriteLine($"Double Addition: {a} + {b} = {result}");
		}

		public void AddFloats(float a, float b)
		{
			float result = a + b;
			System.Console.WriteLine($"Float Addition: {a} + {b} = {result}");
		}

	}
}
