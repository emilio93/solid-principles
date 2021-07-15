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
                person.InsertPerson(person);
                person.getReport(person);
            }
        }

        private static void testOpenClosed()
        {
            List<Person> people = getPeople();
            var reportGenerators = new List<OpenClosed.ReportGenerator>
            {
                new OpenClosed.PDFReportGenerator(),
                new OpenClosed.CRSReportGenerator(),
            };

            foreach (OpenClosed.ReportGenerator reportGenerator in reportGenerators)
            {
                foreach (Person person in people)
                {
                    reportGenerator.GenerateReport(person);
                }
            }
        }

        private static void testLiskov()
        {
            List<EmployeeBase> employeeList = new List<EmployeeBase>
            {
                new FreelancerEmployee(),
                new RegularEmployee()
            };

            foreach (EmployeeBase employee in employeeList)
            {
                Console.WriteLine(employee.GetEmployeeDetails(1245));
            }
        }

        private static void testInterfaceSegregation()
        {
            List<IWorker> workers = new List<IWorker>
            {
                new FullTimeWorker("1", "Juan", "juan@gmail.com", 10, 200),
                new ContractEmployee("1", "Pablo", "pablo@gmail.com", 2000, 200)
            };

            foreach (IWorker worker in workers)
            {
                Console.WriteLine($"Salario {worker.Name}: {worker.GetSalary()}");
            }
        }

        private static void testDependencyInversion()
        {
            List<IEmployeeDetails> employeeDetailsList = new List<IEmployeeDetails>
            {
                new EmployeeDetails(100, 10),
                new EmployeeDetails(100, 15)
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