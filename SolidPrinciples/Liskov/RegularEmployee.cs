namespace SolidPrinciples.Liskov
{
    public class RegularEmployee : IRegularEmployee
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project(RegularEmployee)";
        }

        public string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee(RegularEmployee)";
        }
    }
}