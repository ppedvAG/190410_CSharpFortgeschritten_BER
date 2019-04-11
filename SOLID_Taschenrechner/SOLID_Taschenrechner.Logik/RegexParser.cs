using SOLID_Taschenrechner.Model;
using System;
using System.Text.RegularExpressions;

namespace SOLID_Taschenrechner.Logik
{
    public class RegexParser : IParser
    {
        public Formel Parse(string input)
        {
            Regex regex = new Regex(@"\s*(\d+)\s*(\S+)\s*(\d+)\s*");
            Match result = regex.Match(input);
            if (result.Success)
            {
                Formel formel = new Formel();
                formel.Operand1 = Convert.ToInt32(result.Groups[1].Value);
                formel.Operator = result.Groups[2].Value;
                formel.Operand2 = Convert.ToInt32(result.Groups[3].Value);
                return formel;
            }
            else
                throw new ArgumentException("Die eingegebene Formel ist ungültig");
        }
    }
}
