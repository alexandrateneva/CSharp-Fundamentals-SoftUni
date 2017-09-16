namespace _3.Dependency_Inversion.Interfaces
{
    public interface IStrategy
    {
        char Operator { get;}
        int Calculate(int firstOperand, int secondOperand);
    }
}