﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace APICatalogo.Filters
{
    public class ApiExceptionFilter : IExceptionFilter
    {
        private readonly ILogger<ApiExceptionFilter> _logger;
        public ApiExceptionFilter(ILogger<ApiExceptionFilter> logger)
        {
            _logger = logger;
        }
        void IExceptionFilter.OnException(ExceptionContext context)
        {
            _logger.LogError(context.Exception, "Ocorreu uma exceção não tratada: Status Code 500");
            context.Result = new ObjectResult("Ocorreu um problema ao tratar a sua solicitação.")
            {
                StatusCode = StatusCodes.Status500InternalServerError
            };
        }
    }
}