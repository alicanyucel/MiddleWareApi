using Microsoft.AspNetCore.Mvc.Filters;

namespace Alican.Middleware
{
    public sealed class LogAttribute :Attribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext context)
        {
            
        }

        public void OnActionExecuting(ActionExecutingContext context)
        {
         
        }
    }
}
