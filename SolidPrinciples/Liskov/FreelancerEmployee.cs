using System;

namespace SolidPrinciples.Liskov
{
    public class FreelancerEmployee : EmployeeBase
    {
        public override string GetProjectDetails(int employeeId)
        {
            return "Child Project(FreelancerEmployee)";
        }
        
        public override string GetEmployeeDetails(int employeeId)
        {
            return "Child Employee(FreelancerEmployee)";
        }
    }
}