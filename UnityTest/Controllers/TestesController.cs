using Microsoft.AspNetCore.Mvc;
using UnityTest.Services;

namespace UnityTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TestesController: ControllerBase
    {

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly HotPotatoGameService _hotPotatoGameService;

        public TestesController(ILogger<WeatherForecastController> logger, HotPotatoGameService service)
        {
            _logger = logger;
            _hotPotatoGameService = service;
        }

        [HttpPost]
        public ActionResult<IEnumerable<WeatherForecast>> PostListaPalavras([FromBody] List<string> palavras)
        {
            var palavrasPorTamanho = new PalavrasPorTamanho();
            var result = palavrasPorTamanho.SelecionarPalavras(palavras);
            return Ok(result);
        }

        [HttpPost("hotPotato")]
        public ActionResult<string> Play([FromBody] int numberOfPlayers)
        {
            return _hotPotatoGameService.PlayHotPotato(numberOfPlayers);
        }
    }
}
