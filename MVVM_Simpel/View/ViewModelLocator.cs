using Model.Interfaces;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModel;

namespace View
{
    public class ViewModelLocator
    {
        // Main -> Bootstrapping
        public ViewModelLocator()
        {
            // Perfekter Ort für einen IoC-Container (Unity, SimpleIoC usw...)
            personenservice = new PersonenService();
        }
        private readonly IPersonenService personenservice;

        private MainViewModel main;
        public MainViewModel Main
        {
            get
            {
                main = main ?? new MainViewModel(personenservice);
                return main;
            }
        }

    }
}
