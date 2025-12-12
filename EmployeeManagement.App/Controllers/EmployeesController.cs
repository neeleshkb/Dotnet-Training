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
			List<Employee> employees = _employeeRepository.ListAllEmployees();
			return View(employees);
		}

		public IActionResult Details()
		{
			Employee employee = new Employee
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
			Employee employee = _employeeRepository.Get(id);
			return View(employee);
		}

		[HttpPost]
		public IActionResult Edit(Employee employee)
		{
			Employee employee1 = _employeeRepository.Update(employee);
			return RedirectToAction("Index");
		}

		[HttpGet]
		public IActionResult Create()
		{
			return View();
		}

		[HttpPost]
		public IActionResult Create(Employee employee)
		{
			_employeeRepository.Create(employee);
			return RedirectToAction("Index");
		}

		public IActionResult Delete(int id)
		{
			_employeeRepository.Delete(id);
			return RedirectToAction("Index");
		}
	}
}
