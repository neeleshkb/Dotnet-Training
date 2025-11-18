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

		//ITopic enumerations = new Enumerations();
		//enumerations.Run();

		//ITopic interfacesBasics = new InterfacesBasics();
		//interfacesBasics.Run();

		//ITopic constantsAndStaticMembers = new ConstantsAndStaticMembers();
		//constantsAndStaticMembers.Run();

		//Generics generics = new Generics();
		//generics.Run();

		//ITopic collectionsPart1 = new CollectionsPart1();
		//collectionsPart1.Run();

		//ITopic collectionsPart2 = new CollectionsPart2();
		//collectionsPart2.Run();

		//ITopic functionPointerDelegate = new FunctionPointerDelegate();
		//functionPointerDelegate.Run();

		//ITopic oops = new Oops();
		//oops.Run();

		ITopic exceptionsBasics = new ExceptionsBasics();

		try
		{
			exceptionsBasics.Run();
		}
		catch (NotImplementedException nie)
		{
			Console.WriteLine("Caught NotImplementedException:");
			Console.WriteLine(nie.Message);
			Console.WriteLine(nie.StackTrace);
		}
		catch (Exception e)
		{
			Console.WriteLine($"Exception caught: {e.Message}");
			Console.WriteLine(e.Message);
			Console.WriteLine(e.StackTrace);
		}
		finally
		{
			// Resource cleanup code can go here	
		}

		Console.WriteLine("Press any key to exit...");
		Console.ReadKey();
	}
}