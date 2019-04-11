using SOLID_Taschenrechner.Model;
using System;

namespace SOLID_Taschenrechner.Logik
{
    public class StringSplitParser : IParser
    {
        public Formel Parse(string input)
        {
            string[] operanden = input.Split(); // Leerzeichen
            Formel result = new Formel();

            result.Operand1 = Convert.ToInt32(operanden[0]);
            result.Operand2 = Convert.ToInt32(operanden[2]);
            result.Operator = operanden[1];

            return result;
        }
    }
}
