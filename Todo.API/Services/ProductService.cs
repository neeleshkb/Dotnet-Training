namespace Todo.API.Services
{
	public class ProductService
	{
		static List<Product> _Products = new List<Product>()
		{
			new Product
			{
				Id = 1,
				Name = "Eggs",
				Description = "Eggs good for healthy",
				Category = Category.Food,
				IsAvailable = true,
			},
			new Product {
				Id = 2,
				Name = "Milk",
				Description = "Fresh milk",
				Category = Category.Beverages,
				IsAvailable = true
			},
			new Product {
				Id = 3,
				Name = "Bread",
				Description = "Whole grain bread",
				Category = Category.Food,
				IsAvailable = true
			},
			new Product {
				Id = 4,
				Name = "Juice",
				Description = "Orange juice",
				Category = Category.Beverages,
				IsAvailable = false
			}
		};

		public List<Product> GetAllProducts()
		{
			return _Products;
		}

	}
	public class Product
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		public Category Category { get; set; }
		public bool IsAvailable { get; set; }
	}

	public enum Category
	{
		Food,
		Beverages
	}
}
