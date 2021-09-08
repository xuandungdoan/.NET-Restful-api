using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UserManagement.Models;

namespace UserManagement.Repositories
{
    public class MongoDbUserRepository : IUserRepository
    {
        private readonly IMongoCollection<User> mongoUserCollection;
        private readonly string databaseName = "UserManagement";
        private readonly string collectionName = "User";
        private readonly FilterDefinitionBuilder<User> filter = Builders<User>.Filter;
        public MongoDbUserRepository(IMongoClient mongoClient)
        {
            mongoUserCollection = mongoClient.GetDatabase(databaseName).GetCollection<User>(collectionName);
        }

        public void CreateUser(User user)
        {
            mongoUserCollection.InsertOne(user);
        }

        public void DeleteUser(Guid Id)
        {
            mongoUserCollection.DeleteOne(filter.Eq(user => user.Id, Id);
        }

        public User GetUser(Guid Id)
        {
            return mongoUserCollection.Find(Builders<User>.Filter.Eq("Id", Id)).SingleOrDefault();
        }

        public IEnumerable<User> GetUsers()
        {
            return mongoUserCollection.Find(new BsonDocument()).ToList();
        }
    }
}
