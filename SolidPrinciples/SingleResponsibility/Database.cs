using System;

namespace SolidPrinciples.SR
{
    // SR is to handle database connection.
    public class Database
    {
        public bool InsertPerson(Person person)
        {
            ConnectToDatabase();
            // insert person in database.
            Console.WriteLine("Inserted person in database.");
            CloseDatabaseConnection();
            return true;
        }

        private bool ConnectToDatabase()
        {
            // create connection to database.
            Console.WriteLine("Conected to database.");
            return true;
        }

        private bool CloseDatabaseConnection()
        {
            // close database connection.
            Console.WriteLine("Closed database connection.");
            return true;
        }

    }
}