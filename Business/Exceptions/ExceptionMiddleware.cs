using Business.Exceptions.Types;
using FluentValidation;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Business.Exceptions
{
    public class ExceptionMiddleware
    {
        private readonly RequestDelegate _next;

        public ExceptionMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception exception)
            {
                if(exception is ValidationException)
                {
                    context.Response.StatusCode = 400;
                    context.Response.ContentType = "application/json";
                    ValidationException e = (ValidationException)exception;
                    ValidationProblemDetails details = new ValidationProblemDetails();

                    details.Title = "Validasyon Hatası";
                    details.Errors = e.Errors.Select(i => i.ErrorMessage).ToList();

                    await context.Response.WriteAsync(JsonSerializer.Serialize(details));
                }

                await context.Response.WriteAsync(exception.Message);
            }
        }
    }
}
