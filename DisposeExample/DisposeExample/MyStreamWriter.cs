using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DisposeExample
{
    public class MyStreamWriter : IDisposable
    {
        private readonly StreamWriter _streamWriter;
        private bool _disposed = false;

        public MyStreamWriter(string path)
        {
            _streamWriter = new StreamWriter(path);
        }

        public void WriteTextToFile(string line)
        {
            _streamWriter.WriteLine(line);
        }

        public void Dispose()
        {
            IsDisposed();
            Dispose(_disposed);
           // GC.SuppressFinalize(this); according to msdn we could want to suppress Finalazer.
        }

        protected virtual void Dispose(bool b)
        {
            if (!b)
            {
                _streamWriter.Dispose();
                _disposed = true;
            }
        }

        private void IsDisposed()
        {
            if (_disposed)
            {
                throw new ObjectDisposedException("Disposed object can not be used any more");
            }
        }
    }
}
