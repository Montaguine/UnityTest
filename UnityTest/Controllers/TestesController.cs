using Microsoft.AspNetCore.Mvc;
using UnityTest.Services;

namespace UnityTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesController: ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;

        public TestesController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<IEnumerable<WeatherForecast>> PostListaPalavras([FromBody] List<string> palavras)
        {
            var palavrasPorTamanho = new PalavrasPorTamanho();
            var result = palavrasPorTamanho.SelecionarPalavras(palavras);
            return Ok(result);
        }
    }
}
