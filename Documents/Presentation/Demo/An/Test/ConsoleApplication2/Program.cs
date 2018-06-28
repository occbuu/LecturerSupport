using MongoDB.Bson;
using MongoDB.Driver;
using MongoDB.Driver.Builders;
using System;
namespace MongoDBLab
{
    public class Entity
    {
        public ObjectId Id { get; set; }

        public string Name { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // Lấy tham chiếu tới đối tượng client
            var connectionString = "mongodb://localhost:27017";
            var client = new MongoClient(connectionString);

            // Lấy 1 tham chiếu tới đối tượng Server
            var server = client.GetServer();

            // Lấy 1 tham chiếu tới đối tượng database
            var database = server.GetDatabase("test");

            // Lấy 1 tham chiếu tới đố tượng Collection
            var collection = database.GetCollection<Entity>("entities");

            // Thêm 1 đối tượng
            Entity entity = new Entity() { Name = "entity 1" };
            collection.Insert(entity);

            var id = entity.Id;
            var query = Query<Entity>.EQ(e => e.Id, id);
            var update = Update<Entity>.Set(e => e.Name, "XXX");

            //collection.Update(query, update);
            //collection.Remove(query);
            collection.Save(query);

            Console.WriteLine("Press any key to stop.");
            Console.ReadKey();
        }
    }
}