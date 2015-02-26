using System;

namespace Spike.MongoDb
{
    public class MongoDbAccessException : Exception
    {
        public MongoDbAccessException(string message)
            :base(message)
        {
            
        }
    }
}