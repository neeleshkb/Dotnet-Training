
using Calculator.App;

Operations[] supportedOperations = Enum.GetValues<Operations>();

//Operations add = supportedOperations[0];

//// Type casting
//int[] operationNumbers = new int[supportedOperations.Length];
//for (int index = 0; index < supportedOperations.Length; index++)
//{
//	operationNumbers[index] = (int)supportedOperations[index];
//}

Dictionary<Operations, int> operationMap = new Dictionary<Operations, int>();
for (int index = 0; index < supportedOperations.Length; index++)
{
	operationMap.Add(supportedOperations[index], (int)supportedOperations[index]);
}

Dictionary<ConsoleKey, ICalculatorOperation> calculatorOperationsMap = new Dictionary<ConsoleKey, ICalculatorOperation>();

ICalculatorOperation add = new AdditionOperation();

calculatorOperationsMap.Add(ConsoleKey.NumPad1, add);
calculatorOperationsMap.Add(ConsoleKey.NumPad2, new SubstractOperation());
calculatorOperationsMap.Add(ConsoleKey.NumPad3, new MultipleOperation());
calculatorOperationsMap.Add(ConsoleKey.NumPad4, new RemainderOperation());

ConsoleKey key;
do
{
	Console.WriteLine();

	foreach (KeyValuePair<Operations, int> kp in operationMap)
	{
		string message = "Press " + kp.Value + " for " + kp.Key;
		Console.WriteLine(message);
	}

	ConsoleKeyInfo operation = Console.ReadKey();
	ConsoleKey userKey = operation.Key;

	bool keyFound = calculatorOperationsMap.TryGetValue(userKey, out ICalculatorOperation calculatorOperation);

	if (keyFound)
	{
		try
		{
			Console.WriteLine("Enter two numbers");
			TwoNumbers twoNumbers = ReadTwoNumbers();
			var result = calculatorOperation.Do(twoNumbers.n1, twoNumbers.n2);
			Console.WriteLine(result);
		}
		catch (FormatException)
		{
			Console.WriteLine("Invalid format of numbers");
		}
	}
	else
	{
		Console.WriteLine("Invalid key");
	}

	#region Old code

	//if (operation.Key == ConsoleKey.NumPad1)
	//{
	//	Console.WriteLine("Enter two numbers:");
	//	AdditionOperation additionOperation = new AdditionOperation();
	//	TwoNumbers twoNumbers = ReadTwoNumbers();

	//	int result = additionOperation.Do(twoNumbers.n1, twoNumbers.n2);
	//	Console.WriteLine($"Addition of {twoNumbers.n1} + {twoNumbers.n2} = {result}");

	//}
	//else if (operation.Key == ConsoleKey.NumPad2)
	//{
	//	Console.WriteLine("Enter two numbers:");

	//	TwoNumbers twoNumbers = ReadTwoNumbers();
	//	SubstractOperation substractOperation = new SubstractOperation();
	//	int result = substractOperation.Do(twoNumbers.n1, twoNumbers.n2);
	//	Console.WriteLine($"Substraction of {twoNumbers.n1} - {twoNumbers.n2} = {result}");
	//}
	//else if (operation.Key == ConsoleKey.NumPad3)
	//{
	//	Console.WriteLine("Enter two numbers:");
	//	TwoNumbers twoNumbers = ReadTwoNumbers();
	//	MultipleOperation multipleOperation = new MultipleOperation();
	//	int result = multipleOperation.Do(twoNumbers.n1, twoNumbers.n2);
	//	Console.WriteLine($"Multiplication of {twoNumbers.n1} * {twoNumbers.n2} = {result}");
	//}
	//else
	//{
	//	Console.WriteLine("Select a valid option");
	//}
	#endregion

	Console.WriteLine("Press e for exit or any other key to continue.");
	ConsoleKeyInfo keyinfo = Console.ReadKey();
	key = keyinfo.Key;
	Console.Clear();

} while (key != ConsoleKey.E);

Console.WriteLine("Closing the app");



static int ReadInput()
{
	string number1 = Console.ReadLine();
	int n1 = int.Parse(number1);

	return n1;
}

static TwoNumbers ReadTwoNumbers()
{
	//string number1 = Console.ReadLine();
	//string number2 = Console.ReadLine();

	//int n1 = int.Parse(number1);
	//int n2 = int.Parse(number2);

	//TwoNumbers twoNumbers = new();
	//twoNumbers.n1 = n1;
	//twoNumbers.n2 = n2;
	//return twoNumbers;

	TwoNumbers twoNumbers = new();
	twoNumbers.n1 = ReadInput();
	twoNumbers.n2 = ReadInput();
	return twoNumbers;
}

static bool TryGetValue(string key, out int value)
{
	if (key == "1")
	{
		value = 1;
		return true;
	}
	value = 0;
	return false;
}

struct TwoNumbers
{
	public int n1;
	public int n2;
}

