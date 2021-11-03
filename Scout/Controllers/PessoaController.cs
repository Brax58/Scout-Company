using Microsoft.AspNetCore.Mvc;
using Scout.Service.DTO.BaseDTO;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using Scout.Service.Service;
using System;
using System.Threading.Tasks;

namespace Scout.Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class PessoaController : ControllerBase
    {
        public readonly InsertLoginPessoaService _InsertPessoaservice;
        public readonly InsertImagemPessoaService _InsertImagemservice;

        public PessoaController(InsertLoginPessoaService insertPessoaService, InsertImagemPessoaService insertImagemService)
        {
            _InsertPessoaservice = insertPessoaService;
            _InsertImagemservice = insertImagemService;
        }

        [HttpPost]
        public async Task<ActionResult> InsertLogin([FromBody] InsertPessoaDTO request)
        {
            var result = await _InsertPessoaservice.InsertPessoa(request);

            if (result.Erros.Count >= 1)
                return BadRequest(result.Erros);

            return Ok(result.Id);
        }

        [HttpPost("{idPessoa}/Imagens")]
        public async Task<ActionResult> InsertImagem([FromRoute] Guid idPessoa, [FromBody] InsertImagemPessoaDTO request)
        {
            request.Id = idPessoa;

            var result = await _InsertImagemservice.InsertImagemPessoa(request);

            if (result.Erros.Count >= 1)
                return BadRequest(result.Erros);

            return Ok();
        }

        //[HttpPut]
        //public void InsertDescricao()
        //{

        //}

        //[HttpGet]
        //public void GetFotoPerfil() 
        //{

        //}

        //public void LogarScout() 
        //{

        //}
    }
}
