using System;

namespace Session.Basics.Topics
{
	public class ControlFlowAndLoops : ITopic
	{
		public void Run()
		{
			/*
			 * Conditional Statements in C#
			 * If-else Statements, Else-if Ladder, Switch Statement
			 */

			int number1 = 10;
			int number2 = 20;
			bool result = number1 > number2;
			Console.WriteLine("--- If-else Statements in C# ---");
			if (result)
			{
				Console.WriteLine($"{number1} is greater than {number2}");
			}
			else
			{
				Console.WriteLine($"{number1} is not greater than {number2}");
			}

			Console.WriteLine("--- Else-if Ladder in C# ---");
			string typeOfPerson = "Student";
			string studentName = "Alice";

			if (typeOfPerson == "Student" && studentName == "Alice")
			{
				Console.WriteLine("Person is a student");
			}
			else if (typeOfPerson == "Teacher")
			{
				Console.WriteLine("Person is a teacher");
			}
			else if (typeOfPerson == "Principal")
			{
				Console.WriteLine("Person is principal");
			}
			else
			{
				Console.WriteLine("Person is House keeping");
			}

			Console.WriteLine("--- Switch Statement in C# ---");
			switch (typeOfPerson)
			{
				case "Student":
					Console.WriteLine("Using Switch Person is a student");
					break;
				case "Teacher":
					{
						Console.WriteLine("Using Switch Person is a teacher");
					}
					break;
				case "Principal":
					{
						Console.WriteLine("Using Switch Person is principal");
					}
					break;
				default:
					{
						Console.WriteLine("Using Switch Person is House keeping");
					}
					break;
			}

			Console.WriteLine("--- Loops in C# ---");

			int[] numbers = new int[6]; // Index always starts from 0
			numbers[0] = 10;
			numbers[1] = 20;
			numbers[2] = 30;
			numbers[3] = 40;
			numbers[4] = 50;
			numbers[5] = 7;

			Console.WriteLine("For Loop Example:");

			/*
			 * When to use For Loop vs Foreach Loop:
			 * Use a for loop when you need to iterate over a collection with an index,
			 * Use a foreach loop when you want to iterate over each element in a collection without needing the index.
			 */
			for (int index = 0; index < numbers.Length; index++)
			{
				int arrayValue = numbers[index];
				Console.WriteLine($"For Loop - Number at index {index}: {arrayValue}");
			}

			Console.WriteLine("Foreach Loop Example:");
			foreach (int value in numbers)
			{
				Console.WriteLine($"Foreach Loop - Number: {value}");
			}

			Console.WriteLine();
			// I want to print only even numbers
			for (int index = 0; index < numbers.Length; index++)
			{
				int arrayValue = numbers[index];
				if (arrayValue % 2 == 0)
				{
					Console.WriteLine($"For Loop - Even Number at index {index}: {arrayValue}");
				}
			}
			Console.WriteLine();
			foreach (int value in numbers)
			{
				if (value % 2 == 0)
				{
					Console.WriteLine($"Foreach Loop - Even Number: {value}");
				}
			}

			/*
			 * When to use While Loop vs Do-While Loop:
			 * Use a while loop when you want to repeat a block of code as long as a condition is true,
			 * Use a do-while loop when you want to ensure that the block of code is executed at least once before checking the condition.
			 */
			Console.WriteLine();
			int indexWhile = 0;
			while (indexWhile < numbers.Length)
			{
				Console.WriteLine($"While Loop - Even Number: {numbers[indexWhile]}");
				indexWhile++;
			}

			Console.WriteLine();
			int indexDoWhile = 0;
			do
			{
				Console.WriteLine($"Do-While Loop - Number at index {indexDoWhile}: {numbers[indexDoWhile]}");
				indexDoWhile++;
			}
			while (indexDoWhile < numbers.Length);

			Console.WriteLine("\n--- Break and Continue Statements in C# ---");
			/*
			 * Use of Break and Continue Statements:
			 * Use the break statement to exit a loop or switch statement prematurely when a certain condition is met.
			 * Use the continue statement to skip the current iteration of a loop and move to the next iteration when a certain condition is met.
			 */
			// I want to print first even number and exit the loop
			foreach (int value in numbers)
			{
				if (value % 2 == 0)
				{
					Console.WriteLine($"Break Example - First Even Number: {value}");
					break;
				}
			}

			for (int i = 0; i < numbers.Length; i++)
			{
				if (i < 3)
				{
					continue;
				}
				Console.WriteLine($"Continue Example - Number at index {i}: {numbers[i]}");
			}
		}
	}
}
