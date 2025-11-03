using System;

namespace Session.Basics;

public class Program
{
	static void Main(string[] args)
	{
		//ITopic builtInDataTypes = new BuiltInDatatypes();
		//builtInDataTypes.Run();

		ITopic variablesAndOperators = new VariablesAndOperators();
		variablesAndOperators.Run();

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}