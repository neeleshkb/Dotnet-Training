using Microsoft.Data.Sqlite;

namespace Adonet.Sessions
{
	public class DataStore
	{
		const string connectionString = "Data Source = demo-db.db";

		public void ReadFromDatabase()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();
			Console.WriteLine("Database connection opened successfully.");

			using SqliteCommand command = new SqliteCommand();
			command.Connection = connection;
			command.CommandText = "Select * from Students; Select * from Courses;";

			using SqliteDataReader reader = command.ExecuteReader();

			bool areWeInCourses = false;
			do
			{
				while (reader.Read())
				{
					if (areWeInCourses)
					{
						int courseNameIndex = reader.GetOrdinal("CourseName");
						int creditsIndex = reader.GetOrdinal("Credits");

						string courseName = reader.GetString(courseNameIndex);
						string credits = reader.GetString(creditsIndex);
						Console.WriteLine($"From courses {courseName} {credits}");
					}
					else
					{
						int lastnameIndex = reader.GetOrdinal("lastname");
						int firstnameIndex = reader.GetOrdinal("firstname");

						string lastname = reader.GetString(lastnameIndex);
						string firstName = reader.GetString(firstnameIndex);
						Console.WriteLine($"From students FullName : {firstName} {lastname}");
					}
				}

				areWeInCourses = reader.NextResult();
			}
			while (areWeInCourses);
		}

		public void UpdateTableData()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			using SqliteCommand command = connection.CreateCommand();
			//command.Connection = connection;
			command.CommandText = "select StudentId from students where FirstName='John' and LastName='Doe'";

			using SqliteDataReader reader = command.ExecuteReader();
			reader.Read();
			int sidIndex = reader.GetOrdinal("StudentId");
			int sid = reader.GetInt32(sidIndex);
			Console.WriteLine($"Student id {sid}");

			reader.Close();
			command.Dispose();

			using SqliteCommand emailCommand = connection.CreateCommand();
			emailCommand.CommandText = "Update students set Email = 'john.doe@gmail.com' where studentId=" + sid;
			int numberOfRowsAffected = emailCommand.ExecuteNonQuery();
			emailCommand.Dispose();
			Console.WriteLine("Updated the students email");
		}

		public void SqlInjection()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			using SqliteCommand command = connection.CreateCommand();

			// Sql Injection
			string Did = "2; Drop table Department;";
			command.CommandText = "Update Department set DName = 'Math' where Id= " + Did;
			command.ExecuteNonQuery();
			Console.WriteLine("Injected successfully");
		}
	}
}
