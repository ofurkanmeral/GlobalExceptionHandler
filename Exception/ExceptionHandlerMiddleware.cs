using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiddleeareHandling_ExceptionAndLogging.Exception
{
    public class ExceptionHandlerMiddleware
    {
        private readonly RequestDelegate next;
        private readonly ILogger<ExceptionHandlerMiddleware> logger;

        public ExceptionHandlerMiddleware(RequestDelegate _next, ILogger<ExceptionHandlerMiddleware> _logger)
        {
            next = _next;
            logger = _logger;
        }

       

        public async Task Invoke(HttpContext httpContext)
        {
            try
            {
                await next.Invoke(httpContext);
            }
            catch (System.Exception ex)
            {
                logger.LogError(ex.Message.ToString());
                throw;
            }
        }
    }
}
