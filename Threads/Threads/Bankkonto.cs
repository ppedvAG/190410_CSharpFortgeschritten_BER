using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Threads
{
    class Bankkonto
    {
        public Bankkonto(decimal Kontostand)
        {
            this.Kontostand = Kontostand;
            transaktion = 0;
        }
        private object lockObject = new object();
        private static int transaktion;
        public decimal Kontostand { get; set; }

        public void Abheben(decimal Betrag)
        {
            lock (lockObject)
            {
                if (Kontostand >= Betrag)
                {
                    Console.WriteLine($"[{transaktion}]Kontostand vor dem Abheben: {Kontostand}€");
                    Console.WriteLine($"[{transaktion}]Betrag zum Abheben: {Betrag}€");
                    Kontostand -= Betrag;
                    Console.WriteLine($"[{transaktion}]Kontostand nach dem Abheben: {Kontostand}€");
                }
                transaktion++;
            }
        }

        public void Einzahlen(decimal Betrag)
        {
            Monitor.Enter(lockObject);

            Console.WriteLine($"[{transaktion}]Kontostand vor dem Einzahlen: {Kontostand}€");
            Console.WriteLine($"[{transaktion}]Betrag zum Einzahlen: {Betrag}€");
            Kontostand += Betrag;
            Console.WriteLine($"[{transaktion}]Kontostand nach dem Einzahlen: {Kontostand}€");
            transaktion++;

            Monitor.Exit(lockObject);
        }
    }
}
