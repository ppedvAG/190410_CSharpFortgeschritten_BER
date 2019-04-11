using SOLID_Taschenrechner.Model;
using System;
using System.Linq;

namespace SOLID_Taschenrechner.Logik
{
    public class ModulRechner : IRechner
    {
        public ModulRechner(params IRechneoperation[] rechenoperationen) //ToDo: params
        {
            this.rechenoperationen = rechenoperationen;
        }
        private readonly IRechneoperation[] rechenoperationen;

        public int Berechne(Formel formel)
        {
            IRechneoperation auszuführendeOperation = rechenoperationen.FirstOrDefault(x => x.Operator == formel.Operator);

            if (auszuführendeOperation is null)
                throw new InvalidOperationException($"Die Rechenoperation für den Operator {formel.Operator} wird nicht unterstützt");
            else
                return auszuführendeOperation.Ausführen(formel.Operand1, formel.Operand2);
        }
    }
}
