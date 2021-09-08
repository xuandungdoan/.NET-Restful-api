using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UserManagement.Settings
{
    public class MongoDbSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }

        public string UriConnection
        {
            get
            {
                return $"mongodb://{Host}:{Port}";
            }

        }
    }
}
