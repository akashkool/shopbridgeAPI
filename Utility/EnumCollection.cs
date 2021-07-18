
namespace ShopBridgeAPI.Utility
{

    public class EnumCollection
    {
        public enum StatusCode
        {
            Success = 200,
            Fail = 400,
            ValidationFailed = 405,
            NotAcceptable = 406,
            InvalidFormData = 105,
            UnAuthorised = 401,
        }
    }

}