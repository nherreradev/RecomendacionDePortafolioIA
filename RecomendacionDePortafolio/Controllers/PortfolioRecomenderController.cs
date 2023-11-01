using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using RecomendacionDePortafolio.Services;

namespace RecomendacionDePortafolio.Controllers
{
    [ApiController]
    [Route("PortfolioRecomender")]
    public class PortfolioRecomenderController : ControllerBase
    {
        private Services.ProductRecommenderIAService _productRecommenderIAService = new ProductRecommenderIAService();

        private readonly ILogger<PortfolioRecomenderController> _logger;
        public PortfolioRecomenderController(ILogger<PortfolioRecomenderController> logger)
        {
            _logger = logger;
        }

        [HttpGet("RecomendarPortafolioConservador")]
        public JsonResult GetConservador(int idProducto)
        {
            var resultado = _productRecommenderIAService.RecommendTop5Conservador(idProducto);
            return resultado;

        }

        [HttpGet("RecomendarPortafolioModerado")]
        public JsonResult GetModerado(int idProducto)
        {
            var resultado = _productRecommenderIAService.RecommendTop5Moderado(idProducto);
            return resultado;
        }

        [HttpGet("RecomendarPortafolioAgresivo")]
        public JsonResult GetAgresivo(int idProducto)
        {
            var resultado = _productRecommenderIAService.RecommendTop5Agresivo(idProducto);
            return resultado;
        }

        [HttpPost("EntrenarIA")]
        public void EntrenarIA()
        {
            _productRecommenderIAService.trainigModelML();
            
        }

        [HttpPost("EntrenarIAConservador")]
        public void EntrenarIAConservador()
        {
            _productRecommenderIAService.trainigModelMLConservador();
        }
        [HttpPost("EntrenarIAModerado")]
        public void EntrenarIAModerado()
        {
            _productRecommenderIAService.trainigModelMLModerado();

        }
        [HttpPost("EntrenarIAAgresivo")]
        public void EntrenarIAAgresivo()
        {
            _productRecommenderIAService.trainigModelMLAgresivo();

        }
    }
}