using System;

namespace Session.Basics;

public class Program
{
	static void Main(string[] args)
	{
		//ITopic builtInDataTypes = new BuiltInDatatypes();
		//builtInDataTypes.Run();

		//ITopic variablesAndOperators = new VariablesAndOperators();
		//variablesAndOperators.Run();

		//ITopic controlFLowAndLoops = new ControlFlowAndLoops();
		//controlFLowAndLoops.Run();

		//ITopic classesAndObjects = new ClassesAndObjects();
		//classesAndObjects.Run();

		//ITopic structsAndObjects = new StructsAndObjects();
		//structsAndObjects.Run();

		//ITopic valueAndReferenceTypes = new ValueAndReferenceTypes();
		//valueAndReferenceTypes.Run();

		ITopic enumerations = new Enumerations();
		enumerations.Run();

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}