using MediatR;
using Scout.Infrastructure.Interface;
using Scout.Infrastructure.Repository;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertImagemPessoaService : IRequestHandler<InsertImagemPessoaDTO, ResponseImagemDTO>
    {
        public readonly IPessoaRepository _repository;

        public InsertImagemPessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseImagemDTO> Handle(InsertImagemPessoaDTO request,CancellationToken cancellationToken)
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
