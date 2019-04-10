using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ErweiterungsmethodenUndOperatorüberladung
{
    class Program
    {
        static void Main(string[] args)
        {
            // Erweiterungsmethoden:
            //string text = "Hallo Welt !";
            //Console.WriteLine(text.Umdrehen());
            //Console.WriteLine(Erweiterungsmethoden.Umdrehen(text));

            // Operatorüberladung

            Bruch b1 = new Bruch(1, 4);
            Bruch b2 = new Bruch(1, 2);

            Bruch ergebnis = b1 * b2;

            Console.WriteLine($"Ergebnis ist: {ergebnis.Zähler}/{ergebnis.Nenner}");

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
