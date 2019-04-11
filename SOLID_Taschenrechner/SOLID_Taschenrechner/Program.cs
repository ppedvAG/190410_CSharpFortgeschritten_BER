using SOLID_Taschenrechner.FreeFeatures;
using SOLID_Taschenrechner.Logik;
using SOLID_Taschenrechner.Model;
using SOLID_Taschenrechner.PaidFeatures;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SOLID_Taschenrechner
{
    class Program
    {
        // Bootstrapping
        static void Main(string[] args)
        {
            IParser parser = new RegexParser();
            IRechner rechner = new ModulRechner(new Addition(), new Subtraktion(), new Multiplikation(), new Division());
            new KonsolenUI(parser,rechner).Start();

            // Übung:
            // DLL: "PaidFeatures" erstellen, Multiplikation und Division implementieren und
            //      im Konsolenprojekt einbinden
        }
    }
}
