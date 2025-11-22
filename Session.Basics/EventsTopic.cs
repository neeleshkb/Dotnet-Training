using System;

namespace Session.Basics
{
	public delegate void OnClick(object sender, string eventArgs);

	public class EventsTopic : ITopic
	{
		public event OnClick eventName;
		public void Run()
		{
			//EventSubscriber subscriber = new EventSubscriber();
			//eventName += subscriber.EventReceived;
			//// eventName -= subscriber.EventReceived;

			//eventName(this, "I am from eventstopic class");

			Button button = new Button();
			VisualStudio visualStudio = new VisualStudio();
			button.Click += visualStudio.Launch;
			button.ClickButton();
		}
	}

	public class EventSubscriber
	{
		public void EventReceived(object sender, string eventArgs)
		{
			Console.WriteLine(eventArgs);
		}
	}

	public class VisualStudio
	{
		public void Launch(object? sender, EventArgs e)
		{
			ProjectNameArgs args = e as ProjectNameArgs;
			Console.WriteLine($"Launching project: {args?.ProjectName}");
		}
	}

	public class Button
	{
		public event EventHandler Click;

		public void ClickButton()
		{
			ProjectNameArgs projectNameArgs = new ProjectNameArgs();
			projectNameArgs.ProjectName = "MyProject";

			Click(this, projectNameArgs);
		}
	}

	public class ProjectNameArgs : EventArgs
	{
		public string ProjectName { get; set; }
	}
}
