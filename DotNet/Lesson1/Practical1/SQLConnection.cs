using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    public class SQLConnection : IDisposable
    {
        private string connectionString;
        private bool isOpen;
        public SQLConnection(string connectionString)
        {
            this.connectionString = connectionString;
            this.isOpen = false;
        }
        public void Open()
        {
            if (isOpen)
            {
                throw new InvalidOperationException("Connection is already open.");
            }
            Console.WriteLine($"Opening connection to: {connectionString}");
            isOpen = true;
        }
        public void Close()
        {
            if (!isOpen)
            {
                throw new InvalidOperationException("Connection is already closed.");
            }
            Console.WriteLine("Closing connection.");
            isOpen = false;
        }
        public void Dispose()
        {
            if (isOpen)
            {
                Close();
            }
            Console.WriteLine("Disposing of SQLConnection resources.");
        }
    }

    public class SQLConnectionDemo
    {
        public static void Run()
        {
            using (var connection = new SQLConnection("demo-connection-string"))
            {
                connection.Open();
                Console.WriteLine("Connection opened.");
            }
        }
    }
}
