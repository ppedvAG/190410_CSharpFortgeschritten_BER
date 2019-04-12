using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEd.Models.Interfaces
{
    public interface IFileSystemService
    {
        void WriteFile(string fullPath, string content);
        string ReadFile(string fullPath);
    }
}
