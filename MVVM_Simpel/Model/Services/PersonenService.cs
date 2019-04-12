using Model.Contracts;
using Model.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model.Services
{
    public class PersonenService : IPersonenService
    {
        public IEnumerable<Person> GetPersonen()
        {
            return new List<Person>
            {
                new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
                new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200m},
                new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300m},
                new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=4400m},
                new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55500m},
                new Person{Vorname="Albert",Nachname="Tross",Alter=60,Kontostand=-123100m},
                new Person{Vorname="Axel",Nachname="Schweiß",Alter=70,Kontostand=100000m},
                new Person{Vorname="Claire",Nachname="Grube",Alter=80,Kontostand=99999900m},
                new Person{Vorname="Rainer",Nachname="Zufall",Alter=90,Kontostand=-123123123123100m},
                new Person{Vorname="Anna",Nachname="Bolika",Alter=100,Kontostand=12345m},
            };
        }
    }
}
