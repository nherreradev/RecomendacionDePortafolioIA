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


        [HttpGet("RecomendarPortafolio")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JsonResult))]
        public JsonResult Get()
        {
            var resultado = _productRecommenderIAService.RecommendTop5(1);
            return resultado;
        }

        [HttpGet("RecomendarPortafolioConservador")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JsonResult))]
        public JsonResult GetConservador()
        { 
            
            return new JsonResult("Recomendación de portafolio conservador");
        }

        [HttpGet("RecomendarPortafolioModerado")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JsonResult))]
        public JsonResult GetModerado()
        {

            return new JsonResult("Recomendación de portafolio Moderado");
        }

        [HttpGet("RecomendarPortafolioAgresivo")]
        //[ProducesResponseType(StatusCodes.Status200OK, Type = typeof(JsonResult))]
        public JsonResult GetAgresivo()
        {

            return new JsonResult("Recomendación de portafolio Agresivo");
        }

        [HttpPost("EntrenarIA")]
        public void EntrenarIA()
        {
            _productRecommenderIAService.trainigModelML();
            
        }

        [HttpPost("EntrenarIAConservador")]
        public void EntrenarIAConservador()
        {
            _productRecommenderIAService.trainigModelML();

        }
        [HttpPost("EntrenarIAModerado")]
        public void EntrenarIAModerado()
        {
            _productRecommenderIAService.trainigModelML();

        }
        //TODO Funcionalidad mediante Archivo actualizado desde API/JAVA
        //[HttpPost("EntrenarIAAgresivo")]
        //[Consumes("multipart/form-data")]
        //public IActionResult EntrenarIAAgresivo([FromForm] IFormFile file)
        //{
        //    if (file != null && file.Length > 0)
        //    {

        //        var filePath = Path.Combine("./Data", file.FileName);

        //        using (var stream = new FileStream(filePath, FileMode.Create))
        //        {
        //            file.CopyTo(stream);
        //        }

        //        //_productRecommenderIAService.trainigModelML(filePath);

        //        return Ok("Archivo recibido y procesado exitosamente.");
        //    }
        //    else
        //    {
        //        return BadRequest("No se proporcionó un archivo válido.");
        //    }

        //}
    }
}