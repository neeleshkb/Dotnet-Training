using Microsoft.Data.Sqlite;

Console.WriteLine("Hello, Adonet.Sessions!");

using SqliteConnection connection = new SqliteConnection("Data Source=demo-db.db");
connection.Open();
Console.WriteLine("Database connection opened successfully.");

SqliteCommand command = new SqliteCommand();
command.Connection = connection;
command.CommandText = "Select * from Employee";

SqliteDataReader reader = command.ExecuteReader();
while (reader.Read())
{
	int lastnameIndex = reader.GetOrdinal("lastname");
	int firstnameIndex = reader.GetOrdinal("firstname");

	string lastname = reader.GetString(lastnameIndex);
	string firstName = reader.GetString(firstnameIndex);
	Console.WriteLine($"FullName : {firstName} {lastname}");
}