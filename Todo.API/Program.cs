using Todo.API.Controllers;
using Todo.API.Filters;
using Todo.API.Middlewares;
using Todo.API.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Logging.ClearProviders();
builder.Logging.AddSimpleConsole();
//builder.Logging.AddSystemdConsole();
//builder.Logging.AddJsonConsole();
// Add services to the container.

builder.Services.AddControllers(options =>
{
	options.Filters.Add<ProcessTimeFilter>();
});
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<ProductService>();

IConfigurationSection configurationSection = builder.Configuration.GetSection("App");
builder.Services.Configure<ApplicationSettings>(configurationSection);

builder.Services.AddExceptionHandler<GlobalExceptionHandler>();
builder.Services.AddProblemDetails();

var app = builder.Build();

//app.UseMiddleware<ExceptionMiddleware>();
app.UseExceptionHandler();

app.Use(async (context, next) =>
{
	var logger = app.Services.GetRequiredService<ILogger<Program>>();
	logger.LogInformation("Handling request: " + context.Request.Method + " " + context.Request.Path);

	await next(context);

	logger.LogInformation("Finished handling request.");
});

if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}



app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
