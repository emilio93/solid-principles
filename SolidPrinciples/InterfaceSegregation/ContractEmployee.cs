using System;

namespace SolidPrinciples.InterfaceSegregation
{
    public class ContractEmployee : IContractWorkerSalary
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public float MonthlySalary { get; set; }
        
        public float OtherBenefits { get; set; }
        
        public ContractEmployee(
            string id, 
            string name, 
            string email,
            float monthlySalary,
            float otherBenefits
        )
        {
            Id = id;
            Name = name;
            Email = email;
            MonthlySalary = monthlySalary;
            OtherBenefits = otherBenefits;
        }
        
        public float CalculateWorkedSalary() => MonthlySalary + OtherBenefits;
    }
}