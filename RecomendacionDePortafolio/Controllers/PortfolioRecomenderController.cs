using Microsoft.AspNetCore.Mvc;
using RecomendacionDePortafolio.Services;

namespace RecomendacionDePortafolio.Controllers
{
    [ApiController]
    [Route("PortfolioRecomender")]
    public class PortfolioRecomenderController : ControllerBase
    {
        private Services.ProductRecommenderIAService _productRecommenderIAService = new ProductRecommenderIAService();
               

        [HttpGet("RecomendarPortafolio")]
        public JsonResult Get()
        {
            var resultado = _productRecommenderIAService.RecommendTop5(1);
            return resultado;
        }

        [HttpPost("EntrenarIA")]
        public void EntrenarIA()
        {
            _productRecommenderIAService.trainigModelML();
            
        }
    }
}