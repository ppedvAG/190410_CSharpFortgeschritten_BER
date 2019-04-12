using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyEd.Models.Interfaces;
using TinyEd.Models.Services;
using TinyEd.ViewModels;

namespace TinyEd.Helpers
{
    public class ViewModelLocator
    {
        public ViewModelLocator()
        {
            messageService = new WPFMessageService();
            fileSystemService = new FileSystemService();
            dialogService = new Win32DialogService();
        }

        private readonly IMessageService messageService;
        private readonly IFileSystemService fileSystemService;
        private readonly IDialogService dialogService;

        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                main = main ?? new MainViewModel(messageService, fileSystemService, dialogService);
                return main;
            }
        }
    }
}
