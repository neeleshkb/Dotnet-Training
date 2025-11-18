using System;

namespace Session.Basics
{
	public class Oops : ITopic
	{
		public void Run()
		{
			// OOPS: Object-Oriented Programming System
			// It is a programming paradigm that uses "objects" to design software.

			// The main principles of OOPS are:
			// 1. Enpasulation: The idea of bundling data and methods that operate on that data within a single unit or class.
			// 2. Abstraction: The concept of hiding the complex implementation details and showing only the essential features of the object.
			// 3. Inheritance: The mechanism by which one class can inherit properties and methods from another class, promoting code reusability.
			// 4. Polymorphism: The ability of different classes to be treated as instances of the same class through a common interface,
			//	  allowing for methods to behave differently based on the object that invokes them.

			// Access Modifiers in C#:
			// 1. Public: The member is accessible from any other code.
			// 2. Private: The member is accessible only within the body of the class or struct in which it is declared.
			// 3. Protected: The member is accessible within its class and by derived class instances.
			// 4. Internal: The member is accessible only within files in the same assembly.
			// 5. Protected Internal: The member is accessible within its class, derived classes, and any code in the same assembly.

			SavingsAccount john = new SavingsAccount(100, 1000);
			//john.GetAccountNumber();
			//john.Deposit(500);
			//john.Withdraw(200);
			Console.WriteLine($"Account Number: {john.GetAccountNumber()}, Balance: {john.GetBalance()}");

			BankService cashier = new BankService();
			cashier.Deposit(john, 300);

			Console.WriteLine($"Account Number: {john.GetAccountNumber()}, Balance: {john.GetBalance()}");

			CurrentAccount jane = new CurrentAccount(200, 2000);
			cashier.Deposit(jane, 500);
			Console.WriteLine($"Account Number: {jane.GetAccountNumber()}, Balance: {jane.GetBalance()}");

			cashier.Withdraw(john, 100);
			Console.WriteLine($"Account Number: {john.GetAccountNumber()}, Balance: {john.GetBalance()}");

			cashier.Withdraw(jane, 2500);
			Console.WriteLine($"Account Number: {jane.GetAccountNumber()}, Balance: {jane.GetBalance()}");

			//StringConcat();

			int increment = Calculator.Add(1);
			int convertFromString = Calculator.Add("10");
			int add = Calculator.Add(5, 10);
		}

		private static void StringConcat()
		{
			string val1 = "Hello";
			string val2 = "World";

			string val3 = val1 + val2;
			Console.WriteLine(val3);

			string val4 = string.Concat(val1, val2);
			Console.WriteLine(val4);

			string val5 = string.Join(",", val1, val2, "John");
			Console.WriteLine(val5);

			int age = 30;
			// String Interpolation
			string val6 = $"John {val1}, {val2} {age}";
			Console.WriteLine(val6);
		}
	}

	public interface IBankAccount
	{
		int GetAccountNumber();
		float GetBalance();
		void Deposit(float amount);
		void Withdraw(float amount);
	}

	public abstract class BankAccount : IBankAccount
	{
		protected int accountNumber;   // Camel Case
		protected float balance;

		// Base/Parent class constructor
		public BankAccount(int accountNumber, float balance)
		{
			this.accountNumber = accountNumber;
			this.balance = balance;
		}

		public int GetAccountNumber()  // Pascal Case
		{
			return accountNumber;
		}

		public float GetBalance()
		{
			return balance;
		}

		public virtual void Deposit(float amount)  // Dynamic Polymorphism - Method Overriding
		{
			if (amount > 0)
			{
				this.balance += amount;
			}
		}

		public abstract void Withdraw(float amount);
	}

	public class SavingsAccount : BankAccount
	{
		// Derived/Child class constructor
		public SavingsAccount(int accountNumber, float balance)
			: base(accountNumber, balance)
		{
		}

		//public override void Deposit(float amount)
		//{
		//	if (amount > 0)
		//	{
		//		this.balance += amount;
		//	}
		//}

		public override void Withdraw(float amount)
		{
			if (amount > 0 && amount <= balance)
			{
				this.balance -= amount;
			}
		}
	}

	public class CurrentAccount : BankAccount
	{
		private const float overdraftLimit = 500;
		private bool isActivated = false;

		// Derived/Child class constructor
		public CurrentAccount(int accountNumber, float balance)
			: base(accountNumber, balance)
		{
		}

		//public override void Deposit(float amount) // Dynamic Polymorphism - Method Overriding
		//{
		//	if (amount > 0)
		//	{
		//		this.balance += amount;
		//	}
		//}

		public override void Deposit(float amount)
		{
			if (isActivated)
			{
				base.Deposit(amount); // Calling base class method
			}
			else
			{
				throw new InvalidOperationException("Account is not activated.");
			}
		}

		public override void Withdraw(float amount)  // Dynamic Polymorphism - Method Overriding
		{
			if (amount > 0 && amount <= (balance + overdraftLimit))
			{
				this.balance -= amount;
			}
		}
	}

	public class BankService
	{
		public void Withdraw(IBankAccount account, float amount)
		{
			account.Withdraw(amount);
		}

		public void Deposit(IBankAccount account, float amount)
		{
			account.Deposit(amount);
		}

		//public void WithdrawFromSavings(SavingsAccount account, float amount)
		//{
		//	account.Withdraw(amount);
		//}

		//public void DepositToSavings(SavingsAccount account, float amount)
		//{
		//	account.Deposit(amount);
		//}

		//public void WithdrawFromCurrent(CurrentAccount account, float amount)
		//{
		//	account.Withdraw(amount);
		//}

		//public void DepositToCurrent(CurrentAccount account, float amount)
		//{
		//	account.Deposit(amount);
		//}
	}

	public class Calculator
	{
		// Static Polymorphism - Method Overloading
		// Same method name with different number of parameters
		// Same method name with different data types
		public static int Add(int number)
		{
			return number + 1;
		}

		public static int Add(string n1)
		{
			return int.Parse(n1);
		}

		public static int Add(int n1, int n2)
		{
			return n1 + n2;
		}
	}
}
