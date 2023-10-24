using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace DocumentAdder.Utils;

public class Writer
{
    static public void write(string path, byte[] data)
    {
        using (FileStream fstream = new(path, FileMode.OpenOrCreate))
        {
            fstream.Write(data, 0, data.Length);
        }
    }
    static public byte[] read(string path)
    {
        using (FileStream fstream = File.OpenRead(path))
        {
            byte[] buffer = new byte[fstream.Length];
            fstream.Read(buffer, 0, buffer.Length);
            return buffer;
        }
    }
}
