using Microsoft.AspNetCore.Mvc;
using Todo.API.Dtos;
using Todo.API.Services;

namespace Todo.API.Controllers
{
	[ApiController]
	[Route("Products")]
	public class ProductsController : ControllerBase
	{
		private readonly ProductService _ProductService;
		private readonly ILogger<ProductsController> _Logger;

		// Default Model binding
		// Route Data Source:
		// FromRoute,
		// FromQuery,
		// FromForm,
		// FromBody
		// FromHeader

		public ProductsController(ProductService productService, ILogger<ProductsController> logger)
		{
			_ProductService = productService;
			_Logger = logger;
		}

		[HttpGet]
		//[HttpGet("api/listallproducts")]
		//[Route("api/listallproducts")]
		public IActionResult GetAllProducts()
		{
			_Logger.LogInformation("Getting all products");
			Thread.Sleep(100);
			bool v = Request.Headers.TryGetValue("accept", out var acceptHeader);
			List<Product> products = _ProductService.GetAllProducts();
			return Ok(products);
		}

		[HttpGet("api/{category}")]
		public IActionResult FilterByCategory(string category)
		{
			_Logger.LogInformation($"Filtering by category: {category}");
			return Ok(category);
		}

		[HttpGet("api")]
		public IActionResult FilterByAvailability(bool isAvailable)
		{
			_Logger.LogInformation($"Filtering by availability: {isAvailable}");
			return Ok(isAvailable);
		}

		[HttpGet("{id}")]
		public IActionResult GetProducts([FromRoute] int id, [FromQuery] string category)
		{
			_Logger.LogInformation($"Getting product with ID: {id} and Category: {category}");
			return Ok(new { Id = id, Category = category });
		}

		[HttpPost("api/createproduct")]
		public IActionResult CreateAProduct([FromBody] ProductDto productDto)
		{
			return Ok(productDto);
		}
	}
}
