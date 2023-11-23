using Assignment9.Filters;
using Microsoft.AspNetCore.Mvc;

namespace Assignment9.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        [HttpGet]
        [LoggerFilter]
        public string TestFilter(string testFilter, int a)
        {
            Console.WriteLine("Inside Home Controller");
            return $"Hello World - {testFilter} - {a}";
        }
    }
}
