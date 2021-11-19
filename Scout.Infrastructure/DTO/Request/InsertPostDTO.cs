using MediatR;
using Scout.Service.DTO.Response;
using System;

namespace Scout.Service.DTO.Request
{
    public class InsertPostDTO : IRequest<ResponseCadastroPostDTO>
    {
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
