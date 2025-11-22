namespace Calculator.App
{
	public class AdditionOperation : ICalculatorOperation
	{
		public int Do(int n1, int n2)
		{
			return n1 + n2;
		}
	}
}
