using MediatR;
using Scout.Domain.Entity;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertLoginPessoaService : IRequestHandler<InsertPessoaDTO, ResponseCadastroPessoaDTO>
    {
        public readonly IPessoaRepository _repository;

        public InsertLoginPessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseCadastroPessoaDTO> Handle(InsertPessoaDTO request,CancellationToken cancellationToken) 
        {
            var result = new ResponseCadastroPessoaDTO();

            if (_repository.GetPessoaByLogin(request.Login) != Guid.Empty) 
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
