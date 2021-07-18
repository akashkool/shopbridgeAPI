using System;
using System.Linq;
using System.Collections.Generic;
using ShopBridgeAPI.Models;
using ShopBridgeAPI.Utility;

namespace ShopBridgeAPI.Validator
{
    public static class ArticleValidator
    {
        private static Random random = new Random();
        // RandomString generates random hash for provided length which is alphanumeric in nature.
        public static bool ValidateArticleModel(Article objArticle, out Dictionary<string,string> errors)
        {
            errors = new Dictionary<string,string>();
            bool isValid = true;

            if(string.IsNullOrEmpty(objArticle.Code))
                errors.Add("code","code is null or empty");
            else if(!StringUtility.IsAlphaNumberic(objArticle.Code))
                errors.Add("code","code is not aphanumeric");

            if(string.IsNullOrEmpty(objArticle.Name))
                errors.Add("name","name is null or empty");
            else if(!StringUtility.IsAlphaNumbericWithSpaceSpecialChar(objArticle.Name))
                errors.Add("name","name is not aphanumeric");

            if(objArticle.Price < 1)
                errors.Add("price","price has invalid value");
            if(objArticle.Count < 1)
                errors.Add("count","count has invalid value");

            isValid  = errors.Count == 0 ? true : false;

            return isValid;

        }
    }
}