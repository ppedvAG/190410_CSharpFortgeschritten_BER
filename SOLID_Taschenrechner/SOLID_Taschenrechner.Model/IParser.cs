namespace SOLID_Taschenrechner.Model
{
    public interface IParser
    {
        Formel Parse(string input);
    }
}
