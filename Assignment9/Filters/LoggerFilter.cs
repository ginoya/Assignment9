using Microsoft.AspNetCore.Mvc.Filters;

namespace Assignment9.Filters
{
    public class LoggerFilter : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            foreach (var parameter in context.ActionArguments)
            {
                Console.WriteLine($"Inside Filter OnActionExecuting - {parameter.Key}: {parameter.Value}");
            }
        }

        public override void OnActionExecuted(ActionExecutedContext context)
        {
            Console.WriteLine("Inside Filter OnActionExecuted");
        }
    }
}
