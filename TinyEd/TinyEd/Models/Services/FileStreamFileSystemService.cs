using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEd.Models.Interfaces;

namespace TinyEd.Models.Services
{
    class FileStreamFileSystemService : IFileSystemService
    {
        public string ReadFile(string fullPath)
        {
            using (FileStream stream = new FileStream(fullPath, FileMode.Open))
            {
                byte[] data = new byte[stream.Length];
                stream.Read(data, 0, Convert.ToInt32(stream.Length));
                return Encoding.Default.GetString(data);
            }
        }

        public void WriteFile(string fullPath, string content)
        {
            using (FileStream stream = new FileStream(fullPath, FileMode.Create))
            {
                byte[] data = Encoding.Default.GetBytes(content);
                stream.Write(data, 0, data.Length);
            }
        }

        // StreamReader
        // File / Directory

        // Dialoge (neuer Service)
    }
}
