using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyEd.Models.Interfaces
{
    public interface IDialogService
    {
        string OpenFileDialog();
        string OpenFileDialog(string Filter);
        string SaveFileDialog();
        string SaveFileDialog(string Filter);
    }
}
