using System.Collections.Generic;
using ShopBridgeAPI.Models;

namespace ShopBridgeAPI.Service.Interface
{
    public interface IArticleService
    {
        List<Article> GetAllArticle();
        Article GetArticleById(long id);
        Article GetArticleByCode(string code);
        long CreateArticle(Article objArticle);
        long UpdateArticle(Article objArticle);
        long DeleteArticleById(long id);

    }
}