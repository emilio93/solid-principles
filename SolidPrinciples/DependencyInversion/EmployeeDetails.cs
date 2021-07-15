namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails : IEmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }

        private ISalaryCalculator _salaryCalculator;

        public EmployeeDetails(int hoursWorked, int hourlyRate, ISalaryCalculator salaryCalculator)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            _salaryCalculator = salaryCalculator;
        }
        
        public float GetSalary()
        {  
            return (float) _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }  
    }
}