using Model.Contracts;
using Model.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using ViewModel.Helpers;

namespace ViewModel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }
        private readonly PersonenService service;

        private List<Person> personenliste;
        public List<Person> Personenliste
        {
            get => personenliste;
            set => Set(ref personenliste, value);
        }
        public ICommand GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen().ToList(); // Feature aus dem Model aufrufen
        }
    }
}
