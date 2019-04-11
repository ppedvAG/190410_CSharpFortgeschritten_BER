using SOLID_Taschenrechner.Model;
using System;

namespace SOLID_Taschenrechner.PaidFeatures
{
    public class Multiplikation : IRechneoperation
    {
        public string Operator => "*";
        public int Ausführen(int operand1, int operand2) => operand1 * operand2;
    }
}
