using MediatR;
using Scout.Infrastructure.DTO.Response;
using System;

namespace Scout.Infrastructure.DTO.Request
{
    public class InsertPostDTO : IRequest<ResponseCadastroPostDTO>
    {
        public string Descricao { get; set; }
        public string Imagem { get; set; }
        public Guid IdPessoa { get; set; }
    }
}
