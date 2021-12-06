using MediatR;
using Scout.Infrastructure.DTO.Request;
using Scout.Infrastructure.DTO.Response;
using Scout.Infrastructure.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class BuscarLoginService : IRequestHandler<LogarSiteDTO, ResponseLoginDTO>
    {
        private readonly IPessoaRepository _repository;

        public BuscarLoginService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseLoginDTO> Handle(LogarSiteDTO request, CancellationToken cancellationToken)
        {
            var response = new ResponseLoginDTO();

            var pessoa = _repository.GetPessoaByLogin(request.Login);

            if (pessoa == Guid.Empty)
            {
                response.AddError("Pessoa não existe!", "404");
                return await Task.FromResult(response);
            }

            response.Id = pessoa;
            return await Task.FromResult(response);
        }
    }
}
