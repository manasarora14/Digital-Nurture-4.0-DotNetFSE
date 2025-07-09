using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace CustomEmployeeApi.Filters
{
    public class CustomExceptionFilter : IExceptionFilter
    {
        public void OnException(ExceptionContext context)
        {
            string errorPath = Path.Combine(Directory.GetCurrentDirectory(), "logs.txt");
            File.AppendAllText(errorPath, $"[{DateTime.Now}] Exception: {context.Exception.Message}\n");

            context.Result = new ObjectResult("An unexpected error occurred")
            {
                StatusCode = 500
            };
        }
    }
}
