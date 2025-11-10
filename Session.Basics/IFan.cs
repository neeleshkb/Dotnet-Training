namespace Session.Basics
{
	public interface IFan
	{
		string Color { get; set; }
		void TurnOn();
		void TurnOff();
	}
}
