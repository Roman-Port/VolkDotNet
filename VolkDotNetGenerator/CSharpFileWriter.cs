using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace VolkDotNetGenerator
{
    public class CSharpFileWriter : IDisposable
    {
        public CSharpFileWriter(StreamWriter writer)
        {
            this.writer = writer;
        }

        public CSharpFileWriter(Stream writer) : this(new StreamWriter(writer))
        {
        }

        public CSharpFileWriter(string filename) : this(new FileStream(filename, FileMode.Create))
        {
        }

        private StreamWriter writer;
        private int indentation = 0;

        private void WriteIndentation()
        {
            for (int i = 0; i < indentation; i++)
                writer.Write("    ");
        }

        public void Enter()
        {
            indentation++;
        }

        public void Leave()
        {
            indentation--;
            if (indentation < 0)
                throw new Exception("Leave() called too many times!");
        }

        public void WriteLine(string line)
        {
            WriteIndentation();
            writer.WriteLine(line);
        }

        public void Dispose()
        {
            writer.Dispose();
        }
    }
}
