using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConfigAddFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string filename = "c:\\random.dat";
            Random r = new Random(Guid.NewGuid().ToString().GetHashCode());
            int size = r.Next(1000, 2000) * 1024*200; // size = 1~2MB
            byte[] buffer = new byte[size];
            r.NextBytes(buffer);
            using (System.IO.FileStream fs = new System.IO.FileStream(filename, System.IO.FileMode.Create))
            {
                fs.Write(buffer, 0, size);
            }
        }
    }
}
