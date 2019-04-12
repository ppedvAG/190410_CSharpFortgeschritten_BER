using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEd.Models.Interfaces;

namespace TinyEd.Models.Services
{
    class FileSystemService : IFileSystemService
    {
        public string ReadFile(string fullPath) => File.ReadAllText(fullPath);
        public void WriteFile(string fullPath, string content) => File.WriteAllText(fullPath, content);
    }
}
