using AutoFixture;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatenUndEvents
{
    class Program
    {
        // DelegateType:
        public delegate void MeinDelegat(); // Signatur: void()
        static void Main(string[] args)
        {
            #region Delegate
            ////MeinDelegat del = new MeinDelegat(A);
            ////del.Invoke();
            ////del();

            //MeinDelegat del = A; // new MeinDelegat(A);
            //del += B; // Hängt die Methode B in die "InvocationList" hinein
            //del(); 
            #endregion

            #region Action<T> und Func<T>
            //// Action -> Delegat für alle Methoden die keine Rückgabe haben
            //Action del = A;
            //Action<int> del2 = C;
            //del2(12);

            //// Func -> Delefat für alle Methoden die eine Rückgabe haben
            //Func<int, int, int> rechenart = Sub;

            //int erg = rechenart(12, 12);
            //Console.WriteLine(erg); 
            #endregion

            // Anwendungsfall 1#
            #region Variante "Normal"
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie den Operator ein:");
            //string op = Console.ReadLine();

            //int erg = 0;

            //if (op == "+")
            //    erg = zahl1 + zahl2;
            //else if (op == "-")
            //    erg = zahl1 - zahl2;

            //Console.WriteLine($"Das Ergebnis ist: {erg}"); 
            #endregion
            #region Variante mit Delegaten
            //Console.WriteLine("Bitte geben Sie die erste Zahl ein");
            //int zahl1 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie die zweite Zahl ein:");
            //int zahl2 = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Bitte geben Sie den Operator ein:");
            //string op = Console.ReadLine();

            //Func<int, int, int> rechenart = null;

            //if (op == "+")
            //    rechenart = Add;
            //else if (op == "-")
            //    rechenart = Sub;
            //// ....
            //Console.WriteLine($"Das Ergebnis ist: {rechenart(zahl1,zahl2)}"); 
            #endregion

            // Anwendungsfall 2#
            #region Button-Beispiel
            //Button b = new Button();
            //b.ClickEvent += MeineButtonClickLogik;
            //b.ClickEvent += Logger;

            //b.Click();
            //// b.ClickEvent = null;           // absolut verboten !!!
            //b.Click();
            //b.Click();
            //b.ClickEvent -= Logger;

            //b.Click();
            //b.Click();

            //// b.ClickEvent?.Invoke();        // verboten !!! 
            #endregion

            // Suffix
            // var z1 = 12;
            // var z2 = 12.5;
            // var z3 = 12.5f;
            // var z4 = 12L;
            // var z5 = 12m;
            // var z6 = 12UL;

            #region LINQ
            //List<Person> personen = new List<Person>()
            //{
            //    new Person{Vorname="Tom",Nachname="Ate",Alter=10,Kontostand=100m},
            //    new Person{Vorname="Anna",Nachname="Nass",Alter=20,Kontostand=200m},
            //    new Person{Vorname="Peter",Nachname="Silie",Alter=30,Kontostand=-300m},
            //    new Person{Vorname="Franz",Nachname="Ose",Alter=40,Kontostand=4400m},
            //    new Person{Vorname="Martha",Nachname="Pfahl",Alter=50,Kontostand=55500m},
            //    new Person{Vorname="Albert",Nachname="Tross",Alter=60,Kontostand=-123100m},
            //    new Person{Vorname="Axel",Nachname="Schweiß",Alter=70,Kontostand=100000m},
            //    new Person{Vorname="Claire",Nachname="Grube",Alter=80,Kontostand=99999900m},
            //    new Person{Vorname="Rainer",Nachname="Zufall",Alter=90,Kontostand=-123123123123100m},
            //    new Person{Vorname="Anna",Nachname="Bolika",Alter=100,Kontostand=12345m},
            //};


            //// Szenario 1: Alle Vornamen in einem Array haben
            ////string[] alleVornamen = new string[personen.Count];
            ////for (int i = 0; i < alleVornamen.Length; i++)
            ////{
            ////    alleVornamen[i] = personen[i].Vorname;
            ////}

            //// Szenario 2: Alle Personen in einer Liste die Schulden haben:
            ////List<Person> allePersonenMitSchulden = new List<Person>();
            ////foreach (var item in personen)
            ////{
            ////    if (item.Kontostand < 0)
            ////        allePersonenMitSchulden.Add(item);
            ////}

            //// Szenario 3: Alle Personen in einer Liste die Schulden haben, Sortiert nach Nachname
            //// ....
            //// Szenario 4: Finde die Person über 60 mit dem höchsten Kontostand

            //// LINQ
            //// SELECT -> gib etwas zurück
            //string[] alleVorname = personen.Select(x => x.Vorname)
            //                               .ToArray();

            //// WHERE -> filtern
            //List<Person> allePersonenMitSchulden = personen.Where(x => x.Kontostand < 0)
            //                                               .ToList();

            //string[] nachnamenAllerPersonenMitSchulden = personen.Where(x => x.Kontostand < 0)
            //                                                     .Select(x => x.Nachname)
            //                                                     .ToArray();

            //// OrderBy / OrderByDescending => Sortieren nach Property XYZ
            //List<Person> allePersonenMitSchuldenSortiertNachNachname = personen.Where(x => x.Kontostand < 0)
            //                                                                   .OrderByDescending(x => x.Nachname)
            //                                                                   .ToList();
            //// First / Last  , FirstOrDefault/LastOrDefault
            //Person reichstePersonÜber60 = personen.Where(x => x.Alter >= 60)
            //                                      .OrderByDescending(x => x.Kontostand)
            //                                      .First();
            //// Take : Nimm X elemente heraus
            //Person[] reichsten5Personen = personen.OrderByDescending(x => x.Kontostand)
            //                                      .Take(5)
            //                                      .ToArray();

            //// Min,Max,Avarage,Sum
            //decimal durschnittlicherKontostand = personen.Sum(x => x.Kontostand);
            //decimal durchschnittlicherKontostandAllerPersonenMitSchulden = personen.Where(x => x.Kontostand < 0)
            //                                                                       .Average(x => x.Kontostand);

            //int anzahlAllerPersonenOhneSchulden = personen.Count(x => x.Kontostand > 0);


            //// Übung:
            //// 1) Finde die Person mit dem höchsten Kontostand, die unter 50 Jahre alt ist
            //// 2) Summe aller Schuldeny
            //// 3) Durschnittsalter aller Personen mit negativem Kontostand
            //// 4) Die ersten 3 Personen unter 70 Jahre mit positivem Kontostand
            //// 5) Liste an Personen mit Nachnamenlänge < 5 Zeichen, sortiert nach Alter absteigend 
            #endregion

            // LINQ mit zufälligen Testdaten
            Fixture fix = new Fixture();

            Console.WriteLine("---Personen werden generiert---");
            Person[] personen = new Person[300_000];
            Parallel.For(0, 300_000, i =>
              {
                  personen[i] = fix.Create<Person>();
              });
            Console.WriteLine("---Personen wurdcen generiert---");

            Stopwatch watch = new Stopwatch();

            // Finde die Person mit dem höchsten Durchschnittsalter der Haustiere
            Console.WriteLine("Variante mit LINQ:");
            watch.Start();
            Person result = personen
                                    //.AsParallel()
                                    //.WithDegreeOfParallelism(4)
                                    //.WithExecutionMode(ParallelExecutionMode.ForceParallelism) // Erzwingen
                                    .OrderByDescending(p => p.Haustiere.Average(h => h.Alter))
                                    .First();
            watch.Stop();
            Console.WriteLine($"Person: {result.Vorname},Durschnitt {result.Haustiere.Average(x => x.Alter)}, Dauer: {watch.ElapsedMilliseconds}ms");


            Console.WriteLine("Variante Iterativ mit Count-Property:");

            watch.Restart();

            Person currentResult = null;
            double currentDurchschnitt = 0;
            foreach (Person person in personen)
            {
                double gesamtalter = 0;
                foreach (Haustier haustier in person.Haustiere)
                {
                    gesamtalter += haustier.Alter;
                }
                double durschnitt = gesamtalter / person.Haustiere.Count;

                if (durschnitt > currentDurchschnitt)
                {
                    currentDurchschnitt = durschnitt;
                    currentResult = person;
                }
            }
            watch.Stop();
            Console.WriteLine($"Person: {result.Vorname}, Durschnitt:{currentDurchschnitt}, Dauer: {watch.ElapsedMilliseconds}ms");


            Console.WriteLine("Variante Iterativ mit Count aus LINQ:");

            watch.Restart();

            currentResult = null;
            currentDurchschnitt = 0;
            foreach (Person person in personen)
            {
                double gesamtalter = 0;
                foreach (Haustier haustier in person.Haustiere)
                {
                    gesamtalter += haustier.Alter;
                }
                double durschnitt = gesamtalter / person.Haustiere.Count();

                if (durschnitt > currentDurchschnitt)
                {
                    currentDurchschnitt = durschnitt;
                    currentResult = person;
                }
            }
            watch.Stop();
            Console.WriteLine($"Person: {result.Vorname}, Durschnitt:{currentDurchschnitt}, Dauer: {watch.ElapsedMilliseconds}ms");

            Console.WriteLine("Variante Iterativ mit Avarage aus LINQ:");

            watch.Restart();

            currentResult = null;
            currentDurchschnitt = 0;
            foreach (Person person in personen)
            {
                double durschnitt = person.Haustiere.Average(x => x.Alter);
                if (durschnitt > currentDurchschnitt)
                {
                    currentDurchschnitt = durschnitt;
                    currentResult = person;
                }
            }
            watch.Stop();
            Console.WriteLine($"Person: {result.Vorname}, Durschnitt:{currentDurchschnitt}, Dauer: {watch.ElapsedMilliseconds}ms");


            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

        // private static string Selektor (Person x) => x.Vorname;
        //{
        //    return p.Vorname;
        //}

        private static void Logger()
        {
            Console.WriteLine($"[{DateTime.Now.ToLongTimeString()}]: Button wurde geklickt");
        }

        private static void MeineButtonClickLogik()
        {
            Console.Beep();
            Console.WriteLine("*click*");
        }

        private static void A()
        {
            Console.WriteLine("A");
        }
        private static void B() => Console.WriteLine("B");
        private static void C(int wert) => Console.WriteLine($"C {wert}");
        private static int Add(int z1, int z2)
        {
            return z1 + z2;
        }
        private static int Sub(int z1, int z2) => z1 - z2;
    }
}
