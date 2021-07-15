namespace SolidPrinciples.InterfaceSegregation
{
    public interface IFullTimeWorkerSalary : IWorker
    {
        float HourlyRate { get; set; }

        float HoursInMonth { get; set; }

        float CalculateNetSalary();
    }
}
