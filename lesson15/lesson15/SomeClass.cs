using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson15
{
    class SomeClass : IDisposable
    {
        Stream stream = new MemoryStream();

        public SomeClass(string path)
        {
            stream = File.OpenRead(path);
        }

        public void Dispose()
        {
            this.stream.Dispose();
        }

        ~SomeClass()
        {
            Console.WriteLine("Disposed");
            Debug.WriteLine("Disposed");
            Dispose();
        }
    }
}
