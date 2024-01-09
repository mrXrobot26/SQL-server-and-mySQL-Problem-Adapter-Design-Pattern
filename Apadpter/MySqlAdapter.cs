namespace Apadpter
{
    internal partial class Program
    {
        public class MySqlAdapter : IDatabaseAdapter
        {
            public void Connect()
            {
                Console.WriteLine("Connecting to MySQL...");
            }

            public void Execute(string query)
            {
                Console.WriteLine($"Executing MySQL query: {query}");
            }

            public void Close()
            {
                Console.WriteLine("Closing MySQL connection...");
            }
        }

    }
}
