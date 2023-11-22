using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarController : ControllerBase
    {
        private Car _car;
        private IApiLogger _logger;
        private CarAccessories _carAccessories;
       

        public CarController(Car c,IApiLogger logger,CarAccessories ca, IAccessories newAccessories)
        {
           
            _car = c;
            _logger = logger;
            _logger.Log("carcontroller instance is careted");

            _carAccessories = ca;
            _logger = logger;
            _logger.Log("car accessories started");



        }
        [HttpGet("/driver")]
        public IActionResult Accessories()
        {
            _logger.Log("Accessories() api is called successfully");
            return Ok("This are the car accessories");
        }
    }
}
