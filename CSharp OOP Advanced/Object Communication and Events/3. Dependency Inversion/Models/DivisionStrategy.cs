namespace _3.Dependency_Inversion.Models
{
    using _3.Dependency_Inversion.Interfaces;

    public class DivisionStrategy : IStrategy
    {
        public DivisionStrategy()
        {
            this.Operator = '/';
        }

        public char Operator { get; private set; }

        public int Calculate(int firstOperand, int secondOperand)
        {
            return firstOperand / secondOperand;
        }
    }
}
