using Microsoft.AspNetCore.Diagnostics;

namespace Todo.API.Middlewares
{
	public class GlobalExceptionHandler : IExceptionHandler
	{
		private readonly ILogger<GlobalExceptionHandler> _Logger;

		public GlobalExceptionHandler(ILogger<GlobalExceptionHandler> logger)
		{
			_Logger = logger;
		}

		public ValueTask<bool> TryHandleAsync(HttpContext httpContext, Exception exception, CancellationToken cancellationToken)
		{
			if (exception is InvalidDataException)
			{
				_Logger.LogError(exception, "A bad request error occurred: {Message}", exception.Message);
				httpContext.Response.StatusCode = StatusCodes.Status400BadRequest;
				return new ValueTask<bool>(false);
			}

			_Logger.LogError(exception, "An error occurred: {Message}", exception.Message);
			httpContext.Response.StatusCode = StatusCodes.Status500InternalServerError;
			return new ValueTask<bool>(true);
		}
	}
}
