using System;
using System.Collections.Generic;
using System.Text;

namespace Practical1
{
    public class SQLTransaction : IDisposable
    {
        private bool _active;

        public SQLTransaction()
        {
            _active = true;
            Console.WriteLine("Transaction started.");
        }

        public void Commit()
        {
            if (!_active) throw new InvalidOperationException("No active transaction.");
            Console.WriteLine("Transaction committed.");
            _active = false;
        }

        public void Dispose()
        {
            if (_active)
            {
                Console.WriteLine("Transaction disposed without commit (rollback).");
                _active = false;
            }
        }
    }

    public class SQLTransactionDemo
    {
        public static void Run()
        {
            using (var connection = new SQLConnection("demo-connection-string"))
            {
                connection.Open();
                using (var transaction = new SQLTransaction())
                {
                    transaction.Commit();
                }
            }
        }
    }
}
