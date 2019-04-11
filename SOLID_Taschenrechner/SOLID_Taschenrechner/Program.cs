using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            new KonsolenUI().Start();
        }
    }

    class Formel
    {
        public int Operand1 { get; set; }
        public int Operand2 { get; set; }
        public string Operator { get; set; }
    }

    class StringSplitParser
    {
        public Formel Parse(string input)
        {
            string[] operanden = input.Split(); // Leerzeichen
            Formel result = new Formel();

            result.Operand1 = Convert.ToInt32(operanden[0]);
            result.Operand2 = Convert.ToInt32(operanden[2]);
            result.Operator = operanden[1];

            return result;
        }
    }

    class SimplerRechner
    {
        public int Berechne(Formel formel)
        {
            if (formel.Operator == "+") // Entscheidungsfindung "welche rechenart"
                return formel.Operand1 + formel.Operand2; // Berechnung
            else if (formel.Operator == "-") // Entscheidungsfindung "welche rechenart"
                return formel.Operand1 - formel.Operand2; // Berechnung 
            // ...
            else
                throw new ArgumentException("Operator ist unbekannt");
        }
    }

    class KonsolenUI
    {
        // Workflow
        public void Start()
        {
            Console.WriteLine("Bitte geben Sie die Formel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            StringSplitParser parser = new StringSplitParser();
            Formel formel = parser.Parse(input);

            SimplerRechner rechner = new SimplerRechner();
            int ergebnis = rechner.Berechne(formel);

            Console.WriteLine($"Das Ergebnis ist {ergebnis}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
