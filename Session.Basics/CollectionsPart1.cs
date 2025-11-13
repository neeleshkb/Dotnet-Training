using System;
using System.Collections.Generic;

namespace Session.Basics
{
	public class CollectionsPart1 : ITopic
	{
		public void Run()
		{
			/*
			 * What are collections?
			 * Collections are data structures that can hold multiple values.
			 * 
			 */

			/*
			 * Arrays:
			 * 1. An array is a fixed-size collection of elements of the same type.
			 * 2. Arrays are indexed, meaning each element can be accessed using its index.
			 * 3. Arrays have a fixed size, which means once they are created, their size cannot be changed.
			 * 4. Arrays can hold primitive types (like int, char, etc.) as well as complex types (like objects).
			 * 5. Arrays are zero-based, meaning the first element is at index 0.
			 * 6. Syntax to declare an array: type[] arrayName = new type[size];
			 * 
			 * When to use Arrays:
			 * 1. When you know the number of elements in advance and it won't change.
			 * 2. When you need fast access to elements using an index.
			 * 3. When you want to store a collection of elements of the same type.
			 * 4. When memory efficiency is a concern, as arrays have less overhead compared to other collection types.
			 * 
			 * Limitations of Arrays:
			 * 1. Fixed Size: Once an array is created, its size cannot be changed. This can lead to wasted memory if the array is not fully utilized or insufficient space if more elements need to be added.
			 * 2. Homogeneous Elements: Arrays can only hold elements of the same type, which limits their flexibility.
			 * 3. Performance: Inserting or deleting elements in an array can be inefficient, as it may require shifting elements to maintain order.
			 * 4. Lack of Built-in Functionality: Arrays do not provide many built-in methods for common operations like adding, removing, or searching for elements, which can lead to more complex code.
			 * 
			 * Performance Considerations:
			 * 1. Access Speed: Arrays provide O(1) time complexity for accessing elements by index, making them very fast for read operations.
			 * 2. Memory Usage: Arrays have lower memory overhead compared to other collection types, as they do not require additional metadata for dynamic sizing or type information.
			 */

			int[] numbers = new int[5]; // Declare an array of integers with a size of 5
			numbers[0] = 10; // Assign value to the first element
			numbers[1] = 20;
			numbers[2] = 30;
			numbers[3] = 40;
			numbers[4] = 50;

			// Accessing array elements
			for (int i = 0; i < numbers.Length; i++)
			{
				Console.WriteLine($"Element at index {i}: {numbers[i]}");
			}

			// Sorting an array
			Array.Sort(numbers);

			foreach (int number in numbers)
			{
				Console.WriteLine($"Sorted number: {number}");
			}

			// Finding an element in an array
			int v = Array.Find(numbers, n => n == 30);
			Console.WriteLine($"Found value: {v}");

			/*
			 * String:
			 * 1. Strings are a special type of collection that represents a sequence of characters.
			 * 2. Strings are immutable, meaning once they are created, their value cannot be changed.
			 * 3. String can loop through each character using a foreach loop.
			 * 
			 * Limitations of Strings:
			 * 1. Immutability: Strings are immutable, meaning any modification creates a new string. This can lead to performance issues when performing many concatenations or modifications.
			 * 2. Memory Overhead: Each time a string is modified, a new string is created, which can lead to increased memory usage and fragmentation.
			 * 3. Performance: Operations like concatenation, substring extraction, and searching can be slower compared to mutable collections due to the need to create new string instances.
			 */

			string greeting = "Hello, World!"; // Since string is a collection of characters, we can iterate through each character.
			foreach (char c in greeting)
			{
				Console.WriteLine(c);
			}

			/*
			 * Lists:
			 * 1. Lists are dynamic collections that can grow and shrink in size.
			 * 2. Lists can hold elements of the same type.
			 * 3. Lists provide built-in methods for adding, removing, and searching for elements.
			 *
			 * When to use Lists:
			 * 1. When the number of elements is unknown or can change frequently.
			 * 2. When you need to frequently add or remove elements.
			 * 3. When you want to take advantage of built-in methods for common operations.
			 * 4. When you need a collection that can grow and shrink dynamically.
			 * 
			 * Limitations of Lists:
			 * 1. Performance: While lists provide dynamic sizing, operations like adding or removing elements can be slower than arrays due to potential resizing and copying of elements.
			 * 2. Memory Overhead: Lists have additional memory overhead compared to arrays due to their dynamic nature and the need to maintain additional metadata.
			 * 
			 * Performance Considerations:
			 * 1. Dynamic Sizing: Lists automatically resize when elements are added or removed, which can lead to performance overhead during these operations.
			 * 2. Access Speed: Lists provide O(1) time complexity for accessing elements by index, similar to arrays, but may have slightly higher overhead due to additional metadata.
			 *
			 */

			List<int> numberList = new List<int>(); // Declare a list of integers
			numberList.Add(10); // Add elements to the list
			numberList.Add(60);
			numberList.Add(30);
			numberList.Add(50);

			// Accessing list elements
			foreach (int number in numberList)
			{
				Console.WriteLine($"List number: {number}");
			}

			// Removing an element from the list
			numberList.Remove(20);

			Console.WriteLine("After removing 20:");
			foreach (int number in numberList)
			{
				Console.WriteLine($"List number: {number}");
			}

			// Finding an element in the list
			int foundNumber = numberList.Find(n => n == 30);
			Console.WriteLine($"Found number in list: {foundNumber}");

			// Sorting the list
			numberList.Sort();
			Console.WriteLine("Sorted list:");
			foreach (int number in numberList)
			{
				Console.WriteLine($"List number: {number}");
			}

			/*
			 * Dictionaries:
			 * 1. Dictionaries are collections of key-value pairs.
			 * 2. Each key in a dictionary must be unique.
			 * 3. Dictionaries provide fast lookups based on keys.
			 * 4. Dictionaries can hold elements of different types for keys and values.
			 * 5. Syntax to declare a dictionary: Dictionary<keyType, valueType> dictName = new Dictionary<keyType, valueType>();
			 * 
			 * When to use Dictionaries:
			 * 1. When you need to store data in key-value pairs.
			 * 2. When you need fast lookups based on keys.
			 * 3. When you need to ensure unique keys in your collection.
			 * 4. When you want to associate related data together.
			 * 
			 * Limitations of Dictionaries:
			 * 1. Memory Overhead: Dictionaries have higher memory overhead compared to other collection types due to the need to maintain key-value pairs and hashing structures.
			 * 2. Key Uniqueness: Each key in a dictionary must be unique, which can limit flexibility when duplicate keys are needed.
			 * 
			 * Performance Considerations:
			 * 1. Fast Lookups: Dictionaries provide average O(1) time complexity for lookups, insertions, and deletions based on keys, making them very efficient for these operations.
			 * 2. Memory Usage: The hashing mechanism used by dictionaries can lead to increased memory usage compared to other collection types.
			 * 3. Collision Handling: In cases where multiple keys hash to the same value, performance can degrade due to collision handling mechanisms.
			 */

			Dictionary<int, string> wordsMap = new Dictionary<int, string>(); // Declare a dictionary with int keys and string values
			wordsMap.Add(1, "One"); // Add key-value pairs to the dictionary
			wordsMap.Add(2, "Two");
			wordsMap.Add(3, "Three");

			// Accessing dictionary elements
			foreach (KeyValuePair<int, string> kvp in wordsMap)
			{
				Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
			}

			// Finding a value by key
			if (wordsMap.TryGetValue(2, out string value))
			{
				Console.WriteLine($"Value for key 2: {value}");
			}

			// Removing a key-value pair
			wordsMap.Remove(1);
			Console.WriteLine("After removing key 1:");
			foreach (KeyValuePair<int, string> kvp in wordsMap)
			{
				Console.WriteLine($"Key: {kvp.Key}, Value: {kvp.Value}");
			}
		}
	}
}
