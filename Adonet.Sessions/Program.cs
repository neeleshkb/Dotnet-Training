using Adonet.Sessions;

Console.WriteLine("Hello, Adonet.Sessions!");

Startup.InitializeDatabase();
string connectionString = "Data Source = demo-db.db";

DataStore dataStore = new DataStore();
//dataStore.ReadFromDatabase();
//dataStore.UpdateTableData();
//dataStore.SqlInjection();
