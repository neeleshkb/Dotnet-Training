using EmployeeManagement.App.Models;
using Microsoft.Data.SqlClient;

namespace EmployeeManagement.App.Repository
{
	public class EmployeeRepository
	{
		private readonly string _ConnectionString;

		public EmployeeRepository(string connectionString)
		{
			_ConnectionString = connectionString;
		}

		public List<EmployeeViewModel> ListAllEmployees()
		{
			List<EmployeeViewModel> employees = new List<EmployeeViewModel>();
			using SqlConnection connection = new SqlConnection(_ConnectionString);
			connection.Open();

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Employees";

			using SqlDataReader reader = command.ExecuteReader();
			while (reader.Read())
			{
				int idIndex = reader.GetOrdinal("Id");
				int id = reader.GetInt32(idIndex);

				int firstNameIndex = reader.GetOrdinal("FirstName");
				string firstName = reader.GetString(firstNameIndex);

				int lastNameIndex = reader.GetOrdinal("LastName");
				string lastName = reader.GetString(lastNameIndex);

				EmployeeViewModel employee = new EmployeeViewModel
				{
					Id = id,
					FirstName = firstName,
					LastName = lastName
				};
				employees.Add(employee);
			}
			return employees;
		}

		public EmployeeViewModel Create(EmployeeViewModel employee)
		{
			using SqlConnection connection = new SqlConnection(_ConnectionString);
			connection.Open();

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "INSERT INTO Employees (FirstName, LastName) OUTPUT INSERTED.Id VALUES (@firstName, @lastName)";

			//SqlParameter firstNameParam = new SqlParameter("@firstName", System.Data.SqlDbType.NVarChar, 50);

			command.Parameters.AddWithValue("@firstName", employee.FirstName);
			command.Parameters.AddWithValue("@lastName", employee.LastName);

			int insertedId = (int)command.ExecuteScalar();

			employee.Id = insertedId;
			return employee;
		}

		public EmployeeViewModel Update(EmployeeViewModel employee)
		{
			using SqlConnection connection = new SqlConnection(_ConnectionString);
			connection.Open();

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "UPDATE Employees SET FirstName = @firstName, LastName = @lastName WHERE Id = @id";

			command.Parameters.AddWithValue("@firstName", employee.FirstName);
			command.Parameters.AddWithValue("@lastName", employee.LastName);
			command.Parameters.AddWithValue("@id", employee.Id);

			command.ExecuteNonQuery();
			return employee;
		}

		public void Delete(int id)
		{
			using SqlConnection connection = new SqlConnection(_ConnectionString);
			connection.Open();
			SqlCommand command = connection.CreateCommand();
			command.CommandText = "DELETE FROM Employees WHERE Id = @id";
			command.Parameters.AddWithValue("@id", id);
			command.ExecuteNonQuery();
		}

		public EmployeeViewModel Get(int id)
		{
			using SqlConnection connection = new SqlConnection(_ConnectionString);
			connection.Open();

			SqlCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Employees WHERE Id = @id";

			command.Parameters.AddWithValue("@id", id);

			using SqlDataReader reader = command.ExecuteReader();
			if (reader.Read())
			{
				int idIndex = reader.GetOrdinal("Id");
				int empId = reader.GetInt32(idIndex);
				int firstNameIndex = reader.GetOrdinal("FirstName");
				string firstName = reader.GetString(firstNameIndex);
				int lastNameIndex = reader.GetOrdinal("LastName");
				string lastName = reader.GetString(lastNameIndex);
				EmployeeViewModel employee = new EmployeeViewModel
				{
					Id = empId,
					FirstName = firstName,
					LastName = lastName
				};
				return employee;
			}
			return null;
		}
	}
}
