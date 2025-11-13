using System;
using System.Collections.Generic;

namespace Session.Basics
{
	public class FunctionPointerDelegate : ITopic
	{
		public void Run()
		{
			/*
			 * Delegates:
			 * 1. A delegate is a type that represents references to methods with a specific parameter list and return type.
			 * 2. Delegates are similar to function pointers in C/C++, but are type-safe and secure.
			 * 3. Delegates can be used to pass methods as arguments to other methods.
			 * 4. Delegates are commonly used for implementing event handling and callback methods.
			 * 5. Syntax to declare a delegate: public delegate returnType DelegateName(parameterList);
			 * 
			 * When to use Delegates:
			 * 1. When you need to pass methods as parameters to other methods.
			 * 2. When implementing event handling mechanisms.
			 * 3. When you want to define callback methods.
			 * 4. When you need to encapsulate method references for later invocation.
			 * 
			 */

			int[] numbers = new int[5];
			numbers[0] = 1;
			numbers[1] = 2;
			numbers[2] = 3;
			numbers[3] = 4;
			numbers[4] = 5;


			List<int> oddNumbers = FilterOddNumber(numbers);
			foreach (int number in oddNumbers)
			{
				Console.WriteLine(number);
			}

			Console.WriteLine();
			List<int> evenNumbers = FilterEvenNumbers(numbers);
			foreach (int number in evenNumbers)
			{
				Console.WriteLine(number);
			}

			FilterOut instance = new FilterOut(EvenNumbers);
			FilterOut odd = OddNumber;

			List<int> even = Filter(numbers, instance);

			//FilterOut oddNumbers = new FilterOut(OddNumber);
			//List<int> odd = Filter(numbers, oddNumbers);

			// Lamdba syntax
			FilterOut three = (value) => value % 3 == 0;
			//{
			//	//bool isThree = value % 3 == 0;
			//	//return isThree;
			//	return value % 3 == 0;
			//};

			List<int> byThree = Filter(numbers, three);
			List<int> bySeven = Filter(numbers, (value) => value % 7 == 0);
		}

		// Declare a delegate that takes an int parameter and returns a bool
		public delegate bool FilterOut(int number);

		public List<int> FilterEvenNumbers(int[] numbers)
		{
			List<int> evenNumbers = new List<int>();
			foreach (int element in numbers)
			{
				if (element % 2 == 0)
				{
					evenNumbers.Add(element);
				}
			}
			return evenNumbers;
		}

		public List<int> FilterOddNumber(int[] numbers)
		{
			List<int> oddNumbers = new List<int>();
			foreach (int element in numbers)
			{
				if (element % 2 != 0)
				{
					oddNumbers.Add(element);
				}
			}
			return oddNumbers;
		}

		public List<int> FilterNumbersDivisibleByThree(int[] numbers)
		{
			List<int> three = new List<int>();
			foreach (int element in numbers)
			{
				if (element % 3 == 0)
				{
					three.Add(element);
				}
			}
			return three;
		}

		public List<int> Filter(int[] numbers, FilterOut condition)
		{
			List<int> elements = new List<int>();
			foreach (int element in numbers)
			{
				bool result = condition(element);
				if (result)
				{
					elements.Add(element);
				}
			}
			return elements;
		}

		public bool EvenNumbers(int number)
		{
			bool iseven = number % 2 == 0;
			return iseven;
		}

		public bool OddNumber(int number)
		{
			bool isOdd = number % 2 != 0;
			return isOdd;
		}

	}
}
