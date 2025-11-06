using System;
using System.IO;

namespace Laborator12
{
    public class FileHolder : IDisposable
    {
        private bool _disposed = false;
        private readonly string _path;
        private FileStream? _stream;

        public FileHolder(string path)
        {
            _path = path;
            _stream = new FileStream(_path, FileMode.Create, FileAccess.Write);
        }

        public void Write(string text)
        {
            if (_disposed) throw new ObjectDisposedException(nameof(FileHolder));
            var bytes = System.Text.Encoding.UTF8.GetBytes(text);
            _stream!.Write(bytes, 0, bytes.Length);
        }

        public void Dispose()
        {
            if (_disposed) return;
            _stream?.Dispose();
            Console.WriteLine($"File {_path} disposed.");
            _disposed = true;
            GC.SuppressFinalize(this);
        }

        ~FileHolder()
        {
            Dispose();
        }
    }
}