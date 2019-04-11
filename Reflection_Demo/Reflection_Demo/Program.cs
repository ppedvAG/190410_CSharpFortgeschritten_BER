using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            //int zahl = 42;
            //Type intType = zahl.GetType();
            //Console.WriteLine(intType);

            //// Neue Objekte basierend auf Typeninformation erstellen:
            //object instanz = Activator.CreateInstance(typeof(StringBuilder));
            //Console.WriteLine(instanz);
            //Console.WriteLine(instanz.GetType());

            // Assembly (.dll oder .exe) zur Laufzeit laden:
            Assembly demoAssembly = Assembly.LoadFrom("Demo.dll");
            // Type[] types = demoAssembly.GetTypes(); // <--- ALle
            Type taschenrechnerType = demoAssembly.GetType("Demo.Taschenrechner");

            // Instanz von einem Objekt aus einer fremden Assembly erstellen
            object taschenrechnerInstanz = Activator.CreateInstance(taschenrechnerType);

            // Methode auf der Instanz ausführen
            MethodInfo addMethodInfo =  taschenrechnerType.GetRuntimeMethod("Add", new Type[] { typeof(int), typeof(int) });
            var result  = addMethodInfo.Invoke(taschenrechnerInstanz, new object[] { 12, 55 });

            // Statische Klasse: von einer statischen Klasse eine Methode aufrufen (Convert.ToInt32)
            // typeof(StatischeKlasse) -> statische Methode wird aufgerufen
            // var result  = addMethodInfo.Invoke(typeof(Convert), new object[] { 12, 55 });
            Console.WriteLine(result);

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
