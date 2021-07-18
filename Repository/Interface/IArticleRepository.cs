using System.Collections.Generic;
using ShopBridgeAPI.Models;

namespace ShopBridgeAPI.Interface
{
    public interface IArticleRepository
    {
        List<Article> GetAllArticle();
        Article GetArticleById(long id);
        Article GetArticleByCode(string code);
        long CreateArticle(Article objArticle);
        long UpdateArticle(Article objArticle);
        long DeleteArticleById(long id);
    }
}