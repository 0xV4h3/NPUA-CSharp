using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    public class SQLCommand
    {
        private SQLConnection _connection;
        private string _query;

        public SQLCommand(SQLConnection connection, string query)
        {
            _connection = connection;
            _query = query;
        }

        public void Execute()
        {
            Console.WriteLine($"Executing query on connection: {_query}");
        }
    }

    public class SQLCommandDemo
    {
        public static void Run()
        {
            using (var connection = new SQLConnection("demo-connection-string"))
            {
                connection.Open();
                var command = new SQLCommand(connection, "SELECT * FROM Users;");
                command.Execute();
            }
        }
    }
}
