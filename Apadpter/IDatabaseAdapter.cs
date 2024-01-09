namespace Apadpter
{
    internal partial class Program
    {
        public interface IDatabaseAdapter
        {
            void Connect();
            void Execute(string query);
            void Close();
        }

    }
}
