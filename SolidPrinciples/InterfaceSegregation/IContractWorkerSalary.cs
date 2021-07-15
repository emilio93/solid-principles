namespace SolidPrinciples.InterfaceSegregation
{
    interface IContractWorkerSalary : IWorker
    {
        public float CalculateWorkedSalary();
    }
}
