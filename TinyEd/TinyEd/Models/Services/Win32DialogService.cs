using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEd.Models.Interfaces;
using Win32 = Microsoft.Win32;

namespace TinyEd.Models.Services
{
    public class Win32DialogService : IDialogService
    {
        public string OpenFileDialog() => OpenFileDialog(string.Empty);
        public string OpenFileDialog(string Filter)
        {
            Win32.OpenFileDialog dlg = new Win32.OpenFileDialog();
            dlg.Filter = Filter;
            if (dlg.ShowDialog() == true)
                return dlg.FileName;
            else
                return string.Empty;
        }
        public string SaveFileDialog() => SaveFileDialog(string.Empty);
        public string SaveFileDialog(string Filter)
        {
            Win32.SaveFileDialog dlg = new Win32.SaveFileDialog();
            dlg.Filter = Filter;
            if (dlg.ShowDialog() == true)
                return dlg.FileName;
            else
                return string.Empty;
        }
    }
}
