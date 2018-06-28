using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);
            var server = client.GetServer();

            var database = server.GetDatabase("LibraryDB");
            List<string> dbs = new List<string>(server.GetDatabaseNames());
            foreach (var dbName in dbs)
            {
                Console.WriteLine(dbName);
            }
            Console.ReadLine();
        }
    }
}
