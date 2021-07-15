using System;

namespace SolidPrinciples.InterfaceSegregation
{
    public class FullTimeWorker : IFullTimeWorkerSalary
    {
        public string Id { get; set; }
        
        public string Name { get; set; }
        
        public string Email { get; set; }
        
        public float HourlyRate { get; set; }
        
        public float HoursInMonth { get; set; }
        
        public FullTimeWorker(
            string id,
            string name,
            string email,
            float hourlyRate,
            float hoursInMonth
        )
        {
            Id = id;
            Name = name;
            Email = email;
            HourlyRate = hourlyRate;
            HoursInMonth = hoursInMonth;
        }

        public float CalculateNetSalary() => HourlyRate * HoursInMonth;        
    }
}