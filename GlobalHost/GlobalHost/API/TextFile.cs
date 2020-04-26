using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GlobalHost.API
{
    class TextFile
    {
        public static void Write(string path, string str)
        {
            StreamWriter writer = new StreamWriter(path, true);
            writer.WriteLine(str);
            writer.Close();
        }
    }
}
