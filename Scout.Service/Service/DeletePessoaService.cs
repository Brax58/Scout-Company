using MediatR;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class DeletePessoaService : IRequestHandler<DeletePessoaDTO,ResponseDeletePostDTO>
    {
        private readonly IPessoaRepository _repository;

        public DeletePessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public Task<ResponseDeletePostDTO> Handle(DeletePessoaDTO request, CancellationToken cancellationToken)
        {
            var response = new ResponseDeletePostDTO();

            var pessoa = _repository.GetPessoaById(request.Id);

            if (pessoa == null)
            {
                response.AddError("Pessoa não existe!", "404");
                return Task.FromResult(response);
            }

            _repository.DeletePessoa(request.Id);
            response.AddResponseSuccess();
            return Task.FromResult(response);
        }
    }
}
