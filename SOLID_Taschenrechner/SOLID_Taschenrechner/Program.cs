using SOLID_Taschenrechner.Logik;
using SOLID_Taschenrechner.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
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
            // 1) Jede einzelne Assembly aus dem Ordner "AddIns" laden
            foreach (string datei in Directory.GetFiles(Path.Combine( Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "AddIns")))
            {
                if (Path.GetExtension(datei) == ".dll") // nur managed !!! || Path.GetExtension(datei) == ".exe")
                    Assembly.LoadFrom(datei);
            }

            // 2) Alle Datentypen finden die eine IRechenoperation sind

            IRechneoperation[] alleOperationen = AppDomain.CurrentDomain.GetAssemblies()
                                                                        .Where(x => x.FullName.StartsWith("SOLID"))
                                                                        .SelectMany(x => x.GetTypes())
                                                                        .Where(x => typeof(IRechneoperation).IsAssignableFrom(x) &&
                                                                                    x.IsInterface == false &&
                                                                                    x.IsAbstract == false)
                                                                        .Select(x => (IRechneoperation)Activator.CreateInstance(x))
                                                                        .ToArray();


            IParser parser = new RegexParser();
            IRechner rechner = new ModulRechner(alleOperationen);
            new KonsolenUI(parser,rechner).Start();
        }
    }
}
