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
        public IActionResult Register([FromBody] Communication.Request.RequestClientJson request)
        {

            var useCase = new RegisterClientUseCase();

            var reponse = useCase.Execute(request);

            return Created(string.Empty, reponse);
            
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
