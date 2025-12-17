using Microsoft.AspNetCore.Mvc;
using Todo.API.Dtos;

namespace Todo.API.Controllers
{
	[Route("Todo")]
	public class TodoController : ControllerBase
	{
		//https://blog.postman.com/what-are-http-status-codes/
		static List<TodoItem> Items = new List<TodoItem>()
		{
			new TodoItem { Id=1, Description = "Learn C#" },
			new TodoItem { Id=2, Description = "Learn ASP.NET Core" },
			new TodoItem { Id=3, Description = "Build Web API" }
		};

		[HttpGet]
		public IActionResult ListAllTodoItems()
		{
			return Ok(Items);
		}

		[HttpPost]
		public IActionResult AddTodoItem(CreateTodoItemRequest item)
		{
			Items.Add(new TodoItem { Description = item.Description });
			return Created("Todo", item);
		}

		[HttpPut]
		public IActionResult UpdateAnToItem(EditTodoItem editTodoItem)
		{
			TodoItem todoItem = Items.FirstOrDefault(item => item.Id == editTodoItem.Id);
			if (todoItem == null)
			{
				return NotFound();
			}

			todoItem.Description = editTodoItem.Description;
			return Ok(todoItem);
		}

		[HttpDelete("{id}")]
		public IActionResult DeleteAnTodoItem(int id)
		{
			TodoItem todoItem = Items.FirstOrDefault(item => item.Id == id);
			if (todoItem == null)
			{
				return NotFound();
			}
			Items.Remove(todoItem);
			return NoContent();
		}
	}
}
