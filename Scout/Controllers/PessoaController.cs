using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Threading.Tasks;

namespace Scout.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PessoaController : ControllerBase
    {
        public readonly IMediator _mediator;

        public PessoaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult> InsertLogin([FromBody] InsertPessoaDTO request)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Id);
        }

        [HttpGet("")]
        public async Task<ActionResult> LogarPessoa([FromQuery] LogarSiteDTO request = null)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Id);
        }

        [HttpPost("{idPessoa}/Imagem")]
        public async Task<ActionResult> InsertImagem([FromRoute] Guid idPessoa, [FromBody] InsertImagemPessoaDTO request)
        {
            request.Id = idPessoa;

            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }

        [HttpPost("{idPessoa}/Descricao")]
        public async Task<ActionResult> InsertDescricao([FromRoute] Guid idPessoa, [FromBody] InsertDescricaoDTO request)
        {
            request.Id = idPessoa;

            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }

        [HttpGet("Imagem")]
        public async Task<IActionResult> GetFotoPerfil([FromQuery] GetFotoDTO request)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Imagem);
        }
    }
}
