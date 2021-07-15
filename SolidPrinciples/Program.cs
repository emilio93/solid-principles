using System;
using System.Collections.Generic;
using SolidPrinciples.DependencyInversion;
using SolidPrinciples.InterfaceSegregation;
using SolidPrinciples.Liskov;
using SolidPrinciples.SR;

namespace SolidPrinciples
{
    class Program
    {
        private static List<Person> getPeople()
        {
            Person person1 = new Person();
            person1.PersonId = 1;
            person1.PersonName = "Juan";

            Person person2 = new Person();
            person2.PersonId = 2;
            person2.PersonName = "Pablo";

            List<Person> people = new List<Person>
            {
                person1,
                person2
            };
            return people;
        }

        private static void testSingleRresponsibility()
        {
            List<Person> people = getPeople();

            foreach (Person person in people)
            {
                Database.InsertPerson(person);
                ReportGenerator.GenerateReport(person);
            }
        }

        private static void testOpenClosed()
        {
            List<Person> people = getPeople();
            var reportGenerators = new List<OpenClosed.IReportGenerator>
            {
                new OpenClosed.PDFReportGenerator(),
                new OpenClosed.CRSReportGenerator(),
            };

            foreach (OpenClosed.IReportGenerator reportGenerator in reportGenerators)
            {
                foreach (Person person in people)
                {
                    reportGenerator.GenerateReport(person);
                }
            }
        }

        private static void testLiskov()
        {
            var employeeList = new List<IEmployeeBase>
            {
                new FreelancerEmployee(),
                new RegularEmployee()
            };

            foreach (IEmployeeBase employee in employeeList)
            {
                Console.WriteLine(employee.GetProjectDetails(1245));
            }
        }

        private static void testInterfaceSegregation()
        {
            var workers = new List<IWorker>
            {
                new FullTimeWorker("1", "Juan", "juan@gmail.com", 10, 200),
                new ContractEmployee("2", "Pablo", "pablo@gmail.com", 2000, 200)
            };

            foreach (IWorker worker in workers)
            {
                Console.WriteLine($"Worker {worker.Id} {worker.Name} {worker.Email}");
            }
        }

        private static void testDependencyInversion()
        {
            var salaryCalculator = SalaryCalculatorFactory.GetSalaryCalculatorObj();
            var employeeDetailsList = new List<IEmployeeDetails>
            {
                new EmployeeDetails(100, 10, salaryCalculator),
                new EmployeeDetails(100, 15, salaryCalculator)
            };

            int i = 0;
            foreach (IEmployeeDetails employeeDetails in employeeDetailsList)
            {
                Console.WriteLine(
                    $"Employee {++i}\n" +
                    $"\tHourlyRate:  {employeeDetails.HourlyRate}\n" +
                    $"\tHoursWorked: {employeeDetails.HoursWorked}\n" +
                    $"\tSalary:      {employeeDetails.GetSalary()}"
                );
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("*** Single Responsibility ***");
            testSingleRresponsibility();

            Console.WriteLine("\n*** Open Closed ***");
            testOpenClosed();

            Console.WriteLine("\n*** Liskov ***");
            testLiskov();

            Console.WriteLine("\n*** Interface Segregation ***");
            testInterfaceSegregation();

            Console.WriteLine("\n*** Dependency Inversion ***");
            testDependencyInversion();

        }
    }
}