using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEd.Models.Interfaces;

namespace TinyEd.Models.Services
{
    class StreamReaderFileSystemService : IFileSystemService
    {
        public string ReadFile(string fullPath)
        {
            using (StreamReader sw = new StreamReader(fullPath))
            {
                return sw.ReadToEnd();
            }
        }

        public void WriteFile(string fullPath, string content)
        {
            using (StreamWriter sw = new StreamWriter(fullPath))
            {
                sw.Write(content);
            }
        }
    }
}
