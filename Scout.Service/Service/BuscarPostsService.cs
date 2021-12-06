using MediatR;
using Scout.Infrastructure.DTO.Response;
using Scout.Infrastructure.Interface;
using Scout.Service.DTO.Request;
using System;
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

            var posts = await _PostRepository.GetPosts(request.Id,request.QuantidadePosts);

            foreach (var post in posts)
            {
                var imagemPessoa = Convert.ToBase64String(post.ImagemPessoa);
                var imagemPost = Convert.ToBase64String(post.ImagemPost);

                result.AdicionarPost(post.NomePessoa,imagemPessoa,imagemPost,post.DescricaoPost);
            }

            return result;
        }
    }
}