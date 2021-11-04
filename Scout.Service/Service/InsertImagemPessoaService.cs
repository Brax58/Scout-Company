using Scout.Infrastructure.Repository;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertImagemPessoaService
    {
        public readonly PessoaRepository _repository;

        public InsertImagemPessoaService(PessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseImagemDTO> InsertImagemPessoa(InsertImagemPessoaDTO request)
        {
            var response = new ResponseImagemDTO();

            if (_repository.GetPessoaById(request.Id) == null)
            {
                response.AddError("Pessoa não existe!", "404");
                return response;
            }

            var imagem = Convert.FromBase64String(request.Imagem);
            await _repository.InsertImagem(request.Id, imagem);

            response.AddResponseSuccess();
            return response;
        }
    }
}
