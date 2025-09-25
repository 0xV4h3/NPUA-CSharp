using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Homework6
{
    public class FileWrapper : IDisposable
    {
        private StreamReader reader;

        public FileWrapper(string path)
        {
            reader = new StreamReader(path);
        }

        public string ReadLine()
        {
            return reader.ReadLine();
        }

        public void Dispose()
        {
            reader?.Close();
            reader = null;
        }
    }
}
