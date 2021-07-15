namespace SolidPrinciples.DependencyInversion
{
    public interface ISalaryCalculator
    {
        float CalculateSalary(int hoursWorked, float hourlyRate);
    }
}
