using MongoDB.Bson;
using MongoDB.Driver;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            MongoClient client = new MongoClient();
            var server = client.GetServer();
            var db = server.GetDatabase("LibraryDB");
            var collection = db.GetCollection<BookStore>("BookStore");

            BookStore bookStore = new BookStore
            {
                BookTitle = "MongoDB Basics",
                ISBN = "1234532455432",
                Auther = "TAbya",
                Category = "NoSQL DBMS"
            };
            collection.Save(bookStore);
        }

        public class BookStore
        {
            public ObjectId Id { get; set; }

            public string BookTitle { get; set; }

            public string Auther { get; set; }

            public string Category { get; set; }

            public string ISBN { get; set; }
        }
    }
}