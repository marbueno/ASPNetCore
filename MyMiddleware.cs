using Microsoft.AspNetCore.Http;
using System;
using System.Threading.Tasks;

namespace ASPNetCore
{
    public class MyMiddleware
    {
        private RequestDelegate _next;

        public MyMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            //Request

            var inicio = DateTime.Now;

            await _next(context);

            var final = DateTime.Now;

            var dif = final.Subtract(inicio);

            await context.Response.WriteAsync($"Tempo de execucao: {dif.TotalMilliseconds}");
        }

    }
}