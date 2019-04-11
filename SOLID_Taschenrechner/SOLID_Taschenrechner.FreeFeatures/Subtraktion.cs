using SOLID_Taschenrechner.Model;

namespace SOLID_Taschenrechner.FreeFeatures
{
    public class Subtraktion : IRechneoperation
    {
        public string Operator => "-";
        public int Ausführen(int operand1, int operand2) => operand1 - operand2;
    }
}
