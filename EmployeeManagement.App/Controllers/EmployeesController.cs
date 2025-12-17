using EmployeeManagement.App.Models;
using EmployeeManagement.App.Repository;
using Microsoft.AspNetCore.Mvc;

namespace EmployeeManagement.App.Controllers
{
	public class EmployeesController : Controller
	{
		private readonly EmployeeRepository _employeeRepository;

		public EmployeesController(EmployeeRepository employeeRepository)
		{
			_employeeRepository = employeeRepository;
		}

		//private readonly EmployeeRepository _employeeRepository;
		//public EmployeesController()
		//{
		//	string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Learning;Integrated Security=True;";
		//	_employeeRepository = new EmployeeRepository(connectionString);
		//}

		public IActionResult Index()
		{
			List<EmployeeViewModel> employees = _employeeRepository.ListAllEmployees();
			return View(employees);
		}

		public IActionResult Details()
		{
			EmployeeViewModel employee = new EmployeeViewModel
			{
				Id = 1,
				FirstName = "John",
				LastName = "Doe"
			};
			return View(employee);
		}

		[HttpGet]
		public IActionResult Edit(int id)
		{
			ViewData.Add("Title", "Edit Employee");
			EmployeeViewModel employee = _employeeRepository.Get(id);
			return View(employee);
		}

		[HttpPost]
		public IActionResult Edit(EmployeeViewModel employee)
		{
			if (!ModelState.IsValid)
			{
				return View(employee);
			}

			EmployeeViewModel employee1 = _employeeRepository.Update(employee);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Create()
		{
			ViewBag.Title = "Create an Employee";
			return View(new CreateEmployeeViewModel());
		}

		[HttpPost]
		public IActionResult Create(CreateEmployeeViewModel employee)
		{
			if (!ModelState.IsValid)
			{
				return View(employee);
			}

			// DTO to Model conversion
			EmployeeViewModel emp = new EmployeeViewModel();
			emp.FirstName = employee.FirstName;
			emp.LastName = employee.LastName;

			_employeeRepository.Create(emp);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			_employeeRepository.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
