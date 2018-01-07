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

        public MyStreamWriter(string path)
        {
            _streamWriter = new StreamWriter(path);
        }

        public void WriteTextToFile(string line)
        {
            _streamWriter.WriteLine(line);
        }

        protected virtual void Dispose(bool b)
        {
            if (b)
            {
                _streamWriter.Dispose();
            }
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
