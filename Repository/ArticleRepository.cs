using LinqToDB;
using System.Linq;
using System.Collections.Generic;
using ShopBridgeAPI.Interface;
using ShopBridgeAPI.connectors;
using ShopBridgeAPI.Models;

namespace ShopBridgeAPI.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        public ArticleRepository()
        {
        }

        public List<Article> GetAllArticle()
        {
            using (var _connection = new dbConnector())
            {
                return _connection.Article.ToList();
            }
        }
        public Article GetArticleById(long id)
        {
            using (var _connection = new dbConnector())
            {
                return _connection.Article.FirstOrDefault(article => article.Id == id);
            }
        }

        public Article GetArticleByCode(string code)
        {
            using (var _connection = new dbConnector())
            {
                return _connection.Article.FirstOrDefault(article => article.Code == code);
            }
        }

        public long CreateArticle(Article objArticle)
        {
            using( var _connection = new dbConnector())
            {
                return _connection.InsertWithInt64Identity(objArticle);
            }
        }
        public long UpdateArticle(Article objArticle)
        {
            using( var _connection = new dbConnector())
            {
                return _connection.Update(objArticle);
            }
        }
        public long DeleteArticleById(long id)
        {
            using( var _connection = new dbConnector())
            {
                return _connection.Article.Where(project => project.Id == id).Delete();
            }
        }
    }
}