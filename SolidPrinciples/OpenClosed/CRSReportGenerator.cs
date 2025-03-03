using SolidPrinciples.SR;
using System;

namespace SolidPrinciples.OpenClosed
{
    public class CRSReportGenerator : IReportGenerator
    {
        public void GenerateReport(Person person)
        {
            // Report generation with person data in Crystal Report.
            Console.WriteLine($"CRS Report:\n\t{person.PersonId}\n\t{person.PersonName}");
        }
    }
}