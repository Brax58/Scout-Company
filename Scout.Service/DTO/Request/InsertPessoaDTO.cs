using MediatR;
using Scout.Service.DTO.Response;

namespace Scout.Service.DTO.Request
{
    public class InsertPessoaDTO : IRequest<ResponseCadastroPessoaDTO>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }

    }
}
