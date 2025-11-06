using System;

namespace Laborator12
{
    public class FakeDbConnection
    {
        public FakeDbConnection() => Console.WriteLine("FakeDbConnection: Initialized!");

        public void Query(string sql) => Console.WriteLine($"Executed query: {sql}");
    }
}