using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Threading.Tasks;

namespace WritersLtd.API.Filters
{
    public class ApiKeyAuthenticationAttribute : Attribute, IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            if (context is null) throw new ArgumentNullException(nameof(context));

            var queryStringApiKey = context.HttpContext.Request.Query["apikey"];
            var configApiKey = context.HttpContext.RequestServices.GetRequiredService<IConfiguration>().GetValue<string>("ApiKey");
            
            if (string.IsNullOrWhiteSpace(queryStringApiKey) || queryStringApiKey != configApiKey)
            {
                context.Result = new UnauthorizedResult();
                return;
            }
            await next();
        }
    }
}
