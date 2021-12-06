using MediatR;
using Scout.Domain.Entity;
using Scout.Infrastructure.DTO.Request;
using Scout.Infrastructure.DTO.Response;
using Scout.Infrastructure.Interface;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class InsertPostService : IRequestHandler<InsertPostDTO, ResponseCadastroPostDTO>
    {
        private readonly IPessoaRepository _repositoryPessoa;
        private readonly IPostRepository _repositoryPost;

        public InsertPostService(IPessoaRepository repositoryPessoa, IPostRepository postRepository)
        {
            _repositoryPessoa = repositoryPessoa;
            _repositoryPost = postRepository;
        }

        public async Task<ResponseCadastroPostDTO> Handle(InsertPostDTO request, CancellationToken cancellationToken)
        {
            var result = new ResponseCadastroPostDTO();
            byte[] imagemConvert = null;
            var pessoa = _repositoryPessoa.GetPessoaById(request.IdPessoa);

            if (pessoa == null)
            {
                result.AddError("Pessoa não existe!", "404");
                return result;
            }

            if (request.Imagem != null)
                imagemConvert = Convert.FromBase64String(request.Imagem);

            await _repositoryPost.InsertPost(new Post(request.IdPessoa, imagemConvert, request.Descricao));

            result.AddResponseSuccess();
            return result;
        }
    }
}
