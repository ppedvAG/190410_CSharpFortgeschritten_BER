using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Attribut_Demo
{
    
    class MeineKlasse
    {
        [Obsolete("Bitte verwende stattdessen XYZ",true)]
        public void Methode1()
        {

        }
        public void XYZ()
        {

        }
    }

    [Flags]
    enum Wochentag
    {
        Montag      = 1,
        Dienstag    = 2,
        Mittwoch    = 4,
        Donnerstag  = 8,
        Freitag     = 16,
        Samstag     = 32,
        Sonntag     = 64,
    }

    // Weitere vordefinierte Attribute: [Serializable], [XMLRoot]
}
