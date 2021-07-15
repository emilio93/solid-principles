namespace SolidPrinciples.DependencyInversion
{
    class SalaryCalculatorFactory
    {
        public static ISalaryCalculator GetSalaryCalculatorObj()
        {
            return new SalaryCalculator();
        }
    }
}
