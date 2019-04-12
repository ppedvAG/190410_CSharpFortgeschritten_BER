using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Markup;
using TinyEd.Helpers;
using TinyEd.Models.Interfaces;

namespace TinyEd.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel(IMessageService messageService,IFileSystemService fileSystemService)
        {
            this.messageService = messageService;
            this.fileSystemService = fileSystemService;
        }
        private readonly IFileSystemService fileSystemService;
        private readonly IMessageService messageService;


        private string document;
        public string Document
        {
            get => document;
            set => Set(ref document, value);
        }

        private ICommand speichernCommand;
        public ICommand SpeichernCommand
        {
            get
            {
                speichernCommand = speichernCommand ?? new RelayCommand(parameter => fileSystemService.WriteFile("demo.txt",Document));
                return speichernCommand;
            }
        }

        private ICommand öffnenCommand;
        public ICommand ÖffnenCommand
        {
            get
            {
                öffnenCommand = öffnenCommand ?? new RelayCommand(parameter => Document = fileSystemService.ReadFile("demo.txt"));
                return öffnenCommand;
            }
        }

        private ICommand beendenCommand;
        public ICommand BeendenCommand
        {
            get
            {
                beendenCommand = beendenCommand ?? new RelayCommand(parameter => Environment.Exit(0));
                return beendenCommand;
            }
        }
        private ICommand hilfeCommand;
        public ICommand HilfeCommand
        {
            get
            {
                hilfeCommand = hilfeCommand ?? new RelayCommand(parameter => messageService.SendMessage("Mir ist nicht mehr zu helfen ..."));
                return hilfeCommand;
            }
        }
    }
}
