namespace SolidPrinciples.DependencyInversion
{
    public class SalaryCalculator : ISalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate) {
            return hoursWorked * hourlyRate;
        }
    }
}