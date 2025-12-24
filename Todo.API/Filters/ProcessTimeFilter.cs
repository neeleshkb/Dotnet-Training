using Microsoft.AspNetCore.Mvc.Filters;
using System.Diagnostics;

namespace Todo.API.Filters
{
	public class ProcessTimeFilter : IActionFilter
	{
		// Different types of filters in ASP.NET Core
		// 1. Authorization Filters
		// 2. Resource Filters
		// 3. Action Filters
		// 4. Exception Filters
		// 5. Result Filters

		private readonly ILogger<ProcessTimeFilter> _Logger;
		private readonly Stopwatch _Stopwatch = new Stopwatch();
		public ProcessTimeFilter(ILogger<ProcessTimeFilter> logger)
		{
			_Logger = logger;
		}

		public void OnActionExecuting(ActionExecutingContext context)
		{
			_Stopwatch.Start();
			string controllerName = context.Controller.ToString();
			string displayName = context.ActionDescriptor.DisplayName;
			_Logger.LogInformation($"{controllerName} - {displayName} started executing");
		}

		public void OnActionExecuted(ActionExecutedContext context)
		{
			string controllerName = context.Controller.ToString();
			string displayName = context.ActionDescriptor.DisplayName;
			_Logger.LogInformation($"{controllerName} - {displayName} action executed");
			_Stopwatch.Stop();
			_Logger.LogInformation($"{controllerName} - {displayName} executed in {_Stopwatch.ElapsedMilliseconds} ms");
		}
	}
}
