using Adonet.Sessions;

Console.WriteLine("Hello, Adonet.Sessions!");

//Startup.InitializeDatabase();
string connectionString = "Data Source = demo-db.db";

// CRUD Operations
DataStore dataStore = new DataStore(connectionString);
//dataStore.ReadFromDatabase();
//dataStore.UpdateTableData();
//dataStore.SqlInjection();
//dataStore.DeleteFromDatabase();
//dataStore.InsertIntoDatabase();
//dataStore.Materialization();
dataStore.RelatedData();