using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ErweiterungsmethodenUndOperatorüberladung
{
    class Bruch
    {
        public Bruch(int zähler, int nenner)
        {
            Zähler = zähler;
            Nenner = nenner;
        }

        public int Zähler { get; set; }
        public int Nenner { get; set; }

        // Operatoren
        
        // Arithmetische Operatoren:
        // +,-,*,/,%, ++, --
        // -> +=, -= wird automatisch mitüberladen

        // Bit Operatoren
        // &,|,^,~,<<,>>
        // &=, |= ... ebenfalls

        // Vergleichsoperatoren
        // ==, !=, <=, >=, <, >
        // Achtung: Paarweise überladen: Wenn man == überladet, MUSS man auch != überladen

        // Nicht Überladbar: Verknüpfungsoperatoren wie &&, || 

        public static Bruch operator *(Bruch left, Bruch right)
        {
            return new Bruch(left.Zähler * right.Zähler, left.Nenner * right.Nenner);
        }
        public static Bruch operator /(Bruch left, Bruch right)
        {
            return new Bruch(left.Zähler * right.Nenner, left.Nenner * right.Zähler);
        }
    }
}
