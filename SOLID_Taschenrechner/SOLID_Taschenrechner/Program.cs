using SOLID_Taschenrechner.FreeFeatures;
using SOLID_Taschenrechner.Logik;
using SOLID_Taschenrechner.Model;
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
            IRechner rechner = new ModulRechner(new Addition(), new Subtraktion());
            new KonsolenUI(parser,rechner).Start();
        }
    }
}
