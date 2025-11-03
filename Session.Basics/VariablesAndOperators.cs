using System;

namespace Session.Basics
{
	public class VariablesAndOperators : ITopic
	{
		public void Run()
		{
			/*
			 * What is a Variable?
			 * Variables are used to store data in a program. They have a name, a type, and a value.
			 */
			int myNumber; // Declaration
			myNumber = 42; // Initialization
			Console.WriteLine($"My Number: {myNumber}");

			myNumber = 100; // Re-assignment
			Console.WriteLine($"My Number after re-assignment: {myNumber}");

			/*
			 * Operators in C#
			 * Operators are special symbols that perform operations on variables and values.
			 */
			Console.WriteLine("\n--- Arthmetic Operators in C# ---");
			//Arthmetic Operators
			int number = 10;
			int number2 = number + 5; // Addition
			int number3 = number - 3; // Subtraction
			int number4 = number * 2; // Multiplication
			int number5 = number / 2; // Division
			int number6 = number % 3; // Modulus

			Console.WriteLine($"Addition: {number2}");
			Console.WriteLine($"Subtraction: {number3}");
			Console.WriteLine($"Multiplication: {number4}");
			Console.WriteLine($"Division: {number5}");
			Console.WriteLine($"Modulus: {number6}");

			Console.WriteLine("\n--- Assignment Operators in C# ---");
			//Assignment Operators
			int assignNumber = 10;
			Console.WriteLine($"Initial Value: {assignNumber}");
			assignNumber = assignNumber + 5;
			Console.WriteLine($"After Addition Assignment: {assignNumber}");
			assignNumber += 3;
			Console.WriteLine($"After += Assignment: {assignNumber}");

			int assignNumber2 = 20;
			Console.WriteLine($"Initial Value: {assignNumber2}");
			//assignNumber2 = assignNumber2 - 4;
			assignNumber2 -= 4;
			Console.WriteLine($"After -= Assignment: {assignNumber2}");

			int assignNumber3 = 5;
			Console.WriteLine($"Initial Value: {assignNumber3}");
			//assignNumber3 = assignNumber3 * 2;
			assignNumber3 *= 2;
			Console.WriteLine($"After *= Assignment: {assignNumber3}");

			int assignNumber4 = 16;
			Console.WriteLine($"Initial Value: {assignNumber4}");
			//assignNumber4 = assignNumber4 / 4;
			assignNumber4 /= 4;
			Console.WriteLine($"After /= Assignment: {assignNumber4}");

			Console.WriteLine("\n--- Comparison Operators in C# ---");
			//Comparison Operators
			string str1 = "Hello";
			string str2 = "World";

			bool areEqual = str1 == str2;
			Console.WriteLine($"Are strings equal? {areEqual}");

			bool noEqual = str1 != str2;
			Console.WriteLine($"Are strings not equal? {noEqual}");

			int a1 = 10;
			int a2 = 20;

			bool isGreater = a1 > a2;
			Console.WriteLine($"Is a1 greater than a2? {isGreater}");

			bool isLess = a1 < a2;
			Console.WriteLine($"Is a1 less than a2? {isLess}");

			bool isGreaterOrEqual = a1 >= a2;
			Console.WriteLine($"Is a1 greater than or equal to a2? {isGreaterOrEqual}");

			bool isLessOrEqual = a1 <= a2;
			Console.WriteLine($"Is a1 less than or equal to a2? {isLessOrEqual}");

			Console.WriteLine("\n--- Logical Operators in C# ---");
			//Logical Operators
			int age = 25;
			string name = "Alice";

			bool andResult = name == "Alice" && age < 18;
			Console.WriteLine($"Logical AND result: {andResult}");

			bool orResult = name == "Alice" || age < 18;
			Console.WriteLine($"Logical OR result: {orResult}");

			bool notResult = !(age < 18);
			Console.WriteLine($"Logical NOT result: {notResult}");

			notResult = !andResult;
			Console.WriteLine($"Logical NOT of AND result: {notResult}");

			Console.WriteLine("\n--- Increment and Decrement Operators in C# ---");
			//Increment and Decrement Operators
			int count = 100;
			Console.WriteLine($"Initial Count: {count}");

			int value101 = ++count;  //Pre-Increment ++count => count = count + 1
			Console.WriteLine($"Count after Pre-Increment: {count}");
			Console.WriteLine($"After Pre-Increment: {value101}");

			int value102 = count++; // Post-Increment count++ => use count, then count = count + 1
			Console.WriteLine($"Count after Post-Increment: {count}");
			Console.WriteLine($"After Post-Increment: {value102}");

			int value103 = --count; // Pre-Decrement --count => count = count - 1
			Console.WriteLine($"Count after Pre-Decrement: {count}");
			Console.WriteLine($"After Pre-Decrement: {value103}");

			int value104 = count--; // Post-Decrement count-- => use count, then count = count - 1
			Console.WriteLine($"Count after Post-Decrement: {count}");
			Console.WriteLine($"After Post-Decrement: {value104}");
		}
	}
}
