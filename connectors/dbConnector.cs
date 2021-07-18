using System;
using LinqToDB;
using ShopBridgeAPI.Models;

namespace ShopBridgeAPI.connectors
{
    public class dbConnector : LinqToDB.Data.DataConnection
    {   
        public dbConnector() : base(ProviderName.PostgreSQL,Environment.GetEnvironmentVariable("db_connection")) 
        {

        }
        public ITable<Article> Article => GetTable<Article>();
    }
}