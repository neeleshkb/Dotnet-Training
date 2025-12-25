using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Todo.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class AppController : ControllerBase
	{
		private readonly IConfiguration _Configuration;
		private readonly ApplicationSettings _Value;

		public AppController(IConfiguration configuration, IOptions<ApplicationSettings> options)
		{
			_Configuration = configuration;
			_Value = options.Value;
		}

		[HttpGet("title")]
		public IActionResult GetAppTitle()
		{
			IConfigurationSection configurationSection = _Configuration.GetSection("App");
			string title = configurationSection.GetValue<string>("Title");
			return Ok(title);
		}

		[HttpGet("version")]
		public IActionResult GetAppVersion()
		{
			IConfigurationSection configurationSection = _Configuration.GetSection("App");
			float version = configurationSection.GetValue<float>("Version");
			return Ok(version);
		}

		[HttpGet("AppDetails")]
		public IActionResult GetAppSection()
		{
			ApplicationSettings app = new ApplicationSettings();
			_Configuration.GetSection("App").Bind(app);
			return Ok(app);
		}

		[HttpGet("AppDetailsUsingIOptions")]
		public IActionResult GetAppDetailsUsingIOptions()
		{
			return Ok(_Value);
		}
	}

	public class ApplicationSettings
	{
		public string Title { get; set; }
		public float Version { get; set; }
	}
}
