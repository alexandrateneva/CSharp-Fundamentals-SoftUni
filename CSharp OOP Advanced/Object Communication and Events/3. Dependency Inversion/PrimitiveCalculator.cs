namespace _3.Dependency_Inversion
{
    using System;
    using System.Linq;
    using System.Reflection;
    using _3.Dependency_Inversion.Interfaces;

    public class PrimitiveCalculator
    {
        public int FirstOperand { get; private set; }
        public int SecondOperand { get; private set; }
        public char Operator { get; private set; }

        public PrimitiveCalculator(int firstOperand, int secondOperand, char @operator)
        {
            this.FirstOperand = firstOperand;
            this.SecondOperand = secondOperand;
            this.Operator = @operator;
        }

        public IStrategy ChangeStrategy(char @operator)
        {
            var strategies = from t in Assembly.GetEntryAssembly().GetTypes()
                where t.GetInterfaces().Contains(typeof(IStrategy))
                      && t.GetConstructor(Type.EmptyTypes) != null
                select Activator.CreateInstance(t) as IStrategy;

            var strategy = strategies.FirstOrDefault(s => s.Operator == @operator);
        
            return strategy;
        }

        public int PerformCalculation()
        {
            var strategy = this.ChangeStrategy(this.Operator);

            return strategy.Calculate(this.FirstOperand, this.SecondOperand);
        }
    }
}
