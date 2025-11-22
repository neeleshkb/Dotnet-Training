namespace Calculator.App
{
	public class RemainderOperation : ICalculatorOperation
	{
		public int Do(int n1, int n2)
		{
			return n1 % n2;
		}
	}
}
