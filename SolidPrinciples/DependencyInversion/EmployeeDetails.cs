namespace SolidPrinciples.DependencyInversion
{
    public class EmployeeDetails : IEmployeeDetails
    {
        public int HoursWorked { get; set; }
        
        public int HourlyRate { get; set; }

        private ISalaryCalculator _salaryCalculator;

        public EmployeeDetails(int hoursWorked, int hourlyRate)
        {
            HoursWorked = hoursWorked;
            HourlyRate = hourlyRate;
            _salaryCalculator = SalaryCalculatorFactory.GetSalaryCalculatorObj();
        }
        
        public float GetSalary()
        {  
            return (float) _salaryCalculator.CalculateSalary(HoursWorked, HourlyRate);
        }  
    }
}