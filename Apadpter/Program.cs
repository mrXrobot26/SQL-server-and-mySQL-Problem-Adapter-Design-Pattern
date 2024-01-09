namespace Apadpter
{
    internal partial class Program
    {
        static void PerformDatabaseOperations(IDatabaseAdapter adapter, string query)
        {
            adapter.Connect();
            adapter.Execute(query);
            adapter.Close();
            Console.WriteLine("----------------------------------------");
        }

        static void Main(string[] args)
        {
            IDatabaseAdapter sqlAdapter = new SqlServerAdapter();
            IDatabaseAdapter mysqlAdapter = new MySqlAdapter();

            Console.WriteLine("Using SQL Server Adapter");
            PerformDatabaseOperations(sqlAdapter, "SELECT * FROM Users");

            Console.WriteLine("\nUsing MySQL Adapter");
            PerformDatabaseOperations(mysqlAdapter, "SELECT * FROM Products");
        }

    }
}
