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
            string text = "Hallo Welt !";
            Console.WriteLine(text.Umdrehen());
            Console.WriteLine(Erweiterungsmethoden.Umdrehen(text));

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
