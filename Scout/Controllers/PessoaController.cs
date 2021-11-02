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
        public readonly PessoaService _service;

        public PessoaController(PessoaService service)
        {
            _service = service;
        }

        [HttpPost]
        public async Task<ActionResult> InsertLogin([FromBody]InsertPessoaDTO request)  
        {
            var result = await _service.InsertPessoa(request);

            if (result.Erros.Count >= 1) 
            {
                return BadRequest(result.Erros);
            }
            
            return Ok(result.Id);
        }

        //[HttpPut]
        //public void InsertImagem()
        //{

        //}

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
