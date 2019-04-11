using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie die Formel ein:");
            string input = Console.ReadLine(); // "2 + 2"

            string[] operanden = input.Split(); // Leerzeichen
            int zahl1 = Convert.ToInt32(operanden[0]);
            int zahl2 = Convert.ToInt32(operanden[2]);
            string op = operanden[1];

            int ergebnis = 0;
            if(op == "+")
                ergebnis = zahl1 + zahl2;
            else if(op == "-")
                ergebnis = zahl1 - zahl2;

            Console.WriteLine($"Das Ergebnis ist {ergebnis}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
