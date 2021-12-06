using MediatR;
using Scout.Infrastructure.DTO.Response;

namespace Scout.Infrastructure.DTO.Request
{
    public class LogarSiteDTO : IRequest<ResponseLoginDTO>
    {
        public string Login { get; set; }
        public string Senha { get; set; }

    }
}
