namespace SOLID_Taschenrechner.Model
{
    public interface IRechneoperation
    {
        string Operator { get; }
        int Ausführen(int operand1, int operand2);
    }
}
