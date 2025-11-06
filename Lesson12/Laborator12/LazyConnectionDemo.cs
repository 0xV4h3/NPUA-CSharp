using System;

namespace Laborator12
{
    public class LazyConnectionDemo
    {
        public static void Run()
        {
            Lazy<FakeDbConnection> conn = new Lazy<FakeDbConnection>(() => new FakeDbConnection());
            Console.WriteLine("Lazy DB holder created.");
            Console.WriteLine("Connection not yet initialized...");

            Console.WriteLine("Accessing DB now.");
            conn.Value.Query("SELECT * FROM Users");
        }
    }
}