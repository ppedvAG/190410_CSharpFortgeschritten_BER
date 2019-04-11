using SOLID_Taschenrechner.Model;
using System;

namespace SOLID_Taschenrechner.Logik
{
    public class SimplerRechner : IRechner
    {
        public int Berechne(Formel formel)
        {
            if (formel.Operator == "+") // Entscheidungsfindung "welche rechenart"
                return formel.Operand1 + formel.Operand2; // Berechnung
            else if (formel.Operator == "-") // Entscheidungsfindung "welche rechenart"
                return formel.Operand1 - formel.Operand2; // Berechnung 
            // ...
            else
                throw new ArgumentException("Operator ist unbekannt");
        }
    }
}
