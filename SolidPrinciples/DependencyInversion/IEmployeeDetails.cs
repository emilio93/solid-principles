namespace SolidPrinciples.DependencyInversion
{
    interface IEmployeeDetails
    {
        public int HoursWorked { get; set; }

        public int HourlyRate { get; set; }

        public float GetSalary();
    }
}
