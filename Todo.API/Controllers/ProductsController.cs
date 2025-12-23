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

		// Default Model binding
		// Route Data Source:
		// FromRoute,
		// FromQuery,
		// FromForm,
		// FromBody
		// FromHeader

		public ProductsController(ProductService productService)
		{
			_ProductService = productService;
		}

		[HttpGet]
		//[HttpGet("api/listallproducts")]
		//[Route("api/listallproducts")]
		public IActionResult GetAllProducts()
		{
			bool v = Request.Headers.TryGetValue("accept", out var acceptHeader);


			List<Product> products = _ProductService.GetAllProducts();
			return Ok(products);
		}

		[HttpGet("api/{category}")]
		public IActionResult FilterByCategory(string category)
		{
			return Ok(category);
		}

		[HttpGet("api")]
		public IActionResult FilterByAvailability(bool isAvailable)
		{
			return Ok(isAvailable);
		}

		[HttpGet("{id}")]
		public IActionResult GetProducts([FromRoute] int id, [FromQuery] string category)
		{
			return Ok(new { Id = id, Category = category });
		}

		[HttpPost("api/createproduct")]
		public IActionResult CreateAProduct([FromBody] ProductDto productDto)
		{
			return Ok(productDto);
		}
	}
}
