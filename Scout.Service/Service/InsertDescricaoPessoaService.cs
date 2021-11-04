using Scout.Infrastructure.Repository;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertDescricaoPessoaService
    {
        private readonly PessoaRepository _repository;

        public InsertDescricaoPessoaService(PessoaRepository repository)
        {
            _repository = repository;
        }

        public async Task<ResponseDescricaoDTO> InsertDescricaoPessoa(InsertDescricaoDTO request)
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
