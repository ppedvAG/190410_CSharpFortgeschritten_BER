using Model.Contracts;
using Model.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using ViewModel.Helpers;

namespace ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            // Kontrollfreak-Antipattern
            service = new PersonenService();
            GetPersonenCommand = new RelayCommand(GetPersonen);
        }
        private readonly PersonenService service;


        public List<Person> Personenliste { get; set; }
        public ICommand GetPersonenCommand { get; set; }
        private void GetPersonen(object obj)
        {
            Personenliste = service.GetPersonen().ToList(); // Feature aus dem Model aufrufen
        }
    }
}
