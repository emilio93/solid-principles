namespace SolidPrinciples.InterfaceSegregation
{
    public interface IContractWorkerSalary : IWorker
    {
        float MonthlySalary { get; set; }
        float OtherBenefits { get; set; }

        float CalculateWorkedSalary();
    }
}
