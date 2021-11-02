using Scout.Domain.Entity;
using Scout.Infrastructure.Repository;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class PessoaService
    {
        public readonly PessoaRepository _repository;

        public PessoaService(PessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseCadastroPessoaDTO> InsertPessoa(InsertPessoaDTO request) 
        {
            var result = new ResponseCadastroPessoaDTO();

            if (_repository.GetPessoaById(request.Login) != Guid.Empty) 
            {
                result.AddError("Pessoa já existente!","400");
                return result;
            }

            var pessoa = new Pessoa(request.Login, request.Senha, request.Email);
            await _repository.InsertPessoa(pessoa);

            result.AddId(pessoa.Id);
            return result; 
        }
    }
}
