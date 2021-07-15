namespace SolidPrinciples.DependencyInversion
{
    interface ISalaryCalculator
    {
        public float CalculateSalary(int hoursWorked, float hourlyRate);
    }
}
