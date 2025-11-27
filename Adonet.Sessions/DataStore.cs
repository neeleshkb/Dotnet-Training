using Adonet.Sessions.Entities;
using Microsoft.Data.Sqlite;

namespace Adonet.Sessions
{
	public class DataStore
	{
		private readonly string connectionString;

		public DataStore(string connectionString)
		{
			this.connectionString = connectionString;
		}

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

			//reader.Close();
			//command.Dispose();

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

			// Sql Injection
			string departId = "2; Drop table Department;";
			departId = "2"; // to avoid actual injection for demo purpose
			using SqliteCommand command = connection.CreateCommand();
			SqliteParameter idParameter = new SqliteParameter();
			idParameter.ParameterName = "@Id";
			idParameter.Value = departId;

			command.CommandText = "Update Department set DName = 'Math' where Id= @Id";
			command.Parameters.Add(idParameter);
			//command.CommandText = "Update Department set DName = 'Math' where Id= " + Did;
			command.ExecuteNonQuery();
			Console.WriteLine("Injected successfully");
		}

		public void DeleteFromDatabase()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			SqliteCommand command = connection.CreateCommand();
			command.CommandText = "Delete from department where Id = @id";

			SqliteParameter idParameter = new SqliteParameter();
			idParameter.ParameterName = "@id";
			idParameter.Value = 2;
			idParameter.DbType = System.Data.DbType.Int32;

			command.Parameters.Add(idParameter);

			int rowsAffected = command.ExecuteNonQuery();
			Console.WriteLine($"Rows affected: {rowsAffected}");
		}

		public void InsertIntoDatabase()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			SqliteCommand command = connection.CreateCommand();
			command.CommandText = "INSERT into Department (dname) values (@dname)";

			SqliteParameter paramDname = new SqliteParameter();
			paramDname.ParameterName = "@dname";
			paramDname.Value = "Chemistry";

			command.Parameters.Add(paramDname);

			int rowsAffected = command.ExecuteNonQuery();
			Console.WriteLine($"Rows affected: {rowsAffected}");
		}

		public void Materialization()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			SqliteCommand command = connection.CreateCommand();
			command.CommandText = "SELECT * FROM Students";

			SqliteDataReader sqliteDataReader = command.ExecuteReader();
			List<Student> students = new List<Student>();

			while (sqliteDataReader.Read())
			{
				int idIndex = sqliteDataReader.GetOrdinal("StudentId");
				int id = sqliteDataReader.GetInt32(idIndex);

				int firstnameIndex = sqliteDataReader.GetOrdinal("FirstName");
				string firstName = sqliteDataReader.GetString(firstnameIndex);

				int lastnameIndex = sqliteDataReader.GetOrdinal("LastName");
				string lastName = sqliteDataReader.GetString(lastnameIndex);

				int birthdateIndex = sqliteDataReader.GetOrdinal("BirthDate");
				DateTime birthDate = sqliteDataReader.GetDateTime(birthdateIndex);

				int emailIndex = sqliteDataReader.GetOrdinal("Email");
				string email = sqliteDataReader.GetString(emailIndex);

				Student student = new Student();
				student.StudentId = id;
				student.FirstName = firstName;
				student.LastName = lastName;
				student.BirthDate = birthDate;
				student.Email = email;

				students.Add(student);
			}

			foreach (var student in students)
			{
				Console.WriteLine($"Student: {student.StudentId}, {student.FirstName}, {student.LastName}, {student.BirthDate}, {student.Email}");
			}

			Student david = students.Find(x => x.StudentId == 3);
			if (david != null)
			{
				Console.WriteLine($"Found student: {david.StudentId}, {david.FirstName}, {david.LastName}, {david.BirthDate}, {david.Email}");
			}
			else
			{
				Console.WriteLine("Student with ID 3 not found.");
			}

			david.Email = "david@gmail.com";

			SqliteCommand updateCommand = connection.CreateCommand();
			updateCommand.CommandText = "UPDATE Students SET Email = @Email WHERE StudentId = @StudentId";

			SqliteParameter emailParam = new SqliteParameter();
			emailParam.ParameterName = "@Email";
			emailParam.Value = david.Email;

			SqliteParameter idParam = new SqliteParameter();
			idParam.ParameterName = "@StudentId";
			idParam.Value = david.StudentId;

			updateCommand.Parameters.Add(emailParam);
			updateCommand.Parameters.Add(idParam);

			int rowsAffected = updateCommand.ExecuteNonQuery();
			Console.WriteLine($"Rows affected: {rowsAffected}");
		}

		public void RelatedData()
		{
			using SqliteConnection connection = new SqliteConnection(connectionString);
			connection.Open();

			using SqliteCommand command = connection.CreateCommand();
			command.CommandText =
				"select * from Students " +
				"inner join Enrollments on Students.StudentId = Enrollments.StudentId " +
				"inner join Courses on Enrollments.CourseId = Courses.CourseId where Students.StudentId = 1;";

			using SqliteDataReader sqliteDataReader = command.ExecuteReader();
			while (sqliteDataReader.Read())
			{
				int firstNameIndex = sqliteDataReader.GetOrdinal("FirstName");
				string firstName = sqliteDataReader.GetString(firstNameIndex);

				int lastNameIndex = sqliteDataReader.GetOrdinal("LastName");
				string lastName = sqliteDataReader.GetString(lastNameIndex);

				int courseNameIndex = sqliteDataReader.GetOrdinal("CourseName");
				string courseName = sqliteDataReader.GetString(courseNameIndex);

				int gradeIndex = sqliteDataReader.GetOrdinal("Grade");
				string grade = sqliteDataReader.GetString(gradeIndex);

				Console.WriteLine($"Student: {firstName} {lastName}, Course: {courseName}, Grade: {grade}");
			}
		}
	}
}