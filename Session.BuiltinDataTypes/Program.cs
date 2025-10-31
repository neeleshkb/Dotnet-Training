using System;

namespace Session.BuiltinDataTypes;

public class Program
{
	static void Main(string[] args)
	{
		// Datatypes

		// Strings and Characters
		string myString = "Hello, World!";
		char myChar = 'A';
		Console.WriteLine(myString);
		Console.WriteLine($"Character: {myChar}");

		// Signed Integer types (without decimals)
		int myInt = 10; // 32-bit integer, Range: -2,147,483,648 to 2,147,483,647
		long myLong = 10000000000; // 64-bit integer, Range: -9,223,372,036,854,775,808 to 9,223,372,036,854,775,807
		short myShort = 30000; // 16-bit integer, Range: -32,768 to 32,767
		byte myByte = 255; // 8-bit unsigned integer, Range: 0 to 255
		Console.WriteLine($"Integer: {myInt}, Long: {myLong}, Short: {myShort}, Byte: {myByte}");

		// Unsigned Integer types can also be used
		uint myUInt = 20; // 32-bit unsigned integer, Range: 0 to 4,294,967,295
		ulong myULong = 20000000000; // 64-bit unsigned integer, Range: 0 to 18,446,744,073,709,551,615
		ushort myUShort = 60000; // 16-bit unsigned integer, Range: 0 to 65,535
		sbyte mySByte = 100; // 8-bit signed integer, Range: -128 to 127
		Console.WriteLine($"Unsigned Integer: {myUInt}, Unsigned Long: {myULong}, Unsigned Short: {myUShort}, Signed Byte: {mySByte}");

		// Signed Floating-point types
		float myFloat = 10.5f;
		double myDouble = 20.99;
		decimal myDecimal = 30.99m;
		Console.WriteLine($"Float: {myFloat}, Double: {myDouble}, Decimal: {myDecimal}");

		// Boolean type
		bool myBool = true;
		Console.WriteLine($"Boolean: {myBool}");
	}
}