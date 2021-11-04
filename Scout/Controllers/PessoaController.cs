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
        public readonly InsertDescricaoPessoaService _InsertDescricaoservice;

        public PessoaController(InsertLoginPessoaService insertPessoaService, InsertImagemPessoaService insertImagemService,
                                InsertDescricaoPessoaService insertDescricaoPessoaService)
        {
            _InsertPessoaservice = insertPessoaService;
            _InsertImagemservice = insertImagemService;
            _InsertDescricaoservice = insertDescricaoPessoaService;
        }

        [HttpPost]
        public async Task<ActionResult> InsertLogin([FromBody] InsertPessoaDTO request)
        {
            var result = await _InsertPessoaservice.InsertPessoa(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Id);
        }

        [HttpPost("{idPessoa}/Imagem")]
        public async Task<ActionResult> InsertImagem([FromRoute] Guid idPessoa, [FromBody] InsertImagemPessoaDTO request)
        {
            request.Id = idPessoa;

            var result = await _InsertImagemservice.InsertImagemPessoa(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }
        
        [HttpPost("{idPessoa}/Descricao")]
        public async Task<ActionResult> InsertDescricao([FromRoute] Guid idPessoa, [FromBody] InsertDescricaoDTO request)
        {
            request.Id = idPessoa;

            var result = await _InsertDescricaoservice.InsertDescricaoPessoa(request);

            if (result.Erro != null)
                return BadRequest(result.Erro);

            return Ok(result.Success);
        }

        //[HttpGet]
        //public void GetFotoPerfil() 
        //{

        //}

        //public void LogarScout() 
        //{

        //}
    }
}
