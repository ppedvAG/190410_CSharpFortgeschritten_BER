using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Attribut_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Vordefinierte Attribute
            ////MeineKlasse k = new MeineKlasse();
            ////k.Methode1();

            //Wochentag heute = Wochentag.Donnerstag;

            //Wochentag wecker = Wochentag.Montag;

            //// Bitmasken 0000_0000
            //// 0000_0001 => 1
            //// 0000_0010 => 2
            //wecker |= Wochentag.Dienstag;
            //wecker |= Wochentag.Mittwoch;
            //wecker |= Wochentag.Donnerstag;
            //wecker |= Wochentag.Freitag;

            //Console.WriteLine(wecker);

            //if(wecker.HasFlag(Wochentag.Mittwoch))
            //    Console.WriteLine("Wecker läutet am Mittwoch"); 
            #endregion

            // Attribut der Klasse auslesen:
            Type personenType = typeof(Person);
            object[] attributes = personenType.GetCustomAttributes(true);

            // Attribut des Properties auslesen:
            PropertyInfo vornamePropertyInfo =  personenType.GetProperty("Vorname");
            object[] vornameAttributes = vornamePropertyInfo.GetCustomAttributes(true);

            Person p = new Person { Vorname = "Tom", Nachname = "Ate", Alter = 10, Kontostand = 100 };

            if(p.Validate())
            {
                // mach weiter
                Console.WriteLine("Validierung erfolgreich");

            }
            else
            {
                Console.WriteLine("Validierung fehlgeschlagen");
            }


            Console.WriteLine("---ENDE😘😘😘---");
            Console.ReadKey();
        }
    }
}
