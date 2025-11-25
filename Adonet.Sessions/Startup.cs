using Microsoft.Data.Sqlite;

namespace Adonet.Sessions
{
	public class Startup
	{
		public static void InitializeDatabase()
		{
			using SqliteConnection connection = new SqliteConnection("Data Source=demo-db.db");
			connection.Open();
			using SqliteCommand command = connection.CreateCommand();
			command.CommandText = File.ReadAllText("Scripts\\databasesetup.sql");
			command.ExecuteNonQuery();
			Console.WriteLine("Database initialized successfully.");
		}
	}
}
