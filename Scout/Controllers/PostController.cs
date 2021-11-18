using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scout.Service.DTO.Request;
using System.Threading.Tasks;

namespace Scout.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PostController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PostController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> InsertPost([FromBody] InsertPostDTO request)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }

        //[HttpGet]
        //public void GetPost()
        //{

        //}
    }
}
