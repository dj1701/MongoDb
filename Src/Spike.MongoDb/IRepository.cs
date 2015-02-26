using System;
using MongoDB.Bson;

namespace Spike.MongoDb
{
    public interface IRepository : IDisposable
    {
        void Open();
        void Close();
        void Add(Foo entity);
        BsonDocument Read(int id);
    }
}