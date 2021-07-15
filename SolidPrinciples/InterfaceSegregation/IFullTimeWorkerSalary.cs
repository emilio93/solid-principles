namespace SolidPrinciples.InterfaceSegregation
{
    interface IFullTimeWorkerSalary : IWorker
    {
        public float HourlyRate { get; set; }

        public float HoursInMonth { get; set; }

        public float CalculateNetSalary();
    }
}
