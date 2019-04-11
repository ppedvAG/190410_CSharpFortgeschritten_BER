using SOLID_Taschenrechner.Model;
using System;

namespace SOLID_Taschenrechner
{
    class KonsolenUI // Könnte man zb auch zu einem ViewModel umbauen
    {
        public KonsolenUI(IParser parser, IRechner rechner)
        {
            this.parser = parser;
            this.rechner = rechner;
        }
        
        private readonly IParser parser;
        private readonly IRechner rechner;

        // Workflow
        public void Start()
        {
            Console.WriteLine("Bitte geben Sie die Formel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            Formel formel = parser.Parse(input);
            int ergebnis = rechner.Berechne(formel);

            Console.WriteLine($"Das Ergebnis ist {ergebnis}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
