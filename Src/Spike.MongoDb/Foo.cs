using MongoDB.Bson;

namespace Spike.MongoDb
{
    public class Foo
    {
        public ObjectId Id { get; set; }
        public BsonDocument Properties { get; set; }
    }
}