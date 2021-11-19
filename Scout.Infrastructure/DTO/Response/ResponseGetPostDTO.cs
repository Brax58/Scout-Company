using Scout.Service.DTO.BaseDTO;
using System.Collections.Generic;

namespace Scout.Service.DTO.Response
{
    public class ResponseGetPostDTO : Error
    {
        public List<PostUnico> Posts { get; set; }

        public void AdicionarPost(string nome,string imagemPessoa,string imagemPost,string descricaoPost)
        {

            Posts.Add(new PostUnico(imagemPessoa,nome,imagemPost,descricaoPost));
        }

    }

    public class PostUnico
    {
        public PostUnico(byte[] imagemPessoa, string nomePessoa, byte[] imagemPost, string descricaoPost)
        {
            ImagemPessoa = imagemPessoa;
            NomePessoa = nomePessoa;
            ImagemPost = imagemPost;
            DescricaoPost = descricaoPost;
        }

        public byte[] ImagemPessoa { get; set; }
        public string NomePessoa { get; set; }
        public byte[] ImagemPost { get; set; }
        public string DescricaoPost { get; set; }


    }

    public class PostUnicoByRepository 
    {
        public byte[] ImagemPessoa { get; set; }
        public string NomePessoa { get; set; }
        public byte[] ImagemPost { get; set; }
        public string DescricaoPost { get; set; }
    }
}
