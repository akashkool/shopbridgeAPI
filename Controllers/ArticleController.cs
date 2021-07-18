using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using ShopBridgeAPI.Service.Interface;
using ShopBridgeAPI.Utility;
using ShopBridgeAPI.Models;
using ShopBridgeAPI.Validator;

namespace ShopBridgeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ArticleController : Controller
    {

        static readonly ILogger _logger = Log.ForContext(typeof(ArticleController));
        IArticleService _articleService;
        public ArticleController(IArticleService articleService)
        {
            _articleService = articleService;
        }

        [HttpGet("/gaa")]
        public JsonResult GetAllArticle()
        {   try
            {
                _logger.Information($"Request create to access gaa endpoint");
                var articleData = _articleService.GetAllArticle();
                return Json(new { status = EnumCollection.StatusCode.Success,articleCount = articleData.Count, articleData =  articleData});
            }
            catch(Exception ex)
            {
                _logger.Fatal($"Exception occured while fetching all records {ex}");
            }
            return Json(new { status = EnumCollection.StatusCode.Fail });
        }
        [HttpGet("/gabi")]
        public JsonResult GetArticleById(long id)
        {
            try
            {
                _logger.Information($"Request create to access gabi endpoint");
                var existArticle = _articleService.GetArticleById(id);
                bool notExist =  existArticle == null;
                if(notExist)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, message = $"Record with id {id} doesn't exist in database"});
                var articleData = _articleService.GetArticleById(id);
                return Json(new { status = EnumCollection.StatusCode.Success, articleData =  articleData});
            }
            catch(Exception ex)
            {
                _logger.Fatal($"Exception occured while fetching record for id {id}. Exception : {ex}");
            }
            return Json(new { status = EnumCollection.StatusCode.Fail });
        }
        [HttpPost("/ca")]
        public JsonResult CreateArticle(Article objArticle)
        {
            try
            {
                _logger.Information($"Request create to access ca endpoint");
                Dictionary<string,string> errors;
                bool isValid = ArticleValidator.ValidateArticleModel(objArticle, out errors);
                if(!isValid)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, errors = errors});
                bool isDuplicate = _articleService.GetArticleByCode(objArticle.Code) != null;
                if(isDuplicate)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, message = $"Record with code {objArticle.Code} already exist in database"});
                objArticle.CreateddDate = DateTime.UtcNow;
                var articleId = _articleService.CreateArticle(objArticle);
                return Json(new { status = EnumCollection.StatusCode.Success, articleId =  articleId});
            }
            catch(Exception ex)
            {
                _logger.Fatal($"Exception occured while creating new record with code {objArticle.Code}. Exception : {ex}");
            }
            return Json(new { status = EnumCollection.StatusCode.Fail });
        }
        [HttpPut("/ua")]
        public JsonResult UpdateArticle(Article objArticle)
        {
            try
            {
                _logger.Information($"Request create to access ua endpoint");
                Dictionary<string,string> errors;
                bool isValid = ArticleValidator.ValidateArticleModel(objArticle, out errors);
                if(!isValid)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, errors = errors});
                var existArticle = _articleService.GetArticleByCode(objArticle.Code);
                bool notExist =  existArticle == null;
                if(notExist)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, message = $"Record with code {objArticle.Code} doesn't exist in database"});
                objArticle.Id = existArticle.Id;
                objArticle.UpdatedDate = DateTime.UtcNow;
                var isUpdated = _articleService.UpdateArticle(objArticle);
                return Json(new { status = EnumCollection.StatusCode.Success, objArticle =  objArticle});
            }
            catch(Exception ex)
            {
               _logger.Fatal($"Exception occured while updating record with Id {objArticle.Id}. Exception : {ex}");
            }
            return Json(new { status = EnumCollection.StatusCode.Fail });
        }
        [HttpDelete("/dabi")]
        public JsonResult DeleteArticleById(long id)
        {
            try
            {
                _logger.Information($"Request create to access dabi endpoint");
                 var existArticle = _articleService.GetArticleById(id);
                bool notExist =  existArticle == null;
                if(notExist)
                    return Json(new { status = EnumCollection.StatusCode.ValidationFailed, message = $"Record with id {id} doesn't exist in database"});
                var isDeleted = _articleService.DeleteArticleById(id);
                return Json(new { status = EnumCollection.StatusCode.Success});
            }
            catch(Exception ex)
            {
               _logger.Fatal($"Exception occured while deleting record with Id {id}. Exception : {ex}");
            }
            return Json(new { status = EnumCollection.StatusCode.Fail });
        }
    }
}
