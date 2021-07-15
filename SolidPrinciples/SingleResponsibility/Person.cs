namespace SolidPrinciples.SR
{
    // Single responsibility is to represent a person.
    public class Person
    {
        public int PersonId { get; set; }
        public string PersonName { get; set; }
        private Database _database{ get; set; }
        private ReportGenerator _reportGenerator { get; set; }

        public Person()
        {
        }

        public bool InsertPerson(Person person)
        {
            _database = new Database();
            // Insert person in a database table thrugh another class.
            // Doesn't need to know details of the database.
            return _database.InsertPerson(person);
        }
        
        public void getReport(Person person)
        {
            _reportGenerator = new ReportGenerator();
          // Generate report thrugh a report generator.
          // Doesn't need to know how the report is generated.
          _reportGenerator.GenerateReport(person);
        }
    }
}