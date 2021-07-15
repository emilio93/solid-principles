using SolidPrinciples.SR;
using System;

namespace SolidPrinciples.OpenClosed
{
    public class PDFReportGenerator : ReportGenerator
    {
        public override void GenerateReport(Person person)
        {
            // Report generation with person data in PDF.
            Console.WriteLine($"PDF Report:\n\t{person.PersonId}\n\t{person.PersonName}");
        }
    }
}