using FirstApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace FirstApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonController : ControllerBase
    {
        private IApiLogger _logger;
        public PersonController(IApiLogger logger)
        {
                _logger= logger;
        }

        [HttpGet("/api/people")]
        public IActionResult GetPeople()
        {
            _logger.Log("start logging GetPeople()");
            _logger.Log("GetPeople() api call successful");
            return Ok(PersonOperations.GetPeople());
        }

        [HttpPost("/api/create")]

        public IActionResult CreatePerson([FromForm] Person p)
        {
            _logger.Log("CreatePerson() api call successful");
            PersonOperations.CreateNew(p);
            return Created($"Created person with aadhar {p.Aadhar} successfully",p);


        }

     

        [HttpPut("/api/update/{pAadhar}")]

        public IActionResult UpdatePerson([FromRoute] string pAadhar,[FromBody] Person updatedPerson)
        {
            try
            {

                _logger.Log("UpdatePerson() api call successful");
                PersonOperations.Update(pAadhar, updatedPerson);
                return Ok("updated successfully");
            }
            catch (Exception ex)
            {
                _logger.Log("UpdatePerson() api call not successful");
                return NotFound(ex.Message);
            }

        }
        [HttpDelete("/api/delete")] //eg:https:/localhost:7201?api?delete?pAadhar=3222332
        //parameter binding (postman)
        public IActionResult DeletePerson([FromQuery] string pAadhar)
        {
            try
            {
                _logger.Log("DeletePerson() api call successful");
                PersonOperations.Delete(pAadhar);
                return Ok("deletion successfull");
            }
            catch(Exception ex)
            {
                _logger.Log("DeletePerson() api call  not successful");
                return NotFound(ex.Message);
            }

        }
    }
}
