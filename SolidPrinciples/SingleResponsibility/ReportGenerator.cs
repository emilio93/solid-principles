using System;

namespace SolidPrinciples.SR
{
    public class ReportGenerator
    {
        public bool GenerateReport(Person person)
        {
            // Generate report.
            Console.WriteLine(
                $"Report:\n\tPersonId {person.PersonId}\n\tPersonName {person.PersonName}"
            );
            return true;
        }
    }
}