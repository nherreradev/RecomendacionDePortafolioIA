using Microsoft.AspNetCore.Mvc;
using RecomendacionDePortafolio.Services;

namespace RecomendacionDePortafolio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PortfolioRecomenderController : ControllerBase
    {
        private Services.ProductRecommenderIAService _productRecommenderIAService = new ProductRecommenderIAService();
        
       

        [HttpGet(Name = "GetWeatherForecast")]
        public JsonResult Get()
        {
            var resultado = _productRecommenderIAService.RecommendTop5(1);
            return resultado;
        }
    }
}