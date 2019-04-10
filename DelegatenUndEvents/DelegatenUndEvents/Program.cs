using System;
using System.Collections.Generic;
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
            Button b = new Button();
            b.ClickEvent += MeineButtonClickLogik;
            b.ClickEvent += Logger;

            b.Click();
            // b.ClickEvent = null;           // absolut verboten !!!
            b.Click();
            b.Click();
            b.ClickEvent -= Logger;

            b.Click();
            b.Click();

            // b.ClickEvent?.Invoke();        // verboten !!!

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }

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
