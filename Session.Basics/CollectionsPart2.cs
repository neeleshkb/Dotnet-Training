using System;
using System.Collections.Generic;

namespace Session.Basics
{
	public class CollectionsPart2 : ITopic
	{
		public void Run()
		{
			/*
			 * Stacks
			 * 1. A stack is a collection that follows the Last In First Out (LIFO) principle.
			 * 2. Elements can only be added or removed from the top of the stack.
			 * 3. Common operations: Push (add an element), Pop (remove the top element), Peek (view the top element without removing it).
			 * 4. Stacks are useful for scenarios like function call management, expression evaluation, and backtracking algorithms.
			 *
			 * When to use Stacks:
			 * 1. When you need to reverse the order of elements.
			 * 2. When implementing algorithms that require backtracking.
			 * 3. When managing function calls and recursion.
			 * 
			 * Limitations of Stacks:
			 * 1. Limited Access: You can only access the top element, which may not be suitable for all scenarios.
			 * 2. Fixed Size (if using array-based stacks): If the stack is implemented using an array, it has a fixed size, which can lead to overflow if not managed properly.
			 * 
			 * Performance Considerations:
			 * 1. Push and Pop operations are O(1), making stacks very efficient for adding and removing elements.
			 * 2. Memory Usage: Stacks can be memory efficient, but care must be taken to avoid stack overflow in recursive scenarios.
			 */

			Stack<int> stack = new Stack<int>();
			// Adding elements to the stack using Push method
			stack.Push(10);
			stack.Push(20);
			stack.Push(30);

			// Removing elements from the stack using Pop method
			int v = stack.Pop(); // Removes 30
			Console.WriteLine($"Popped element: {v}");

			// Viewing the top element using Peek method
			int topElement = stack.Peek(); // topElement is 20
			Console.WriteLine($"Top element: {topElement}");


			/*
			 * Queues
			 * 1. A queue is a collection that follows the First In First Out (FIFO) principle.
			 * 2. Elements are added at the end (enqueue) and removed from the front (dequeue).
			 * 3. Common operations: Enqueue (add an element), Dequeue (remove the front element), Peek (view the front element without removing it).
			 * 4. Queues are useful for scenarios like task scheduling, breadth-first search algorithms, and buffering data.
			 * 
			 * When to use Queues:
			 * 1. When you need to maintain the order of elements.
			 * 2. When implementing task scheduling or processing systems.
			 * 3. When managing data streams or buffers.
			 * 
			 * Limitations of Queues:
			 * 1. Limited Access: You can only access the front element, which may not be suitable for all scenarios.
			 * 2. Fixed Size (if using array-based queues): If the queue is implemented using an array, it has a fixed size, which can lead to overflow if not managed properly.
			 * 
			 * Performance Considerations:
			 * 1. Enqueue and Dequeue operations are O(1), making queues very efficient for adding and removing elements.
			 * 2. Memory Usage: Queues can be memory efficient, but care must be taken to avoid overflow in high-throughput scenarios.
			 */

			Queue<int> queue = new Queue<int>();

			// Adding elements to the queue using Enqueue method
			queue.Enqueue(10);
			queue.Enqueue(20);
			queue.Enqueue(30);

			// Removing elements from the queue using Dequeue method
			int dequeuedValue = queue.Dequeue(); // Removes 10
			Console.WriteLine($"Dequeued element: {dequeuedValue}");

			// Viewing the front element using Peek method
			int frontElement = queue.Peek(); // frontElement is 20
			Console.WriteLine($"Front element: {frontElement}");
		}
	}
}
