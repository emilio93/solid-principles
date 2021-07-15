namespace SolidPrinciples.DependencyInversion
{
    public interface IEmployeeDetails
    {
        int HoursWorked { get; set; }

        int HourlyRate { get; set; }

        float GetSalary();
    }
}
