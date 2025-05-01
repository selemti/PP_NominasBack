using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using Microsoft.Extensions.Configuration;
using MongoDB.Driver;

namespace PP_NominasBack.Services
{
    public class MongoDbService

    {
       public static IMongoDatabase GetDatabase(IConfiguration config)
        {
            var settings = config.GetSection("MongoConnection");
            var client = new MongoClient(settings["ConnectionString"]);
            return client.GetDatabase(settings["Database"]);
        }
    }
}