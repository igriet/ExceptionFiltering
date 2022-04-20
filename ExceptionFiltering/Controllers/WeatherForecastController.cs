using ExceptionFiltering.Utils;
using Microsoft.AspNetCore.Mvc;

namespace ExceptionFiltering.Controllers
{
    [ApiController]
    [Route("[controller]")]
    [TypeFilter(typeof(MyExceptionFilter))]
    public class WeatherForecastController : ControllerBase
    {
        

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public async Task<string> Get()
        {
            throw new Exception("Algo ocurrio!!");
        }
    }
}