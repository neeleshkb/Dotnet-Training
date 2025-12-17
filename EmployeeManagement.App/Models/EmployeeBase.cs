using System.ComponentModel.DataAnnotations;

namespace EmployeeManagement.App.Models
{
	public class EmployeeBase
	{
		[Required]
		[StringLength(6)]
		public string FirstName { get; set; }

		[Required]
		[StringLength(6)]
		public string LastName { get; set; }
	}
}
