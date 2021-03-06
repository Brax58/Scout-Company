using MediatR;
using Microsoft.AspNetCore.Mvc;
using Scout.Infrastructure.DTO.Request;
using System;
using System.Threading.Tasks;

namespace Scout.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PessoaController : ControllerBase
    {
        private readonly IMediator _mediator;

        public PessoaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("Cadastrar")]
        public async Task<ActionResult> InsertLogin([FromBody] InsertPessoaDTO request)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Id);
        }

        [HttpGet("login")]
        public async Task<ActionResult> LogarPessoa([FromQuery] LogarSiteDTO request)
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
        public async Task<ActionResult> GetFotoPerfil([FromQuery] GetFotoDTO request)
        {
            var result = await _mediator.Send(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Imagem);
        }
        
        [HttpDelete("Pessoa")]
        public async Task<ActionResult> DeletePessoa([FromQuery] Guid request)
        {
            var result = await _mediator.Send(new DeletePessoaDTO(request));

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }
    }
}
