using StructureMap;
using Microsoft.AspNetCore.Http;
using ShopBridgeAPI.Service;
using ShopBridgeAPI.Interface;
using ShopBridgeAPI.Service.Interface;
using ShopBridgeAPI.Repository;

namespace ShopBridgeAPI.Register
{
    public class ServiceRegistrar : Registry
    {  
        public ServiceRegistrar()
        {
            For<IArticleService>().Use<ArticleService>();
            For<IArticleRepository>().Use<ArticleRepository>();
        }

    }
}