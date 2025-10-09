using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laborator7_3
{
    public class SafeFileUser : IDisposable
    {
        private bool _disposed;
        private SafeFileHandle? _handle;
        public SafeFileUser(string path)
        {
            _handle = File.OpenHandle(path, FileMode.OpenOrCreate, FileAccess.ReadWrite);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (_disposed) return;
            if (disposing) { }
            _handle?.Dispose();
            _handle = null;
            _disposed = true;
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        ~SafeFileUser() => Dispose(false);
    }
}
