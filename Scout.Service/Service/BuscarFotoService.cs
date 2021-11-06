using MediatR;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class BuscarFotoService : IRequestHandler<GetFotoDTO,ResponseGetFotoDTO>
    {
        private readonly IPessoaRepository _repository;

        public BuscarFotoService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public Task<ResponseGetFotoDTO> Handle(GetFotoDTO request, CancellationToken cancellationToken) 
        {
            var response = new ResponseGetFotoDTO();

            var pessoa = _repository.GetPessoaById(request.Id);

            if (string.IsNullOrEmpty(pessoa))
            {
                response.AddError("Pessoa não existe!", "404");
                return Task.FromResult(response);
            }

            var imagem = _repository.GetFotoById(request.Id);

            if (imagem == null) 
            {
                response.AddError("Pessoa não tem imagem!", "400");
                return Task.FromResult(response);
            }

            response.Imagem = Convert.ToBase64String(imagem);
            return Task.FromResult(response);
        }
    }
}
