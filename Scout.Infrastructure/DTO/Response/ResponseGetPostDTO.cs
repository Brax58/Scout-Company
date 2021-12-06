using Scout.Infrastructure.DTO.BaseDTO;
using System.Collections.Generic;

namespace Scout.Infrastructure.DTO.Response
{
    public class ResponseGetPostDTO : Error
    {
        public List<PostUnicoResult> Posts { get; set; }

        public void AdicionarPost(string nome,string imagemPessoa,string imagemPost,string descricaoPost)
        {

            Posts.Add(new PostUnicoResult(imagemPessoa, descricaoPost, nome,imagemPost));
        }

        public ResponseGetPostDTO()
        {
            Posts = new List<PostUnicoResult>();
        }

    }

    public class PostUnicoBanco
    {
        public byte[] ImagemPessoa { get; set; }
        public string NomePessoa { get; set; }
        public byte[] ImagemPost { get; set; }
        public string DescricaoPost { get; set; }


    }

    public class PostUnicoResult 
    {
        public string ImagemPessoa { get; set; }
        public string NomePessoa { get; set; }
        public string ImagemPost { get; set; }
        public string DescricaoPost { get; set; }

        public PostUnicoResult(string imagemPessoa, string descricaoPost, string nomePessoa, string imagemPost)
        {
            ImagemPessoa = imagemPessoa;
            NomePessoa = nomePessoa;
            ImagemPost = imagemPost;
            DescricaoPost = descricaoPost;
        }
    }
}
