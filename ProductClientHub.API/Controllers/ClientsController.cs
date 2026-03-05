using Microsoft.AspNetCore.Mvc;
using ProductClientHub.API.UseCases.Clients.Register;

namespace ProductClientHub.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClientsController : ControllerBase
    {
        
        [HttpPost]
        [ProducesResponseType(typeof(Communication.Response.ResponseClientJson), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(Communication.Response.ResponseErrorMessageJson), StatusCodes.Status400BadRequest)]
        public IActionResult Register([FromBody] Communication.Request.RequestClientJson request)
        {

            try
            {
                var useCase = new RegisterClientUseCase();

                var reponse = useCase.Execute(request);

                return Created(string.Empty, reponse);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new Communication.Response.ResponseErrorMessageJson(ex.Message));
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new Communication.Response.ResponseErrorMessageJson("Erro desconhecido."));
            }
            
        }

        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] Guid id)
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok();
        }

    }
}
