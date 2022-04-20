using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace ExceptionFiltering.Utils
{
    public class MyExceptionFilter : IExceptionFilter
    {
        private readonly IHostEnvironment _hostEnvironment;
        private readonly IModelMetadataProvider _modelMetadataProvider;
        public MyExceptionFilter(IHostEnvironment hostEnvironment, IModelMetadataProvider modelMetadataProvider)
        {
            _hostEnvironment = hostEnvironment;
            _modelMetadataProvider = modelMetadataProvider;
        }

        public void OnException(ExceptionContext context)
        {
            context.Result = new ContentResult
            {
                Content = $"Ocurrio un error, pero tu tranquilo {_hostEnvironment.ApplicationName} {_hostEnvironment.EnvironmentName} {_modelMetadataProvider.ToString()}"
            };
        }
    }
}
