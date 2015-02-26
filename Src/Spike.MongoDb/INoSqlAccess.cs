using MongoDB.Bson;

namespace Spike.MongoDb
{
    public interface INoSqlAccess
    {
        void Open();
        void Close();
        void Add(Foo entity);
        BsonDocument Read(int id);
    }
}