using System;

namespace SolidPrinciples.SR
{
    // SR is to handle database connection.
    public class Database
    {
        public static bool InsertPerson(Person person)
        {
            ConnectToDatabase();
            // insert person in database.
            Console.WriteLine("Inserted person in database.");
            CloseDatabaseConnection();
            return true;
        }

        private static bool ConnectToDatabase()
        {
            // create connection to database.
            Console.WriteLine("Conected to database.");
            return true;
        }

        private static bool CloseDatabaseConnection()
        {
            // close database connection.
            Console.WriteLine("Closed database connection.");
            return true;
        }

    }
}