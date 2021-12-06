using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scout.Infrastructure.DTO.Request;
using Scout.Service.DTO.Request;
using System;
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

        [HttpGet]
        public async Task<ActionResult> GetPosts([FromQuery] Guid id, [FromQuery] int quantidadePosts)
        {
            var result = await _mediator.Send(new BuscarPostsDTO(quantidadePosts, id));

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok();
        }
    }
}
