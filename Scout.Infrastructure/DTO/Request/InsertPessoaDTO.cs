using MediatR;
using Scout.Infrastructure.DTO.Response;

namespace Scout.Infrastructure.DTO.Request
{
    public class InsertPessoaDTO : IRequest<ResponseCadastroPessoaDTO>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}
