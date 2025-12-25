namespace Todo.API.Middlewares
{
	public class ExceptionMiddleware
	{
		private readonly RequestDelegate _Next;
		private readonly ILogger<ExceptionMiddleware> _Logger;

		public ExceptionMiddleware(RequestDelegate next, ILogger<ExceptionMiddleware> logger)
		{
			_Next = next;
			_Logger = logger;
		}

		public async Task InvokeAsync(HttpContext context)
		{
			try
			{
				await _Next(context);
			}
			catch (Exception ex)
			{
				_Logger.LogError(ex, "Unhandled error occured");
				context.Response.StatusCode = StatusCodes.Status500InternalServerError;
				await context.Response.WriteAsJsonAsync(new { Message = ex.Message });
			}
		}
	}
}
