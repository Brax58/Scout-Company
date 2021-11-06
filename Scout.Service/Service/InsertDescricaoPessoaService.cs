using MediatR;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertDescricaoPessoaService : IRequestHandler<InsertDescricaoDTO, ResponseDescricaoDTO>
    {
        private readonly IPessoaRepository _repository;

        public InsertDescricaoPessoaService(IPessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseDescricaoDTO> Handle(InsertDescricaoDTO request,CancellationToken cancellationToken)
        {
            var response = new ResponseDescricaoDTO();

            if (_repository.GetPessoaById(request.Id) == null)
            {
                response.AddError("Pessoa não existe!", "404");
                return response;
            }
            await _repository.InsertDescricao(request.Id, request.Descricao);

            response.AddResponseSuccess();
            return response;
        }
    }
}
