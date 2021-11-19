using MediatR;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using Scout.Service.DTO.Response;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Scout.Service.Service
{
    public class BuscarPostsService : IRequestHandler<BuscarPostsDTO,ResponseGetPostDTO>
    {
        private readonly IPostRepository _PostRepository;
        private readonly IPessoaRepository _PessoaRepository;

        public BuscarPostsService(IPostRepository postRepository,IPessoaRepository pessoaRepository)
        {
            _PostRepository = postRepository;
            _PessoaRepository = pessoaRepository;
        }

        public async Task<ResponseGetPostDTO> Handle(BuscarPostsDTO request,CancellationToken cancellationToken) 
        {
            var result = new ResponseGetPostDTO();

            var pessoa = _PessoaRepository.GetPessoaById(request.Id);

            if (pessoa == null) 
            {
                result.AddError("Pessoa não existe!", "404");
                return result;
            }

            return await _PostRepository.GetPosts(request.Id,request.QuantidadePosts);
        }
    }
}