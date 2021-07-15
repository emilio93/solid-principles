namespace SolidPrinciples.Liskov
{
    public class FreelancerEmployee : IEmployeeBase
    {
        public string GetProjectDetails(int employeeId)
        {
            return "Child Project(FreelancerEmployee)";
        }
    }
}