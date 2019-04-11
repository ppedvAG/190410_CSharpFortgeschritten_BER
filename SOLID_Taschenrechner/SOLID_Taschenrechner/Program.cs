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



    class StringSplitParser : IParser
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
    class RegexParser : IParser
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

    class SimplerRechner : IRechner
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
    class ModulRechner : IRechner
    {
        public ModulRechner(params IRechneoperation[] rechenoperationen) //ToDo: params
        {
            this.rechenoperationen = rechenoperationen;
        }
        private readonly IRechneoperation[]  rechenoperationen;

        public int Berechne(Formel formel)
        {
            IRechneoperation auszuführendeOperation = rechenoperationen.FirstOrDefault(x => x.Operator == formel.Operator);

            if (auszuführendeOperation is null)
                throw new InvalidOperationException($"Die Rechenoperation für den Operator {formel.Operator} wird nicht unterstützt");
            else
                return auszuführendeOperation.Ausführen(formel.Operand1, formel.Operand2);
        }
    }



    class Addition : IRechneoperation
    {
        public string Operator => "+";
        public int Ausführen(int operand1, int operand2) => operand1 + operand2;
    }
    class Subtraktion : IRechneoperation
    {
        public string Operator => "-";
        public int Ausführen(int operand1, int operand2) => operand1 - operand2;
    }
}
