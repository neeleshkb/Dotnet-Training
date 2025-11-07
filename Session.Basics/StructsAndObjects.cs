using System;

namespace Session.Basics
{
	public class StructsAndObjects : ITopic
	{
		public void Run()
		{
			/*
			 * Structs are value types and are typically used to represent
			 * simple data structures that contain related data.
			 */
			Point pointA = new Point(10, 20);

			/*
			 * Members of the struct can be accessed using the dot operator.
			 */
			pointA.X = 15;
			pointA.Y = 25;
			Console.WriteLine($"Point A: X = {pointA.X}, Y = {pointA.Y}");
			pointA.SetX(30);
			pointA.SetY(40);
			Console.WriteLine($"Point A: X = {pointA.GetX()}, Y = {pointA.GetY()}");
		}
	}
}
