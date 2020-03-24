using Microsoft.AspNetCore.Http;
using NLog;
using System;
using System.Threading.Tasks;

namespace University.DatabaseEntities
{
    public class ErrorLoggingMiddleware
    {
        private readonly RequestDelegate request;
        private static Logger logger;

        public ErrorLoggingMiddleware(RequestDelegate request)
        {
            logger = LogManager.GetCurrentClassLogger();
            this.request = request;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await request(context);
            }
            catch (Exception e)
            {
                logger.Error(e);
                throw;
            }
        }
    }
}
