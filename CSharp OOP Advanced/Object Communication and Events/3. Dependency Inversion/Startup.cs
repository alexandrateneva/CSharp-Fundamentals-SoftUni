namespace _3.Dependency_Inversion
{
    using System;
    using System.Linq;

    public class Startup
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToList();
            var currentStrategySymbol = '+';

            while (input[0] != "End")
            {
                if (input[0] == "mode")
                {
                    currentStrategySymbol = input[1][0];
                }
                else
                {
                    var numbers = input.Select(int.Parse).ToList();
                    var calculator = new PrimitiveCalculator(numbers[0], numbers[1], currentStrategySymbol);
                    Console.WriteLine(calculator.PerformCalculation());
                }

                input = Console.ReadLine().Split().ToList();
            }
        }
    }
}
