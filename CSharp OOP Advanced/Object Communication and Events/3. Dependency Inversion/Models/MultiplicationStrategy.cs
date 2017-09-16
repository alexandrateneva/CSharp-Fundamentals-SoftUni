namespace _3.Dependency_Inversion.Models
{
    using _3.Dependency_Inversion.Interfaces;

    public class MultiplicationStrategy : IStrategy
    {
        public MultiplicationStrategy()
        {
            this.Operator = '*';
        }

        public char Operator { get; private set; }

        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand * secondOperand;
        }
    }
}
