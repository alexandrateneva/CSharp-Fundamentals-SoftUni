namespace _3.Dependency_Inversion.Models
{
    using _3.Dependency_Inversion.Interfaces;

    public class SubtractionStrategy : IStrategy
    {
        public SubtractionStrategy()
        {
            this.Operator = '-';
        }

        public char Operator { get; private set; }

        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand - secondOperand;
        }
    }
}
