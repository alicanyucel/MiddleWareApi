using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace Alican.Models
{
    public sealed class MyAuthorize :Attribute, IAuthorizationFilter
    {
        public  void OnAuthorization(AuthorizationFilterContext context)
        {
            string? secretKey = context.HttpContext.Request.Headers.FirstOrDefault(p => p.Key == "SecretKey").Value;
            if(string.IsNullOrEmpty(secretKey) && secretKey !="My Secret")
            {
                context.Result=new UnauthorizedResult();

            }
        }
    }
}
