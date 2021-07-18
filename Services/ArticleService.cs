using System;
using System.Collections.Generic;
using ShopBridgeAPI.Service.Interface;
using Microsoft.Extensions.Logging;
using ShopBridgeAPI.Interface;
using ShopBridgeAPI.Models;

namespace ShopBridgeAPI.Service
{
    public class ArticleService : IArticleService
    {
        IArticleRepository _articleRepository;

        public ArticleService(IArticleRepository articleRepository)
        {
            _articleRepository = articleRepository;
        }

         public List<Article> GetAllArticle()
        {
            return _articleRepository.GetAllArticle();
        }
        public Article GetArticleById(long id)
        {
            return _articleRepository.GetArticleById(id);
        }
        public Article GetArticleByCode(string code)
        {
            return _articleRepository.GetArticleByCode(code);
        }
        public long CreateArticle(Article objArticle)
        {
           return _articleRepository.CreateArticle(objArticle);
        }
        public long UpdateArticle(Article objArticle)
        {
            return _articleRepository.UpdateArticle(objArticle);
        }
        public long DeleteArticleById(long id)
        {
            return _articleRepository.DeleteArticleById(id);
        }
    }
}

