namespace Apadpter
{
    internal partial class Program
    {
        public class SqlServerAdapter : IDatabaseAdapter
        {
            public void Connect()
            {
                Console.WriteLine("Connecting to SQL Server...");
            }

            public void Execute(string query)
            {
                Console.WriteLine($"Executing SQL Server query: {query}");
            }

            public void Close()
            {
                Console.WriteLine("Closing SQL Server connection...");
            }
        }

    }
}
