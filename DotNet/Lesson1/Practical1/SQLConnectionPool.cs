using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    public class SQLConnectionPool : IDisposable
    {
        private List<SQLConnection> _connections;

        public SQLConnectionPool(IEnumerable<string> connectionStrings)
        {
            _connections = new List<SQLConnection>();
            foreach (var cs in connectionStrings)
            {
                _connections.Add(new SQLConnection(cs));
            }
        }

        public SQLConnection GetConnection(int index)
        {
            if (index < 0 || index >= _connections.Count)
                throw new ArgumentOutOfRangeException();
            return _connections[index];
        }

        public void Dispose()
        {
            foreach (var conn in _connections)
            {
                conn.Dispose();
            }
            Console.WriteLine("Connection pool disposed.");
        }
    }

    public class SQLConnectionPoolDemo
    {
        public static void Run()
        {
            var connStrings = new List<string>
            {
                "pool-conn-1",
                "pool-conn-2"
            };
            using (var pool = new SQLConnectionPool(connStrings))
            {
                var conn = pool.GetConnection(0);
                conn.Open();
            }
        }
    }
}
