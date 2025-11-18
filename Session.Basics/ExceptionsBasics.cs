using System;

namespace Session.Basics
{
	public class ExceptionsBasics : ITopic
	{
		public void Run()
		{
			//throw new NotImplementedException();
			MyException myException = new MyException();
			myException.MyMessage = "This is my custom exception message.";
			throw myException;
		}
	}

	public class MyException : Exception
	{
		public string MyMessage { get; set; }
	}
}
