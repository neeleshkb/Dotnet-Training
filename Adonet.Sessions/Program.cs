using Microsoft.Data.SqlClient;

Console.WriteLine("Hello, Adonet.Sessions!");

//Startup.InitializeDatabase();
string connectionString = "Data Source = demo-db.db";

// CRUD Operations
//DataStore dataStore = new DataStore(connectionString);
//dataStore.ReadFromDatabase();
//dataStore.UpdateTableData();
//dataStore.SqlInjection();
//dataStore.DeleteFromDatabase();
//dataStore.InsertIntoDatabase();
//dataStore.Materialization();
//dataStore.RelatedData();

string sqlConnectionString = "Server=(LocalDB)\\MSSQLLocalDB;Database=Learning;Integrated Security=true";
using SqlConnection sqlConnection = new SqlConnection(sqlConnectionString);
sqlConnection.Open();
Console.WriteLine("SQL Server Connection State: " + sqlConnection.State);

SqlCommand command = sqlConnection.CreateCommand();
command.CommandText = "GetAllStudents";
command.CommandType = System.Data.CommandType.StoredProcedure;

using SqlDataReader reader = command.ExecuteReader();
while (reader.Read())
{
	int FirstnameIndex = reader.GetOrdinal("FirstName");
	string firstName = reader.GetString(FirstnameIndex);
	Console.WriteLine($"Student First Name: {firstName}");
}

reader.Close();

SqlCommand viewCommand = sqlConnection.CreateCommand();
viewCommand.CommandText = "SELECT * FROM StudentsCoursesView";

SqlDataReader sqlDataReader = viewCommand.ExecuteReader();
while (sqlDataReader.Read())
{
	int firstnameIndex = sqlDataReader.GetOrdinal("FirstName");
	string firstName = sqlDataReader.GetString(firstnameIndex);

	int courseNameIndex = sqlDataReader.GetOrdinal("CourseName");
	string courseName = sqlDataReader.GetString(courseNameIndex);

	Console.WriteLine($"Student: {firstName}, Course: {courseName}");
	sqlDataReader.Close();
}