using Scout.Service.DTO.BaseDTO;
using System.Collections.Generic;

namespace Scout.Service.DTO.Response
{
    public class ResponseGetPostDTO : Error
    {
        public List<PostUnico> Posts { get; set; }

    }

    public class PostUnico
    {
        public string ImagemPessoa { get; set; }
        public string LoginPessoa { get; set; }
        public string ImagemPost { get; set; }
        public string Descricao { get; set; }
    }
}
