using SolidPrinciples.SR;
using System;

namespace SolidPrinciples.OpenClosed
{
    public abstract class ReportGenerator
    {
        public string ReportType { get; set; }

        public virtual void GenerateReport(Person person)
        {
            // defaults to console generation report.
            Console.WriteLine($"{person.PersonId} {person.PersonName}");
        }
    }
}