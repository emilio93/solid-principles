using SolidPrinciples.SR;
using System;

namespace SolidPrinciples.OpenClosed
{
    public interface IReportGenerator
    {
        void GenerateReport(Person person);
    }
}